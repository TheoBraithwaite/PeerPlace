using System;
using System.IO;
using System.Security.AccessControl;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPeerPlace
{
    public partial class FormPeer : Form
    {
        bool newAccount = false;

        //Path variables
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string saveOpenLocation = Path.Combine(path + "\\GitHub\\PeerPlace\\PeerPlace\\clientList.csv");

        List<string> userList = new List<string>();
        List<string> passwordList = new List<string>();

        //The password key to be used in the Encrypt/Decrypt method
        int passKey = 200;

        Main console = new Main();
        int j = 0;

        //Message strings
        string welcomeMessage = "Welcome! Please enter your credentials.";

        //Error strings
        string errorPassword = "Incorrect username and/or password.";
        string errorUser = "A user already exists with that username.";
        string errorNoUser = "A user does not exist with that username. Please register for an account using the button below.";
        string errorEmptyUser = "Username field is empty. Please enter a username.";
        string errorCharacter = "The character you're trying to enter is forbidden.";
        string errorMatch = "Password fields do not match, or a password field is empty.";
        string errorFile = "Error with login file.";
        string errorCrash = "Fatal error";

        public FormPeer()
        {
            InitializeComponent();
        }

        #region EncryptMethod
        /// <summary>
        /// This encryption/decryption method works in binary.
        /// It gets the password in binary, the encryption in binary and uses the XOR technique to encrypt/decrypt the password.
        /// </summary>
        /// <param name="szPlainText"></param>
        /// <param name="szEncryptionKey"></param>
        /// <returns></returns>
        public string EncryptDecrypt(string szPlainText, int szEncryptionKey)
        {
            StringBuilder szInputStringBuild = new StringBuilder(szPlainText);
            StringBuilder szOutStringBuild = new StringBuilder(szPlainText.Length);
            char Textch;
            //FOR each character in the password
            for (int iCount = 0; iCount < szPlainText.Length; iCount++)
            {
                //Get the current text character
                Textch = szInputStringBuild[iCount];
                //Use XOR conditional operator for the current character with the encryption key.
                //(Operates in binary)
                Textch = (char)(Textch ^ szEncryptionKey);
                szOutStringBuild.Append(Textch);
            }
            return szOutStringBuild.ToString();
        }
        #endregion

        #region LoginMethods

        /// <summary>
        /// Display appropriate error in the notification label on the form
        /// </summary>
        /// <param name="error">The variable "error" is the string error displayed to the user.</param>
        public void LabelMethod(string error)
        {
            //Display login error.
            labelMessage.Visible = true;
            //Restart the timer
            tmrLabel.Start();
            labelMessage.Text = error;
        }

        public void LoginMethod(bool newLogin)
        {
            if (newLogin)
            {
                LblExistingAccount.Visible = true; //Show "Already have an account?"
                btnExistingLogin.Visible = true; //Show "Login here" button.
                btnRegister.Visible = true;

                LblAccount.Visible = false;
                btnCreateAccount.Visible = false;

                //Show controls to repeat password.
                LblReenterPassword.Visible = true;
                txtBoxReenterPwd.Visible = true;

                //Reset new account to false.
                newAccount = false;
            }
            else
            {
                //User has an existing account. Swap label and buttons. Show option to create account.
                LblExistingAccount.Visible = false; //Show "Don't have an account?" label.
                btnExistingLogin.Visible = false; //Show "Create account here" button.

                LblAccount.Visible = true;
                btnCreateAccount.Visible = true;
                btnRegister.Visible = false;

                //Don't show repeat password controls.
                LblReenterPassword.Visible = false;
                txtBoxReenterPwd.Visible = false;
            }    
        }

        #endregion

        /// <summary>
        /// Upon loading the form, set the controls appropriately for a login action.
        /// Then use the reader to open a file stored in openLocation.
        /// Read the file, split and store it in a CSV array.
        /// The notification label displays an appropriate error depending on the issue.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPeer_Load(object sender, EventArgs e)
        {
            labelMessage.Visible = false;

            //Hide the password entered into the two password textboxes with this aesterisk character.
            char c = '\u25cf';
            txtBoxReenterPwd.PasswordChar = c;
            txtBoxPassword.PasswordChar = c;

            //On form load, assume user already has an account.
            LblExistingAccount.Visible = false; //Show "Don't have an account?" label.
            btnExistingLogin.Visible = false;
            btnRegister.Visible = false;
            buttonEncrypt.Visible = false;

            LblReenterPassword.Visible = false;
            txtBoxReenterPwd.Visible = false;

            using var reader = new StreamReader(saveOpenLocation);
            {
                string username;
                string password;
                string currentUser = txtBoxUsername.Text;
                string currentPassword = txtBoxPassword.Text;
                string line = "";
                string[] csvArray;

                while (!reader.EndOfStream)
                {
                    try
                    {
                        //Read a line from the file
                        line = reader.ReadLine();
                        //Split the clients in the line using an array
                        csvArray = line.Split(',');
                        //Check if the array has the correct number of elements
                        if (csvArray.Length == 2)
                        {

                            //Extract the data into separate variables
                            username = csvArray[0];
                            password = csvArray[1];

                            //Add clients to list.
                            userList.Add(username);

                            //Add password to list.
                            passwordList.Add(password);
                        }
                        else
                        {
                            LabelMethod(errorFile);
                        }
                    }
                    catch
                    {
                        LabelMethod(errorCrash);
                    }
                }
                LabelMethod(welcomeMessage);
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            //User has no existing account. Swap label and buttons. Show option to login. Set newAccount to true.
            newAccount = true;

            //Pass newAccount value to LoginMethod to create a new account.
            LoginMethod(newAccount);
        }

        private void btnExistingLogin_Click(object sender, EventArgs e)
        {
            //Pass newAccount value to LoginMethod to hide and show appropriate controls.
            LoginMethod(newAccount);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //FOR each user in the userList
            for (int i = 0; i < userList.Count; i++)
            {
                //IF the current userList item matches the username entered into the textbox
                //AND the current passwordList item (being decrypted at this point) matches the password entered into the textbox
                if (userList[i] == txtBoxUsername.Text && EncryptDecrypt(passwordList[i], passKey) == txtBoxPassword.Text)
                {
                    //THEN hide the current window and show the main console
                    this.Hide();
                    console.Show();
                }
                else
                {
                    //Else add 1 to j
                    j++;

                    //If the username field is empty, THEN
                    if (txtBoxUsername.Text == "")
                    {
                        //Show an error.
                        LabelMethod(errorEmptyUser);
                    }
                    else
                    {
                        //Show the error message with the label method
                        LabelMethod(errorPassword);
                        //Reset j to 0 and return.
                        j = 0;
                    }
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //FOR each user in the userList
            for (int i = 0; i < userList.Count; i++)
            {
                //IF the current userList item matches the username entered into the textbox
                //AND the current passwordList item (being decrypted at this point) matches the password entered into the textbox
                if (userList[i] == txtBoxUsername.Text)
                {
                    LabelMethod(errorUser);
                    return;
                }
            }
            if (txtBoxPassword.Text == txtBoxReenterPwd.Text && txtBoxPassword.Text != "")
            {
                string username = txtBoxUsername.Text;
                string password = EncryptDecrypt(txtBoxPassword.Text, passKey);

                userList.Add(username);
                passwordList.Add(password);


                using var writer = File.AppendText(saveOpenLocation);
                {
                    writer.WriteLine();
                    writer.WriteLine(username + ',' + password);


                    string currentUser = txtBoxUsername.Text;
                    string currentPassword = txtBoxPassword.Text;
                }
                MessageBox.Show("Saved to " + saveOpenLocation);
            }
            else
            {
                LabelMethod(errorMatch); //Password does not match account error.
            }
        }

        /// <summary>
        /// Button encrypts all passwords and saves to the login CSV.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            //FOR each user in the userList
            for (int i = 0; i < userList.Count; i++)
            {
                //string saveLocation = @"C:\Users\BEASTY-BOY\desktop\PeerPlace\clientList.csv";
                File.AppendAllText(saveOpenLocation, userList[i] + ',' + passwordList[i] + Environment.NewLine);
            }
        }

        /// <summary>
        /// This KeyDown method performs the same action as a mouse click on the button in focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPeer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        /// <summary>
        /// After showing the notification label for a pre-determined amount of time, this method hides labelMessage and stops the timer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrLabel_Tick(object sender, EventArgs e)
        {
            //After the timer interval, hide the label and stop the timer.
            labelMessage.Visible = false;
            tmrLabel.Stop();
        }

        private void txtBoxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            //IF the keypress matches a character blocked by the form, show the error in the label.
            if (e.Handled = e.KeyChar != (char)Keys.Back && char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                LabelMethod(errorCharacter);
            }    
        }
    }
}
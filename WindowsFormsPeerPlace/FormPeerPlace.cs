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
        List<string> userList = new List<string>();
        List<string> passwordList = new List<string>();
        Main console = new Main();
        int j = 0;
        bool incorrectPassword = false;

        public FormPeer()
        {
            InitializeComponent();
        }

#region EncryptMethod
        public string EncryptDecrypt(string szPlainText, int szEncryptionKey)
        {
            StringBuilder szInputStringBuild = new StringBuilder(szPlainText);
            StringBuilder szOutStringBuild = new StringBuilder(szPlainText.Length);
            char Textch;
            for (int iCount = 0; iCount < szPlainText.Length; iCount++)
            {
                Textch = szInputStringBuild[iCount];
                Textch = (char)(Textch ^ szEncryptionKey);
                szOutStringBuild.Append(Textch);
            }
            return szOutStringBuild.ToString();
        }
        #endregion

#region LoginMethods

        public void LabelMethod (bool incorrectPassword)
        {
            if (incorrectPassword == true)
            {
                tmrLabel.Stop();
                //Display login error.
                labelMessage.Visible = true;
                tmrLabel.Start();
                labelMessage.Text = "Incorrect username or password.";
            }
        }

#endregion
        private void FormPeer_Load(object sender, EventArgs e)
        {
            labelMessage.Visible = false;

            //Hide the password entered into the two password textboxes with aesterisks.
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

            string openLocation = @"C:\Users\BEASTY-BOY\Desktop\clientList.csv";
            using var reader = new StreamReader(openLocation);
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

                            //Encrypts the password.
                            password = EncryptDecrypt(password, 200);

                            //Add password to list.
                            passwordList.Add(password);
                        }
                        else
                        {
                            MessageBox.Show("Error logging in");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Fatal error");
                    }
                }
                MessageBox.Show("Completed.");
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            //User has no existing account. Swap label and buttons. Show option to login. Set newAccount to true.
            newAccount = true;
            LblExistingAccount.Visible = true; //Show "Already have an account?"
            btnExistingLogin.Visible = true; //Show "Login here" button.
            btnRegister.Visible = true;

            LblAccount.Visible = false;
            btnCreateAccount.Visible = false;

            //Show controls to repeat password.
            LblReenterPassword.Visible = true;
            txtBoxReenterPwd.Visible = true;


        }

        private void btnExistingLogin_Click(object sender, EventArgs e)
        {
            //User has an existing account. Swap label and buttons. Show option to create account.
            LblExistingAccount.Visible = false; //Show "Don't have an account?"
            btnExistingLogin.Visible = false; //Show "Create account here" button.

            LblAccount.Visible = true;
            btnCreateAccount.Visible = true;
            btnRegister.Visible = false;

            //Show controls to repeat password.
            LblReenterPassword.Visible = false;
            txtBoxReenterPwd.Visible = false;
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
                //AND the current passwordList item matches the password entered into the textbox
                if (userList[i] == txtBoxUsername.Text && passwordList[i] == txtBoxPassword.Text)
                {
                    //THEN hide the current window and show the main console
                    this.Hide();
                    console.Show();
                }
                else
                {
                    //Else add 1 to j
                    j++;
                    //If j equals the userList count of items THEN
                    if (j == userList.Count)
                    {
                        LabelMethod(incorrectPassword = true);
                        j = 0;
                        return;
                    }
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string saveLocation = @"C:\Users\BEASTY-BOY\Desktop\clientList.csv";

            //IF both passwords match in the two fields
            if (txtBoxPassword.Text == txtBoxReenterPwd.Text)
            {
                string username = txtBoxUsername.Text;
                string password = EncryptDecrypt(txtBoxPassword.Text, 200);

                userList.Add(username);
                passwordList.Add(password);


                using var writer = File.AppendText(saveLocation);
                {
                    writer.WriteLine();
                    writer.WriteLine(username + ',' + password);


                    string currentUser = txtBoxUsername.Text;
                    string currentPassword = txtBoxPassword.Text;
                }
                MessageBox.Show("Saved to " + saveLocation);
            }
            else
            {
                labelMessage.Visible = true;
                labelMessage.Text = "Password fields do not match.";
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
                string saveLocation = @"C:\Users\BEASTY-BOY\desktop\clientList.csv";
                File.AppendAllText(saveLocation, userList[i] + ',' + passwordList[i] + Environment.NewLine);
            }
        }

        private void FormPeer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void tmrLabel_Tick(object sender, EventArgs e)
        {
            labelMessage.Visible = false;
            tmrLabel.Stop();
        }
    }
}
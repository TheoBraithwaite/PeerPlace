using System.IO;

namespace WindowsFormsPeerPlace
{
    public partial class FormPeer : Form
    {
        bool newAccount = false;
        List<string> userList = new List<string>();
        List<string> passwordList = new List<string>();
        int j = 0;

        public FormPeer()
        {
            InitializeComponent();
        }

        private void FormPeer_Load(object sender, EventArgs e)
        {
            //On form load, assume user already has an account.
            LblExistingAccount.Visible = false; //Show "Don't have an account?" label.
            btnExistingLogin.Visible = false;
            btnRegister.Visible = false;

            LblReenterPassword.Visible = false;
            txtBoxReenterPwd.Visible = false;

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
            this.Hide();
            Main console = new Main();
            string openLocation = @"C:\Users\BEASTY-BOY\desktop\clients.csv";
            string username;
            string password;
            string currentUser = txtBoxUsername.Text;
            string currentPassword = txtBoxPassword.Text;
            StreamReader reader = new StreamReader(openLocation);
            string line = "";
            string[] csvArray;


            reader = File.OpenText(openLocation);
            while(!reader.EndOfStream)
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
                        //Add passwords to list.
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

            //FOR each user in the userList
            for (int i = 0; i < userList.Count; i++)
            {
                //IF the current userList item matches the username entered into the textbox
                //AND the current passwordList item matches the password entered into the textbox
                if (userList[i] == txtBoxUsername.Text && passwordList[i] == txtBoxPassword.Text)
                {
                    //THEN show the main console
                    console.Show();
                }
                else
                {
                    //Else add 1 to j
                    j++;
                    //If j equals the userList count of items THEN
                    if (j == userList.Count)
                    {
                        //Display incorrect password.
                        MessageBox.Show("Wrong username or password.");
                        return;
                    }
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;
            string saveLocation = @"C:\Users\BEASTY-BOY\desktop\clients.csv";
            File.AppendAllText(saveLocation,username + ',' + password + Environment.NewLine);


            //Create a writer and open the file
            //TextWriter tw = new StreamWriter (saveLocation);
            //Write the username and password to a file.
            
            //tw.Write(username + ',');
            //tw.WriteLine(password);
            //Close the stream.
            //tw.Close();
            MessageBox.Show("Saved to " + saveLocation);
        }
    }
}
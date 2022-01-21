namespace WindowsFormsPeerPlace
{
    public partial class FormPeer : Form
    {
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
            //User has no existing account. Swap label and buttons. Show option to login.
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
    }
}
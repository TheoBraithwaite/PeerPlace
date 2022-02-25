namespace WindowsFormsPeerPlace
{
    partial class FormPeer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblAccount = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.LblExistingAccount = new System.Windows.Forms.Label();
            this.btnExistingLogin = new System.Windows.Forms.Button();
            this.txtBoxReenterPwd = new System.Windows.Forms.TextBox();
            this.LblReenterPassword = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.tmrLabel = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Location = new System.Drawing.Point(237, 77);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(100, 23);
            this.txtBoxUsername.TabIndex = 0;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(237, 136);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(100, 23);
            this.txtBoxPassword.TabIndex = 1;
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Location = new System.Drawing.Point(165, 80);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(63, 15);
            this.LabelUsername.TabIndex = 2;
            this.LabelUsername.Text = "Username:";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(165, 139);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(60, 15);
            this.LblPassword.TabIndex = 3;
            this.LblPassword.Text = "Password:";
            // 
            // LblAccount
            // 
            this.LblAccount.AutoSize = true;
            this.LblAccount.Location = new System.Drawing.Point(146, 240);
            this.LblAccount.Name = "LblAccount";
            this.LblAccount.Size = new System.Drawing.Size(131, 15);
            this.LblAccount.TabIndex = 4;
            this.LblAccount.Text = "Don\'t have an account?";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(283, 236);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(142, 23);
            this.btnCreateAccount.TabIndex = 5;
            this.btnCreateAccount.Text = "Create an account here";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // LblExistingAccount
            // 
            this.LblExistingAccount.AutoSize = true;
            this.LblExistingAccount.Location = new System.Drawing.Point(135, 240);
            this.LblExistingAccount.Name = "LblExistingAccount";
            this.LblExistingAccount.Size = new System.Drawing.Size(142, 15);
            this.LblExistingAccount.TabIndex = 6;
            this.LblExistingAccount.Text = "Already have an account?";
            // 
            // btnExistingLogin
            // 
            this.btnExistingLogin.Location = new System.Drawing.Point(283, 236);
            this.btnExistingLogin.Name = "btnExistingLogin";
            this.btnExistingLogin.Size = new System.Drawing.Size(142, 23);
            this.btnExistingLogin.TabIndex = 7;
            this.btnExistingLogin.Text = "Click to login here";
            this.btnExistingLogin.UseVisualStyleBackColor = true;
            this.btnExistingLogin.Click += new System.EventHandler(this.btnExistingLogin_Click);
            // 
            // txtBoxReenterPwd
            // 
            this.txtBoxReenterPwd.Location = new System.Drawing.Point(237, 165);
            this.txtBoxReenterPwd.Name = "txtBoxReenterPwd";
            this.txtBoxReenterPwd.Size = new System.Drawing.Size(100, 23);
            this.txtBoxReenterPwd.TabIndex = 8;
            // 
            // LblReenterPassword
            // 
            this.LblReenterPassword.AutoSize = true;
            this.LblReenterPassword.Location = new System.Drawing.Point(119, 168);
            this.LblReenterPassword.Name = "LblReenterPassword";
            this.LblReenterPassword.Size = new System.Drawing.Size(108, 15);
            this.LblReenterPassword.TabIndex = 9;
            this.LblReenterPassword.Text = "Re-enter password:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(168, 200);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 30);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(283, 200);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(109, 30);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(283, 200);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(109, 30);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(452, 12);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(78, 24);
            this.buttonEncrypt.TabIndex = 13;
            this.buttonEncrypt.Text = "Encrypt All";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMessage.Location = new System.Drawing.Point(357, 77);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(164, 111);
            this.labelMessage.TabIndex = 14;
            this.labelMessage.Text = "Notification label";
            // 
            // tmrLabel
            // 
            this.tmrLabel.Interval = 5000;
            this.tmrLabel.Tick += new System.EventHandler(this.tmrLabel_Tick);
            // 
            // FormPeer
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 264);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.LblReenterPassword);
            this.Controls.Add(this.txtBoxReenterPwd);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.LblExistingAccount);
            this.Controls.Add(this.btnExistingLogin);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.LblAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPeer";
            this.Text = "Peer Place";
            this.Load += new System.EventHandler(this.FormPeer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPeer_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBoxUsername;
        private TextBox txtBoxPassword;
        private Label LabelUsername;
        private Label LblPassword;
        private Label LblAccount;
        private Button btnCreateAccount;
        private Label LblExistingAccount;
        private Button btnExistingLogin;
        private TextBox txtBoxReenterPwd;
        private Label LblReenterPassword;
        private Button btnExit;
        private Button btnLogin;
        private Button btnRegister;
        private Button buttonEncrypt;
        private Label labelMessage;
        private System.Windows.Forms.Timer tmrLabel;
    }
}
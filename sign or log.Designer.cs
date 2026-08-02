namespace WinFormsApp6
{
    partial class sign_or_log
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sign_or_log));
            btnSignin = new Button();
            btnLogin = new Button();
            lblHi = new Label();
            lblNoAccount = new Label();
            lblAccount = new Label();
            SuspendLayout();
            // 
            // btnSignin
            // 
            btnSignin.BackColor = Color.Maroon;
            btnSignin.FlatAppearance.BorderSize = 0;
            btnSignin.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnSignin.FlatStyle = FlatStyle.Flat;
            btnSignin.Font = new Font("Angkor", 14F);
            btnSignin.ForeColor = Color.White;
            btnSignin.Location = new Point(137, 210);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(246, 46);
            btnSignin.TabIndex = 0;
            btnSignin.Text = "Sign up";
            btnSignin.UseVisualStyleBackColor = false;
            btnSignin.Click += btnSignin_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Maroon;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Angkor", 14F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(137, 354);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(246, 46);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblHi
            // 
            lblHi.AutoSize = true;
            lblHi.BackColor = Color.Transparent;
            lblHi.Font = new Font("Angkor", 20F);
            lblHi.ForeColor = Color.Black;
            lblHi.Location = new Point(88, 54);
            lblHi.Name = "lblHi";
            lblHi.Size = new Size(349, 61);
            lblHi.TabIndex = 2;
            lblHi.Text = "Hi, NMU student";
            // 
            // lblNoAccount
            // 
            lblNoAccount.AutoSize = true;
            lblNoAccount.BackColor = Color.Transparent;
            lblNoAccount.Font = new Font("Angkor", 10F);
            lblNoAccount.Location = new Point(137, 177);
            lblNoAccount.Name = "lblNoAccount";
            lblNoAccount.Size = new Size(250, 30);
            lblNoAccount.TabIndex = 3;
            lblNoAccount.Text = "Don't Have An Account ?";
            lblNoAccount.Click += lblNoAccount_Click;
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.BackColor = Color.Transparent;
            lblAccount.Font = new Font("Angkor", 10F);
            lblAccount.Location = new Point(170, 321);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(194, 30);
            lblAccount.TabIndex = 4;
            lblAccount.Text = "Have An Account ?";
            // 
            // sign_or_log
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(518, 513);
            Controls.Add(lblAccount);
            Controls.Add(lblNoAccount);
            Controls.Add(lblHi);
            Controls.Add(btnLogin);
            Controls.Add(btnSignin);
            Name = "sign_or_log";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sign_or_log";
            Load += sign_or_log_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignin;
        private Button btnLogin;
        private Label lblHi;
        private Label lblNoAccount;
        private Label lblAccount;
    }
}
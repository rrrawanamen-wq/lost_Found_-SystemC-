namespace WinFormsApp6
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblTitle = new Label();
            lblPhone = new Label();
            lblName = new Label();
            lblID = new Label();
            txtPhone = new TextBox();
            txtID = new TextBox();
            txtName = new TextBox();
            lblCollege = new Label();
            cmpCollege = new ComboBox();
            btnLogin = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(84, 37);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(354, 55);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Lost Items System";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.BackColor = Color.Transparent;
            lblPhone.Font = new Font("Microsoft Sans Serif", 12F);
            lblPhone.Location = new Point(49, 279);
            lblPhone.Margin = new Padding(2, 0, 2, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(69, 25);
            lblPhone.TabIndex = 1;
            lblPhone.Text = "Phone";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Microsoft Sans Serif", 12F);
            lblName.Location = new Point(49, 170);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 25);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            lblName.Click += lblName_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BackColor = Color.Transparent;
            lblID.Font = new Font("Microsoft Sans Serif", 12F);
            lblID.Location = new Point(49, 223);
            lblID.Margin = new Padding(2, 0, 2, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(31, 25);
            lblID.TabIndex = 3;
            lblID.Text = "ID";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.Tan;
            txtPhone.Font = new Font("Segoe UI", 11F);
            txtPhone.ForeColor = Color.Black;
            txtPhone.Location = new Point(146, 282);
            txtPhone.Margin = new Padding(2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(339, 32);
            txtPhone.TabIndex = 5;
            // 
            // txtID
            // 
            txtID.BackColor = Color.Tan;
            txtID.Font = new Font("Segoe UI", 11F);
            txtID.ForeColor = Color.Black;
            txtID.Location = new Point(146, 226);
            txtID.Margin = new Padding(2);
            txtID.Name = "txtID";
            txtID.Size = new Size(339, 32);
            txtID.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.BackColor = Color.Tan;
            txtName.Font = new Font("Segoe UI", 11F);
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(146, 173);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(339, 32);
            txtName.TabIndex = 7;
            // 
            // lblCollege
            // 
            lblCollege.AutoSize = true;
            lblCollege.BackColor = Color.Transparent;
            lblCollege.Font = new Font("Microsoft Sans Serif", 12F);
            lblCollege.Location = new Point(49, 334);
            lblCollege.Margin = new Padding(2, 0, 2, 0);
            lblCollege.Name = "lblCollege";
            lblCollege.Size = new Size(79, 25);
            lblCollege.TabIndex = 8;
            lblCollege.Text = "College";
            // 
            // cmpCollege
            // 
            cmpCollege.BackColor = Color.Tan;
            cmpCollege.Font = new Font("Segoe UI", 11F);
            cmpCollege.ForeColor = Color.Black;
            cmpCollege.FormattingEnabled = true;
            cmpCollege.Items.AddRange(new object[] { "Faculty of Medicine", "Faculty of Pharmacy", "Faculty of Engineering", "Faculty of Computer Sciences & Engineering", "Faculty of Dentistry", "Faculty of Business", "Faculty of Law", "Faculty of Nursing", "Faculty of Science", "Faculty of Applied Health Science", "Faculty of Textile Science Engineering", "Faculty of Physical Therapy", "Faculty of Social & Human Sciences", "Faculty of Mass Media & Communication ", "Faculty of Graduate Studies" });
            cmpCollege.Location = new Point(146, 334);
            cmpCollege.Margin = new Padding(2);
            cmpCollege.Name = "cmpCollege";
            cmpCollege.Size = new Size(339, 33);
            cmpCollege.TabIndex = 9;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Maroon;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(203, 426);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(106, 41);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(189, 83);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 57);
            label1.TabIndex = 11;
            label1.Text = " NMU";
            label1.Click += label1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(518, 513);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(cmpCollege);
            Controls.Add(lblCollege);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(txtPhone);
            Controls.Add(lblID);
            Controls.Add(lblName);
            Controls.Add(lblPhone);
            Controls.Add(lblTitle);
            Margin = new Padding(2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblPhone;
        private Label lblName;
        private Label lblID;
        private TextBox txtPhone;
        private TextBox txtID;
        private TextBox txtName;
        private Label lblCollege;
        private ComboBox cmpCollege;
        private Button btnLogin;
        private Label label1;
    }
}

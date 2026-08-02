namespace WinFormsApp6
{
    partial class ProfileForm
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
            lblName = new Label();
            lblID = new Label();
            lblPhone = new Label();
            lblCollege = new Label();
            button1 = new Button();
            picProfile = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 11F);
            lblName.Location = new Point(44, 68);
            lblName.Name = "lblName";
            lblName.Size = new Size(88, 30);
            lblName.TabIndex = 0;
            lblName.Text = "Name : ";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 11F);
            lblID.Location = new Point(44, 162);
            lblID.Name = "lblID";
            lblID.Size = new Size(45, 30);
            lblID.TabIndex = 1;
            lblID.Text = "ID :";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 11F);
            lblPhone.Location = new Point(44, 255);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(91, 30);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Phone : ";
            // 
            // lblCollege
            // 
            lblCollege.AutoSize = true;
            lblCollege.Font = new Font("Segoe UI", 11F);
            lblCollege.Location = new Point(44, 353);
            lblCollege.Name = "lblCollege";
            lblCollege.Size = new Size(98, 30);
            lblCollege.TabIndex = 3;
            lblCollege.Text = "College :";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Beige;
            button1.Location = new Point(660, 153);
            button1.Name = "button1";
            button1.Size = new Size(120, 39);
            button1.TabIndex = 4;
            button1.Text = "Edit PFP";
            button1.UseVisualStyleBackColor = false;
            // 
            // picProfile
            // 
            picProfile.BorderStyle = BorderStyle.FixedSingle;
            picProfile.Location = new Point(660, 12);
            picProfile.Name = "picProfile";
            picProfile.Size = new Size(120, 120);
            picProfile.SizeMode = PictureBoxSizeMode.Zoom;
            picProfile.TabIndex = 5;
            picProfile.TabStop = false;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(800, 450);
            Controls.Add(picProfile);
            Controls.Add(button1);
            Controls.Add(lblCollege);
            Controls.Add(lblPhone);
            Controls.Add(lblID);
            Controls.Add(lblName);
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProfileForm";
            Load += ProfileForm_Load;
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblID;
        private Label lblPhone;
        private Label lblCollege;
        private Button button1;
        private PictureBox picProfile;
    }
}
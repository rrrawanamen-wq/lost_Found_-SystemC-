namespace WinFormsApp6
{
    partial class MainForm
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
            btnProfile = new Button();
            lblHi = new Label();
            btnGoToChoice = new Button();
            SuspendLayout();
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.Tan;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Angkor", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProfile.ForeColor = Color.Maroon;
            btnProfile.Location = new Point(201, 126);
            btnProfile.Margin = new Padding(2);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(245, 130);
            btnProfile.TabIndex = 0;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // lblHi
            // 
            lblHi.AutoSize = true;
            lblHi.Font = new Font("Angkor", 20F);
            lblHi.Location = new Point(104, 33);
            lblHi.Name = "lblHi";
            lblHi.Size = new Size(220, 61);
            lblHi.TabIndex = 1;
            lblHi.Text = "Welcome,";
            lblHi.Click += label1_Click;
            // 
            // btnGoToChoice
            // 
            btnGoToChoice.BackColor = Color.Maroon;
            btnGoToChoice.FlatStyle = FlatStyle.Popup;
            btnGoToChoice.ForeColor = Color.White;
            btnGoToChoice.Location = new Point(522, 309);
            btnGoToChoice.Name = "btnGoToChoice";
            btnGoToChoice.Size = new Size(94, 29);
            btnGoToChoice.TabIndex = 2;
            btnGoToChoice.Text = "Next";
            btnGoToChoice.UseVisualStyleBackColor = false;
            btnGoToChoice.Click += btnGoToChoice_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(640, 360);
            Controls.Add(btnGoToChoice);
            Controls.Add(lblHi);
            Controls.Add(btnProfile);
            Margin = new Padding(2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProfile;
        private Label lblHi;
        private Button btnGoToChoice;
    }
}
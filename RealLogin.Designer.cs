namespace WinFormsApp6
{
    partial class RealLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealLogin));
            lblWelcome = new Label();
            lblNMU = new Label();
            lblName = new Label();
            lblID = new Label();
            txtName = new TextBox();
            txtID = new TextBox();
            btnNext = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Angkor", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.Black;
            lblWelcome.Location = new Point(84, 37);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(354, 55);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Lost Items System";
            // 
            // lblNMU
            // 
            lblNMU.AutoSize = true;
            lblNMU.BackColor = Color.Transparent;
            lblNMU.Font = new Font("Angkor", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNMU.ForeColor = Color.Black;
            lblNMU.Location = new Point(189, 83);
            lblNMU.Name = "lblNMU";
            lblNMU.Size = new Size(110, 54);
            lblNMU.TabIndex = 1;
            lblNMU.Text = "NMU";
            lblNMU.Click += label1_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Angkor", 12F);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(52, 227);
            lblName.Name = "lblName";
            lblName.Size = new Size(81, 35);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BackColor = Color.Transparent;
            lblID.Font = new Font("Angkor", 12F);
            lblID.ForeColor = Color.Black;
            lblID.Location = new Point(52, 288);
            lblID.Name = "lblID";
            lblID.Size = new Size(43, 35);
            lblID.TabIndex = 3;
            lblID.Text = "ID";
            // 
            // txtName
            // 
            txtName.BackColor = Color.Tan;
            txtName.Font = new Font("Angkor", 11F);
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(139, 227);
            txtName.Name = "txtName";
            txtName.Size = new Size(339, 41);
            txtName.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.BackColor = Color.Tan;
            txtID.Font = new Font("Angkor", 11F);
            txtID.ForeColor = Color.Black;
            txtID.Location = new Point(139, 283);
            txtID.Name = "txtID";
            txtID.Size = new Size(339, 41);
            txtID.TabIndex = 5;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Maroon;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Angkor", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(207, 434);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(107, 39);
            btnNext.TabIndex = 6;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // RealLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(518, 513);
            Controls.Add(btnNext);
            Controls.Add(txtID);
            Controls.Add(txtName);
            Controls.Add(lblID);
            Controls.Add(lblName);
            Controls.Add(lblNMU);
            Controls.Add(lblWelcome);
            Name = "RealLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RealLogin";
            Load += RealLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label lblNMU;
        private Label lblName;
        private Label lblID;
        private TextBox txtName;
        private TextBox txtID;
        private Button btnNext;
    }
}
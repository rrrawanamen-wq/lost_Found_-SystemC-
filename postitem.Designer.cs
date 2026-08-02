namespace WinFormsApp6
{
    partial class postitem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            lblCategory = new Label();
            lblDescription = new Label();
            lblPhoneNum = new Label();
            lblLocation = new Label();
            lblDate = new Label();
            btnDeletePost = new Button();
            btnEditPost = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 166);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Transparent;
            lblCategory.Font = new Font("Angkor", 10.2F);
            lblCategory.ForeColor = Color.Maroon;
            lblCategory.Location = new Point(3, 195);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(102, 30);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Category";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Angkor", 10.2F);
            lblDescription.ForeColor = Color.Maroon;
            lblDescription.Location = new Point(3, 239);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(127, 30);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description";
            lblDescription.Click += label2_Click;
            // 
            // lblPhoneNum
            // 
            lblPhoneNum.AutoSize = true;
            lblPhoneNum.BackColor = Color.Transparent;
            lblPhoneNum.Font = new Font("Angkor", 10.2F);
            lblPhoneNum.ForeColor = Color.Maroon;
            lblPhoneNum.Location = new Point(3, 283);
            lblPhoneNum.Name = "lblPhoneNum";
            lblPhoneNum.Size = new Size(158, 30);
            lblPhoneNum.TabIndex = 3;
            lblPhoneNum.Text = "Phone Number";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.BackColor = Color.Transparent;
            lblLocation.Font = new Font("Angkor", 10.2F);
            lblLocation.ForeColor = Color.Maroon;
            lblLocation.Location = new Point(3, 328);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(97, 30);
            lblLocation.TabIndex = 4;
            lblLocation.Text = "Location";
            lblLocation.Click += label4_Click;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Angkor", 10.2F);
            lblDate.ForeColor = Color.Maroon;
            lblDate.Location = new Point(3, 370);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(59, 30);
            lblDate.TabIndex = 5;
            lblDate.Text = "Date";
            // 
            // btnDeletePost
            // 
            btnDeletePost.BackColor = Color.White;
            btnDeletePost.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnDeletePost.FlatStyle = FlatStyle.Flat;
            btnDeletePost.Font = new Font("TikTok Sans Display", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletePost.ForeColor = Color.Black;
            btnDeletePost.Location = new Point(204, 0);
            btnDeletePost.Name = "btnDeletePost";
            btnDeletePost.Size = new Size(25, 26);
            btnDeletePost.TabIndex = 6;
            btnDeletePost.Text = "X";
            btnDeletePost.TextAlign = ContentAlignment.TopCenter;
            btnDeletePost.UseVisualStyleBackColor = false;
            btnDeletePost.Click += button1_Click;
            // 
            // btnEditPost
            // 
            btnEditPost.BackColor = Color.White;
            btnEditPost.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btnEditPost.FlatStyle = FlatStyle.Flat;
            btnEditPost.Font = new Font("TikTok Sans Text Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditPost.Location = new Point(0, 0);
            btnEditPost.Name = "btnEditPost";
            btnEditPost.Size = new Size(50, 26);
            btnEditPost.TabIndex = 7;
            btnEditPost.Text = "Edit";
            btnEditPost.UseVisualStyleBackColor = false;
            btnEditPost.Click += btnEditPost_Click;
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            toolTip1.Popup += toolTip1_Popup;
            // 
            // postitem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            Controls.Add(btnEditPost);
            Controls.Add(btnDeletePost);
            Controls.Add(lblDate);
            Controls.Add(lblLocation);
            Controls.Add(lblPhoneNum);
            Controls.Add(lblDescription);
            Controls.Add(lblCategory);
            Controls.Add(pictureBox1);
            Margin = new Padding(5);
            Name = "postitem";
            Size = new Size(229, 403);
            Load += postitem_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblCategory;
        private Label lblDescription;
        private Label lblPhoneNum;
        private Label lblLocation;
        private Label lblDate;
        private Button btnDeletePost;
        private Button btnEditPost;
        private ToolTip toolTip1;
    }
}

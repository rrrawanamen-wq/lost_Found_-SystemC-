namespace WinFormsApp6
{
    partial class Additemcom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Additemcom));
            lblCategory = new Label();
            lblDescription = new Label();
            lblPhoneNum = new Label();
            lblLocation = new Label();
            lblDate = new Label();
            lblAddItem = new Label();
            pictureBox1 = new PictureBox();
            cmbCategory = new ComboBox();
            txtDescription = new TextBox();
            txtPhoneNum = new TextBox();
            txtLocation = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnAddPhoto = new Button();
            btnPost = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Transparent;
            lblCategory.Font = new Font("Angkor", 12F);
            lblCategory.ForeColor = Color.Maroon;
            lblCategory.Location = new Point(34, 104);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(118, 35);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Category";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Angkor", 12F);
            lblDescription.ForeColor = Color.Maroon;
            lblDescription.Location = new Point(34, 159);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(149, 35);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Description";
            // 
            // lblPhoneNum
            // 
            lblPhoneNum.AutoSize = true;
            lblPhoneNum.BackColor = Color.Transparent;
            lblPhoneNum.Font = new Font("Angkor", 12F);
            lblPhoneNum.ForeColor = Color.Maroon;
            lblPhoneNum.Location = new Point(34, 210);
            lblPhoneNum.Name = "lblPhoneNum";
            lblPhoneNum.Size = new Size(183, 35);
            lblPhoneNum.TabIndex = 2;
            lblPhoneNum.Text = "Phone Number";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.BackColor = Color.Transparent;
            lblLocation.Font = new Font("Angkor", 12F);
            lblLocation.ForeColor = Color.Maroon;
            lblLocation.Location = new Point(34, 263);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(114, 35);
            lblLocation.TabIndex = 3;
            lblLocation.Text = "Location";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Angkor", 12F);
            lblDate.ForeColor = Color.Maroon;
            lblDate.Location = new Point(34, 313);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(68, 35);
            lblDate.TabIndex = 4;
            lblDate.Text = "Date";
            // 
            // lblAddItem
            // 
            lblAddItem.AutoSize = true;
            lblAddItem.Font = new Font("Angkor", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddItem.Location = new Point(143, 27);
            lblAddItem.Name = "lblAddItem";
            lblAddItem.Size = new Size(153, 45);
            lblAddItem.TabIndex = 5;
            lblAddItem.Text = "Add Item";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(75, 376);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 101);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.Tan;
            cmbCategory.Font = new Font("Angkor", 10.2F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Elctrions ", "Tools", "Something else" });
            cmbCategory.Location = new Point(220, 101);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(200, 38);
            cmbCategory.TabIndex = 7;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.Tan;
            txtDescription.Font = new Font("Angkor", 10.2F);
            txtDescription.Location = new Point(220, 156);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(200, 38);
            txtDescription.TabIndex = 8;
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.BackColor = Color.Tan;
            txtPhoneNum.Font = new Font("Angkor", 10.2F);
            txtPhoneNum.Location = new Point(220, 212);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(200, 38);
            txtPhoneNum.TabIndex = 9;
            // 
            // txtLocation
            // 
            txtLocation.BackColor = Color.Tan;
            txtLocation.Font = new Font("Angkor", 10.2F);
            txtLocation.Location = new Point(220, 260);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(200, 38);
            txtLocation.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Angkor", 10.2F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(220, 310);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 38);
            dateTimePicker1.TabIndex = 11;
            // 
            // btnAddPhoto
            // 
            btnAddPhoto.BackColor = Color.Tan;
            btnAddPhoto.FlatAppearance.BorderSize = 0;
            btnAddPhoto.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnAddPhoto.FlatStyle = FlatStyle.Flat;
            btnAddPhoto.Font = new Font("Angkor", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddPhoto.ForeColor = Color.Maroon;
            btnAddPhoto.Location = new Point(249, 409);
            btnAddPhoto.Name = "btnAddPhoto";
            btnAddPhoto.Size = new Size(130, 40);
            btnAddPhoto.TabIndex = 12;
            btnAddPhoto.Text = "Add Photo";
            btnAddPhoto.UseVisualStyleBackColor = false;
            btnAddPhoto.Click += btnAddPhoto_Click;
            // 
            // btnPost
            // 
            btnPost.BackColor = Color.Maroon;
            btnPost.DialogResult = DialogResult.OK;
            btnPost.FlatStyle = FlatStyle.Flat;
            btnPost.Font = new Font("Angkor", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPost.ForeColor = Color.White;
            btnPost.Location = new Point(166, 523);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(130, 45);
            btnPost.TabIndex = 13;
            btnPost.Text = "Post";
            btnPost.UseVisualStyleBackColor = false;
            btnPost.Click += btnPost_Click;
            // 
            // Additemcom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(194, 162, 139);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(449, 596);
            Controls.Add(btnPost);
            Controls.Add(btnAddPhoto);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtLocation);
            Controls.Add(txtPhoneNum);
            Controls.Add(txtDescription);
            Controls.Add(cmbCategory);
            Controls.Add(pictureBox1);
            Controls.Add(lblAddItem);
            Controls.Add(lblDate);
            Controls.Add(lblLocation);
            Controls.Add(lblPhoneNum);
            Controls.Add(lblDescription);
            Controls.Add(lblCategory);
            Name = "Additemcom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Additemcom";
            Load += Additemcom_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategory;
        private Label lblDescription;
        private Label lblPhoneNum;
        private Label lblLocation;
        private Label lblDate;
        private Label lblAddItem;
        private PictureBox pictureBox1;
        private ComboBox cmbCategory;
        private TextBox txtDescription;
        private TextBox txtPhoneNum;
        private TextBox txtLocation;
        private DateTimePicker dateTimePicker1;
        private Button btnAddPhoto;
        private Button btnPost;
    }
}
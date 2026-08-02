namespace WinFormsApp6
{
    partial class ObjectsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjectsForm));
            lblCommunity = new Label();
            flpPosts = new FlowLayoutPanel();
            lblNoPosts = new Label();
            btnAdd = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtSearch = new TextBox();
            button1 = new Button();
            flpPosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblCommunity
            // 
            lblCommunity.AutoSize = true;
            lblCommunity.BackColor = Color.Transparent;
            lblCommunity.Font = new Font("Angkor", 20F);
            lblCommunity.ForeColor = Color.White;
            lblCommunity.Location = new Point(337, 87);
            lblCommunity.Name = "lblCommunity";
            lblCommunity.Size = new Size(261, 61);
            lblCommunity.TabIndex = 0;
            lblCommunity.Text = "Community";
            lblCommunity.Click += lblCommunity_Click;
            // 
            // flpPosts
            // 
            flpPosts.AutoScroll = true;
            flpPosts.BackColor = Color.Transparent;
            flpPosts.Controls.Add(lblNoPosts);
            flpPosts.Location = new Point(72, 278);
            flpPosts.Margin = new Padding(200, 11, 11, 11);
            flpPosts.Name = "flpPosts";
            flpPosts.Size = new Size(801, 256);
            flpPosts.TabIndex = 1;
            flpPosts.Paint += flpPosts_Paint;
            // 
            // lblNoPosts
            // 
            lblNoPosts.AutoSize = true;
            lblNoPosts.Dock = DockStyle.Fill;
            lblNoPosts.Font = new Font("Angkor", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoPosts.ForeColor = Color.FromArgb(128, 64, 64);
            lblNoPosts.Location = new Point(260, 99);
            lblNoPosts.Margin = new Padding(260, 99, 100, 0);
            lblNoPosts.Name = "lblNoPosts";
            lblNoPosts.Size = new Size(266, 61);
            lblNoPosts.TabIndex = 2;
            lblNoPosts.Text = "No posts yet";
            lblNoPosts.TextAlign = ContentAlignment.MiddleLeft;
            lblNoPosts.Click += lblNoPosts_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(113, 100, 82);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Angkor", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Maroon;
            btnAdd.Location = new Point(72, 212);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(302, 44);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add the lost item";
            btnAdd.TextAlign = ContentAlignment.TopLeft;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(380, 212);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 43);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(504, 211);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 44);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.Tan;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Angkor", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.FromArgb(128, 64, 64);
            txtSearch.Location = new Point(556, 215);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(286, 40);
            txtSearch.TabIndex = 0;
            txtSearch.TabStop = false;
            txtSearch.Text = "Search ....";
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Angkor", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(55, 53);
            button1.Name = "button1";
            button1.Size = new Size(94, 45);
            button1.TabIndex = 3;
            button1.Text = "<---";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ObjectsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(194, 162, 139);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(962, 577);
            Controls.Add(txtSearch);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnAdd);
            Controls.Add(flpPosts);
            Controls.Add(lblCommunity);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ObjectsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ObjectsForm";
            Load += ObjectsForm_Load;
            flpPosts.ResumeLayout(false);
            flpPosts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCommunity;
        private FlowLayoutPanel flpPosts;
        private Button btnAdd;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtSearch;
        private Label lblNoPosts;
        private Button button1;
    }
}
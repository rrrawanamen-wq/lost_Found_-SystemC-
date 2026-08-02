namespace WinFormsApp6
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            splitContainer1 = new SplitContainer();
            label5 = new Label();
            listBox1 = new ListBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            btnSearch = new Button();
            btnAddPost = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(listBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackgroundImage = (Image)resources.GetObject("splitContainer1.Panel2.BackgroundImage");
            splitContainer1.Panel2.Controls.Add(textBox3);
            splitContainer1.Panel2.Controls.Add(textBox2);
            splitContainer1.Panel2.Controls.Add(textBox1);
            splitContainer1.Panel2.Controls.Add(dateTimePicker1);
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.Controls.Add(btnSearch);
            splitContainer1.Panel2.Controls.Add(btnAddPost);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(824, 514);
            splitContainer1.SplitterDistance = 351;
            splitContainer1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Tan;
            label5.Font = new Font("Angkor", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(36, 42);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(275, 57);
            label5.TabIndex = 1;
            label5.Text = "Current Posts";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Tan;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(0, 2);
            listBox1.Margin = new Padding(2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(356, 504);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Tan;
            textBox3.Location = new Point(234, 261);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(174, 31);
            textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Tan;
            textBox2.Location = new Point(234, 191);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 31);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Tan;
            textBox1.Location = new Point(234, 121);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 31);
            textBox1.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.Tan;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(234, 58);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(174, 31);
            dateTimePicker1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(65, 312);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Maroon;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Angkor", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(275, 405);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(165, 58);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAddPost
            // 
            btnAddPost.BackColor = Color.Maroon;
            btnAddPost.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnAddPost.FlatStyle = FlatStyle.Flat;
            btnAddPost.Font = new Font("Angkor", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddPost.ForeColor = Color.White;
            btnAddPost.Location = new Point(52, 405);
            btnAddPost.Margin = new Padding(2);
            btnAddPost.Name = "btnAddPost";
            btnAddPost.Size = new Size(165, 58);
            btnAddPost.TabIndex = 4;
            btnAddPost.Text = "Add Post";
            btnAddPost.UseVisualStyleBackColor = false;
            btnAddPost.Click += btnAddPost_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Angkor", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Maroon;
            label4.Image = Properties.Resources.باك_جراوند1;
            label4.Location = new Point(72, 250);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(124, 49);
            label4.TabIndex = 3;
            label4.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Angkor", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Maroon;
            label3.Image = Properties.Resources.باك_جراوند1;
            label3.Location = new Point(72, 180);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(137, 49);
            label3.TabIndex = 2;
            label3.Text = "Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Angkor", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Maroon;
            label2.Image = Properties.Resources.باك_جراوند1;
            label2.Location = new Point(65, 110);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(163, 49);
            label2.TabIndex = 1;
            label2.Text = "Location";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Angkor", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Image = Properties.Resources.باك_جراوند1;
            label1.Location = new Point(72, 48);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 49);
            label1.TabIndex = 0;
            label1.Text = "Date";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 514);
            Controls.Add(splitContainer1);
            Margin = new Padding(2);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private Button btnSearch;
        private Button btnAddPost;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
    }
}
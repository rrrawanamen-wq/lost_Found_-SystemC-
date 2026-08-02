namespace WinFormsApp6
{
    partial class Items_or_Money
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Items_or_Money));
            btnItem = new Button();
            btnMoney = new Button();
            groupbox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Next = new Button();
            groupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnItem
            // 
            btnItem.BackColor = Color.Tan;
            btnItem.FlatAppearance.BorderSize = 0;
            btnItem.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btnItem.FlatStyle = FlatStyle.Flat;
            btnItem.Font = new Font("Angkor", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnItem.ForeColor = Color.Black;
            btnItem.Location = new Point(77, 212);
            btnItem.Name = "btnItem";
            btnItem.Size = new Size(137, 47);
            btnItem.TabIndex = 0;
            btnItem.Text = "Items";
            btnItem.UseVisualStyleBackColor = false;
            btnItem.Click += button1_Click;
            // 
            // btnMoney
            // 
            btnMoney.BackColor = Color.Tan;
            btnMoney.FlatAppearance.BorderSize = 0;
            btnMoney.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            btnMoney.FlatStyle = FlatStyle.Flat;
            btnMoney.Font = new Font("Angkor", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMoney.ForeColor = Color.Black;
            btnMoney.Location = new Point(480, 212);
            btnMoney.Name = "btnMoney";
            btnMoney.Size = new Size(137, 47);
            btnMoney.TabIndex = 1;
            btnMoney.Text = "Money";
            btnMoney.UseVisualStyleBackColor = false;
            btnMoney.Click += btnMoney_Click;
            // 
            // groupbox1
            // 
            groupbox1.BackColor = Color.OldLace;
            groupbox1.Controls.Add(btnItem);
            groupbox1.Controls.Add(pictureBox1);
            groupbox1.Controls.Add(pictureBox2);
            groupbox1.Controls.Add(Next);
            groupbox1.Controls.Add(btnMoney);
            groupbox1.Dock = DockStyle.Fill;
            groupbox1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupbox1.ForeColor = Color.FromArgb(142, 27, 33);
            groupbox1.Location = new Point(0, 0);
            groupbox1.Margin = new Padding(2);
            groupbox1.Name = "groupbox1";
            groupbox1.Padding = new Padding(2);
            groupbox1.Size = new Size(682, 403);
            groupbox1.TabIndex = 2;
            groupbox1.TabStop = false;
            groupbox1.Text = "Lost && Found Items";
            groupbox1.Enter += groupBox1_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2026_05_01_at_3_17_55_PM;
            pictureBox1.Location = new Point(45, 80);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.WhatsApp_Image_2026_05_01_at_3_171;
            pictureBox2.Location = new Point(441, 80);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(204, 118);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Next
            // 
            Next.BackColor = Color.FromArgb(142, 27, 33);
            Next.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            Next.FlatStyle = FlatStyle.Flat;
            Next.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Next.ForeColor = Color.White;
            Next.Location = new Point(274, 338);
            Next.Margin = new Padding(2);
            Next.Name = "Next";
            Next.Size = new Size(132, 54);
            Next.TabIndex = 3;
            Next.Text = "Next";
            Next.UseVisualStyleBackColor = false;
            // 
            // Items_or_Money
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(194, 162, 139);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(682, 403);
            Controls.Add(groupbox1);
            ForeColor = Color.Beige;
            Name = "Items_or_Money";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Items_or_Money";
            Load += Items_or_Money_Load;
            groupbox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnItem;
        private Button btnMoney;
        private GroupBox groupbox1;
        private Button Next;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
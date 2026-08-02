namespace WinFormsApp6
{
    partial class Loading
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            label1 = new Label();
            pbBag = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pbRuler = new PictureBox();
            pbWallet = new PictureBox();
            pbMob = new PictureBox();
            pbBottle = new PictureBox();
            pbPen = new PictureBox();
            pbBook = new PictureBox();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pbBag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRuler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbWallet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMob).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBottle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBook).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Angkor", 12F, FontStyle.Italic);
            label1.Location = new Point(189, 298);
            label1.Name = "label1";
            label1.Size = new Size(146, 35);
            label1.TabIndex = 0;
            label1.Text = "Loading......";
            label1.Click += label1_Click;
            // 
            // pbBag
            // 
            pbBag.BackColor = Color.Transparent;
            pbBag.Image = (Image)resources.GetObject("pbBag.Image");
            pbBag.Location = new Point(199, 168);
            pbBag.Name = "pbBag";
            pbBag.Size = new Size(121, 127);
            pbBag.SizeMode = PictureBoxSizeMode.Zoom;
            pbBag.TabIndex = 1;
            pbBag.TabStop = false;
            pbBag.Click += pictureBox1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // pbRuler
            // 
            pbRuler.BackColor = Color.Transparent;
            pbRuler.Image = (Image)resources.GetObject("pbRuler.Image");
            pbRuler.Location = new Point(99, 210);
            pbRuler.Name = "pbRuler";
            pbRuler.Size = new Size(54, 39);
            pbRuler.SizeMode = PictureBoxSizeMode.Zoom;
            pbRuler.TabIndex = 2;
            pbRuler.TabStop = false;
            // 
            // pbWallet
            // 
            pbWallet.Image = (Image)resources.GetObject("pbWallet.Image");
            pbWallet.Location = new Point(291, 75);
            pbWallet.Name = "pbWallet";
            pbWallet.Size = new Size(44, 37);
            pbWallet.SizeMode = PictureBoxSizeMode.Zoom;
            pbWallet.TabIndex = 3;
            pbWallet.TabStop = false;
            // 
            // pbMob
            // 
            pbMob.BackColor = Color.Transparent;
            pbMob.Image = (Image)resources.GetObject("pbMob.Image");
            pbMob.Location = new Point(214, 57);
            pbMob.Name = "pbMob";
            pbMob.Size = new Size(41, 55);
            pbMob.SizeMode = PictureBoxSizeMode.Zoom;
            pbMob.TabIndex = 4;
            pbMob.TabStop = false;
            pbMob.Click += pictureBox4_Click;
            // 
            // pbBottle
            // 
            pbBottle.BackColor = Color.Transparent;
            pbBottle.Image = (Image)resources.GetObject("pbBottle.Image");
            pbBottle.Location = new Point(338, 119);
            pbBottle.Name = "pbBottle";
            pbBottle.Size = new Size(45, 59);
            pbBottle.SizeMode = PictureBoxSizeMode.Zoom;
            pbBottle.TabIndex = 5;
            pbBottle.TabStop = false;
            // 
            // pbPen
            // 
            pbPen.BackColor = Color.Transparent;
            pbPen.Image = (Image)resources.GetObject("pbPen.Image");
            pbPen.Location = new Point(355, 201);
            pbPen.Name = "pbPen";
            pbPen.Size = new Size(41, 48);
            pbPen.SizeMode = PictureBoxSizeMode.Zoom;
            pbPen.TabIndex = 6;
            pbPen.TabStop = false;
            // 
            // pbBook
            // 
            pbBook.BackColor = Color.Transparent;
            pbBook.Image = (Image)resources.GetObject("pbBook.Image");
            pbBook.Location = new Point(135, 119);
            pbBook.Name = "pbBook";
            pbBook.Size = new Size(42, 44);
            pbBook.SizeMode = PictureBoxSizeMode.Zoom;
            pbBook.TabIndex = 7;
            pbBook.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(199, 336);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(125, 29);
            progressBar1.TabIndex = 8;
            // 
            // Loading
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(507, 513);
            Controls.Add(pbBag);
            Controls.Add(progressBar1);
            Controls.Add(pbBook);
            Controls.Add(pbPen);
            Controls.Add(pbBottle);
            Controls.Add(pbMob);
            Controls.Add(pbWallet);
            Controls.Add(pbRuler);
            Controls.Add(label1);
            Name = "Loading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loading";
            Load += Loading_Load;
            ((System.ComponentModel.ISupportInitialize)pbBag).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRuler).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbWallet).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMob).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBottle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pbBag;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pbRuler;
        private PictureBox pbWallet;
        private PictureBox pbMob;
        private PictureBox pbBottle;
        private PictureBox pbPen;
        private PictureBox pbBook;
        private ProgressBar progressBar1;
    }
}
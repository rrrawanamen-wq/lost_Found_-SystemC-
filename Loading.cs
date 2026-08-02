namespace WinFormsApp6
{
    public partial class Loading : Form
    {
        int progressValue = 0;

        public Loading()
        {
            InitializeComponent();
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Loading_Load(object sender, EventArgs e)
        {

            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)

        {
            if (progressValue < 100)
            {
                progressValue += 1;
                progressBar1.Value = progressValue;
                label1.Text = "Loading" + new string('.', (progressValue % 4));
            }
            else
            {
                timer1.Stop();
                sign_or_log f2 = new sign_or_log();
                f2.Show();
                this.Hide();
            }
 
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}

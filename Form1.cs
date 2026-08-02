namespace WinFormsApp6
{
    public partial class LoginForm : Form
    {
        string userRole;
        public LoginForm(string role)
        {
            InitializeComponent();
            userRole = role;   
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your name");
                txtName.Focus();
                return;
            }

            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your ID");
                txtID.Focus();
                return;
            }

            if (txtPhone.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your phone number");
                txtPhone.Focus();
                return;
            }

            if (cmpCollege.Text.Trim() == "")
            {
                MessageBox.Show("Please select your college");
                cmpCollege.Focus();
                return;
            }

            MainForm main = new MainForm(txtName.Text);
            main.Show();
            this.Hide();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

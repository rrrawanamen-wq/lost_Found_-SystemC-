using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class sign_or_log : Form
    {
        public sign_or_log()
        {
            InitializeComponent();
        }

        private void sign_or_log_Load(object sender, EventArgs e)
        {

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            LoginForm f5 = new LoginForm("Admin");
            f5.Show();
            this.Hide();
        }

        private void lblNoAccount_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            RealLogin fo = new RealLogin();
            fo.Show();
            this.Hide();
        }
    }
}

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
    public partial class MainForm : Form
    {
        private string userName;
        public MainForm(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            lblHi.Text = "Welcome, " + userName;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileForm p = new ProfileForm();
            p.Show();
        }
        private void btnObjectsCommunity_Click(object sender, EventArgs e)
        {
            ObjectsForm o = new ObjectsForm();
            o.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGoToChoice_Click(object sender, EventArgs e)
        {
            Items_or_Money nextForm = new Items_or_Money(); 
            nextForm.Show();
            this.Hide();
        }
    }
}

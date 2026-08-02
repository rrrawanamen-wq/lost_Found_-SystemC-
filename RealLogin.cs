using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp6
{
    public partial class RealLogin : Form
    {
        public RealLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Please enter both Name and ID.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Items_or_Money f10 = new Items_or_Money();
                f10.Show();
                this.Hide();
            }

        }

        private void RealLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

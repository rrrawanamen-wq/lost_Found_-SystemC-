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
    public partial class MoneyForm : Form
    {
        public static List<string> allPosts = new List<string>();
        public MoneyForm()
        {
            
        InitializeComponent();
        }

        private void lstMoney_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MoneyForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 foundForm = new Form2();
            foundForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
        }
    }
}

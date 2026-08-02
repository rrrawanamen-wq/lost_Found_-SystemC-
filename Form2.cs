using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp6
{
    public partial class Form2 : Form
    {
        List<MoneyItem> moneyItems = new List<MoneyItem>();

        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }



        private void btnAddPost_Click(object sender, EventArgs e)
        {
            MoneyItem item = new MoneyItem();
            item.location = textBox1.Text;
            item.details = textBox2.Text;
            item.phone = textBox3.Text;
            item.date = dateTimePicker1.Value;

            moneyItems.Add(item);
            listBox1.Items.Add(item);

            MessageBox.Show("Success");
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string searchVal = textBox1.Text;

            foreach (var m in moneyItems)
            {
                if (m.location == searchVal)
                {
                    listBox1.Items.Add(m);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is MoneyItem selected)
            {
                label1.Text = selected.date.ToShortDateString();
                label2.Text = selected.location;
                label3.Text = selected.details;
                label4.Text = selected.phone;

                pictureBox1.ImageLocation = "money_icon.png";
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
    




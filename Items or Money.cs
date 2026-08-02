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
    public partial class Items_or_Money : Form
    {
        public Items_or_Money()
        {
            InitializeComponent();
        }

        private void Items_or_Money_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FinalDecision decision = new FinalDecision();
                decision.UserChoice = "Items";
                System.IO.File.AppendAllText("log.txt", $"{decision.SelectionTime}: User selected Items\n");
                ObjectsForm objForm = new ObjectsForm();
                objForm.Show();
                this.Hide();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FinalDecision decision = new FinalDecision();
                decision.UserChoice = "Money";

                System.IO.File.AppendAllText("log.txt", $"{decision.SelectionTime}: User selected Money\n");
                MoneyForm monForm = new MoneyForm();
                monForm.Show();
                this.Hide();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            MoneyForm fo = new MoneyForm();
            fo.Show();
            this.Hide();
        }
    }
    public class BaseSelection
    {
        public string UserChoice { get; set; }
        public DateTime SelectionTime { get; set; }
        public BaseSelection() { SelectionTime = DateTime.Now; }
    }

    public class FinalDecision : BaseSelection
    {
        public string StatusMessage { get; set; }
    }
} 

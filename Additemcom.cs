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
    public partial class Additemcom : Form
    {
        string selectedImage = "";
        public Additemcom()
        {
            InitializeComponent();
        }


        private void Additemcom_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = Enum.GetValues(typeof(ItemCategory));
            cmbCategory.DataSource = Enum.GetValues(typeof(ItemCategory));
            cmbCategory.SelectedIndex = 0;

        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            ItemCategory selectedCat = (ItemCategory)cmbCategory.SelectedItem;
            LostItem newItem = new LostItem(
                selectedCat,
                txtDescription.Text,
                txtPhoneNum.Text,
                txtLocation.Text,
                dateTimePicker1.Value,
                selectedImage
            );

            ObjectsForm.allPosts.Add(newItem);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
            LostItem itemToEdit;
        public void SetEditData(LostItem item)
        {
            itemToEdit = item;
            txtDescription.Text = item.Description;
            txtPhoneNum.Text = item.Phone;
            txtLocation.Text = item.Location;
            btnPost.Text = "Update"; 
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Images|*.jpg;*.png;*.jpeg";
            if (op.ShowDialog() == DialogResult.OK)
            {
                selectedImage = op.FileName; 
                pictureBox1.Image = Image.FromFile(op.FileName); 
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class postitem : UserControl
    {
        public LostItem currentItem;
        public postitem()
        {
            InitializeComponent();
        }
        public void SetData(LostItem item)
        {
            this.currentItem = item;
            lblCategory.Text = item.Category.ToString();
            lblDescription.Text = item.Description;
            lblPhoneNum.Text = item.Phone;
            lblLocation.Text = item.Location;
            lblDate.Text = item.DateFound.ToShortDateString();

            if (!string.IsNullOrEmpty(item.ImagePath) && System.IO.File.Exists(item.ImagePath))
            {
                using (var stream = new System.IO.FileStream(item.ImagePath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                {
                    pictureBox1.Image = Image.FromStream(stream);
                }
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }

            toolTip1.SetToolTip(lblDescription, item.Description);
            toolTip1.SetToolTip(lblCategory, item.Category.ToString());
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void postitem_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to delete this post?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                ObjectsForm.allPosts.Remove(this.currentItem);

                ObjectsForm main = (ObjectsForm)Application.OpenForms["ObjectsForm"];

                if (main != null)
                {
                    main.SaveToFile();    
                    main.DisplayPosts();  
                }
            }
        }

        private void btnEditPost_Click(object sender, EventArgs e)
        {
            Additemcom editFrm = new Additemcom();
            if (this.currentItem != null)
            {
                editFrm.SetEditData(this.currentItem);
                editFrm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error: Item data is missing!");
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO; 
namespace WinFormsApp6
{
    public partial class ObjectsForm : Form
    {
        string filePath = Path.Combine(Application.StartupPath, "data.txt");
        public static List<LostItem> allPosts = new List<LostItem>();
        public ObjectsForm()
        {
            InitializeComponent();
        }
        public void DisplayPosts()
        {
            flpPosts.Controls.Clear();

            foreach (var item in allPosts.AsEnumerable().Reverse())
            {
                postitem pc = new postitem();
                pc.SetData(item);
                flpPosts.Controls.Add(pc);
            }

            lblNoPosts.Visible = (allPosts.Count == 0);
        }
        private void lstObjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCommunity_Click(object sender, EventArgs e)
        {

        }

        private void ObjectsForm_Load(object sender, EventArgs e)
        {
            LoadFromFile();
            DisplayPosts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Additemcom frm = new Additemcom();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                SaveToFile();
                DisplayPosts();
                this.Refresh();
                Application.DoEvents();
                MessageBox.Show("Post Added!");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            string searchText = txtSearch.Text.ToLower(); 
            flpPosts.Controls.Clear();
            foreach (var item in allPosts)
            {
                if (item.Description.ToLower().Contains(searchText) ||
                    item.Category.ToString().ToLower().Contains(searchText) ||
                    item.Location.ToLower().Contains(searchText))
                {
                    postitem pc = new postitem();
                    pc.SetData(item);
                    flpPosts.Controls.Add(pc);
                }
            }
        }
        public void LoadFromFile()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    allPosts.Clear();
                    string[] lines = File.ReadAllLines(filePath);

                    foreach (string line in lines)
                    {
                        try 
                        {
                            string[] parts = line.Split('|');
                            if (parts.Length == 6)
                            {
                                LostItem item = new LostItem(
                                    (ItemCategory)Enum.Parse(typeof(ItemCategory), parts[0]),
                                    parts[1], parts[2], parts[3],
                                    DateTime.Parse(parts[4]), parts[5]
                                );
                                allPosts.Add(item);
                            }
                        }
                        catch {}
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
        public void SaveToFile()
        {
            using (StreamWriter sw = new StreamWriter("data.txt"))
            {
                foreach (var item in allPosts)
                {
                    sw.WriteLine($"{item.Category}|{item.Description}|{item.Phone}|{item.Location}|{item.DateFound}|{item.ImagePath}");
                }
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search ....")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search ....";
                txtSearch.ForeColor = Color.Silver;
            }
        }

        private void lblNoPosts_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Items_or_Money main = new Items_or_Money(); 
            main.Show();
            this.Hide();
        }

        private void flpPosts_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

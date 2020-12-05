using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _3Darbas
{
    public partial class AddNewItemForm : Form
    {
        private ItemsRepository repo = new ItemsRepository();
        private SqlConnection conn;
        string imageLocation = null;
        
        public AddNewItemForm()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Server=.;Database=db_sc;Trusted_Connection=true;");
            List<Category> categoriesList = repo.GetCategories();
            foreach (Category category in categoriesList)
            categoryDropList.Items.Add(category.Id);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Item item = new Item(1, titleTextBox.Text, descriptionTextBox.Text, imageLocation, double.Parse(priceInputBox.Value.ToString()));
                string sql = "insert into Items (Title, Price, Description, CategoryID, Image) values (@title, @price, @description, @categoryId, @image)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@title", item.Title);
                cmd.Parameters.AddWithValue("@price", item.Price);
                cmd.Parameters.AddWithValue("@description", item.Description);
                cmd.Parameters.AddWithValue("@categoryId", int.Parse(categoryDropList.SelectedItem.ToString()));
                cmd.Parameters.AddWithValue("@image", item.Image);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Item: " + item.Title + " added!");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bit = new Bitmap(ofd.FileName);
                imageLocation = ofd.SafeFileName;
                itemPictureBox.BackgroundImage = null;
                itemPictureBox.Image = bit;
               
                itemPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }

            SaveFileDialog s = new SaveFileDialog();
            s.InitialDirectory = ("C:\\Users\\Admin\\source\\repos\\3Darbas\\3Darbas\\bin\\Debug\\pictures");
            s.RestoreDirectory = true;
            if (s.ShowDialog() == DialogResult.OK)
            {
                
                string filename = s.FileName;
                
                using (System.IO.FileStream fstream = new System.IO.FileStream(filename, System.IO.FileMode.Create))
                {
                    itemPictureBox.Image.Save(fstream, System.Drawing.Imaging.ImageFormat.Png);
                    fstream.Close();
                }
            }
        }
    }
}

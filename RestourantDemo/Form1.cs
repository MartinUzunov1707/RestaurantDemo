using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Data;

namespace RestourantDemo
{
    
    public partial class Form1 : Form
    {
        public RestaurantBusiness rb = new RestaurantBusiness();
        Image image;
        public Form1()
        {
            InitializeComponent();
        }

        public byte[] ConvertImageToByte(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public Image ConvertByteArrayToImage(byte[] data)
        {
            using(MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            ClearAllControls();
        }
        private void UpdateGrid()
        {
            dataGridView1.DataSource = rb.GetAll();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void ClearAllControls()
        {
            txtName.Text = "";
            txtPrice.Text = "";
            txtDescription.Text = "";
            chkIsGlutenFree.Checked = false;
            chkIsKosher.Checked = false;
            chkIsVegan.Checked = false;
            chkIsVegetarian.Checked = false;
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                decimal price = 0;
                decimal.TryParse(txtPrice.Text, out price);
                string description = txtDescription.Text;
                byte[] arr;
                if (image == null)
                {
                    throw new ArgumentException("Image field is not valid!");
                }
                else
                {
                    arr = ConvertImageToByte(image);
                }
                bool isVegetarian = chkIsVegetarian.Checked;
                bool isVegan = chkIsVegan.Checked;
                bool isGluten = chkIsGlutenFree.Checked;
                bool isKosher = chkIsKosher.Checked;
                Dish dish = new Dish();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files (*.png;*.jpg)|*.png;*.jpg", Multiselect = false })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    image = Image.FromFile(ofd.FileName);
                }
            } 

        }
    }
}

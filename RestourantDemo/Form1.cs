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
    //ВСЕКИ СИ ПРАВИ ХМЛ ДОКУМЕНТАЦИЯ ЗА СВОЙТЕ МЕТОДИ И КЛАСОВЕ, НУНИТА СЪЩО.
    //ДЕСИГН ГЕОРГ
    public partial class Form1 : Form
    {
        public RestaurantBusiness rb = new RestaurantBusiness();
        Image image;
        private int editId = 0;
        public Form1()
        {
            InitializeComponent();
        }
        //МАРТ
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
        //АЗ
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
            pictureBox1.Image = null;
            
        }
        //ГЕОРГ
        private Dish GetDish()
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
            Dish dish = new Dish(name, price, description, arr, isVegetarian, isVegan, isGluten, isKosher);
            image = null;
            return dish;
        }
        //МАРТ
        private Dish GetEditedDish()
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
            Dish dish = new Dish(name, price, description, arr, isVegetarian, isVegan, isGluten, isKosher);
            dish.ID = editId;
            image = null;
            return dish;
        }
        //ГЕОРГ
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {          
                rb.Add(GetDish());
                UpdateGrid();
                ClearAllControls();
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
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            } 

        }
        //МАРТ
        private void UpdateControls(int id)
        {
            Dish dish = rb.Get(id);
            txtName.Text = dish.DishName;
            txtPrice.Text = $"{dish.DishPrice:f2}";
            txtDescription.Text = dish.DishDescription;
            pictureBox1.Image = ConvertByteArrayToImage(dish.Image);
            image = ConvertByteArrayToImage(dish.Image);
            chkIsVegan.Checked = dish.IsVegan;
            chkIsVegetarian.Checked = dish.IsVegetarian;
            chkIsGlutenFree.Checked = dish.IsGlutenFree;
            chkIsKosher.Checked = dish.IsKosher;           
        }
        private void ToggleSaveUdpate()
        {
            if (btnUpdate.Visible)
            {
                btnUpdate.Visible = false;
                btnSaveChanges.Visible = true;
            }
            else
            {
                btnUpdate.Visible = true;
                btnSaveChanges.Visible = false;
            }
        }
        
        private void DisableSelect()
        {
            dataGridView1.Enabled = false;
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var item = dataGridView1.SelectedRows[0].Cells;
                int id = int.Parse(item[0].Value.ToString());
                editId = id;
                UpdateControls(id);
                ToggleSaveUdpate();
                DisableSelect();
            }
        }
        private void ResetSelect()
        {
            dataGridView1.ClearSelection();
            dataGridView1.Enabled = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            Dish editedDish = GetEditedDish();
            rb.Update(editedDish);
            UpdateGrid();
            ResetSelect();
            ToggleSaveUdpate();
            ClearAllControls();
        }
        //АЗ
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var item = dataGridView1.SelectedRows[0].Cells;
                int id = int.Parse(item[0].Value.ToString());
                rb.Delete(id);
                UpdateGrid();
                ResetSelect();
            }
        }
    }
}
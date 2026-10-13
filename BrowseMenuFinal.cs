using assignment;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Gr8FoodSystem_Final
{
    public partial class BrowseMenuFinal : Form
    {
        DatabaseHelper db = new DatabaseHelper();
        Cart Cart = new Cart();
        public BrowseMenuFinal()
        {
            InitializeComponent();
        }

        private void BrowseMenuFinal_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Clear();

            cmbCategory.Items.Add("All");
            cmbCategory.Items.Add("Breakfast");
            cmbCategory.Items.Add("Lunch");
            cmbCategory.Items.Add("Dinner");
            cmbCategory.Items.Add("Snacks");

            cmbCategory.SelectedIndex = 0;

            LoadMenu();
        }

        private void LoadMenu(string search = "", string category = "All")
        {
            flowLayoutPanel1.Controls.Clear();

            string query =
                @"SELECT * FROM menu_table
          WHERE MenuName LIKE @search
          AND IsAvailable = 1
          AND CAST(GETDATE() AS TIME)
          BETWEEN AvailableFrom AND AvailableUntil";

            if (category != "All")
            {
                query += " AND Category = @category";
            }

            SqlParameter[] parameters;

            if (category != "All")
            {
                parameters = new SqlParameter[]
                {
            new SqlParameter("@search", "%" + search + "%"),
            new SqlParameter("@category", category)
                };
            }
            else
            {
                parameters = new SqlParameter[]
                {
            new SqlParameter("@search", "%" + search + "%")
                };
            }

            DataTable dt = db.ExecuteQuery(query, parameters);

            foreach (DataRow row in dt.Rows)
            {
                string name = row["MenuName"].ToString();

                string menuCategory =
                    row["Category"].ToString();

                decimal price =
                    Convert.ToDecimal(row["Price"]);

                byte[] img =
                    (byte[])row["MenuPic"];

                flowLayoutPanel1.Controls.Add(
                    CreateFoodCard(
                        name,
                        menuCategory,
                        price,
                        img));
            }
        }

        
        private Panel CreateFoodCard(
            string name,
            string menuCategory,
            decimal price,
            byte[] imageData)
        {
            Panel card = new Panel();

            card.Size = new Size(230, 220);

            card.BackColor = Color.White;

            card.BorderStyle = BorderStyle.FixedSingle;

            card.Margin = new Padding(10);

            PictureBox pic = new PictureBox();

            if (imageData != null &&
                imageData.Length > 0)
            {
                try
                {
                    MemoryStream ms =
                        new MemoryStream(imageData);

                    pic.Image =
                        Image.FromStream(ms);
                }
                catch
                {
                    pic.BackColor =
                        Color.LightGray;
                }
            }
            else
            {
                pic.BackColor =
                    Color.LightGray;
            }

            pic.SizeMode =
                PictureBoxSizeMode.StretchImage;

            pic.Size = new Size(220, 90);

            pic.Location = new Point(5, 5);

            Label lblName = new Label();

            lblName.Text = name;

            lblName.Font =
                new Font("Segoe UI", 11,
                FontStyle.Bold);

            lblName.Location =
                new Point(10, 105);

            lblName.AutoSize = true;

            Label lblCategory = new Label();

            lblCategory.Text = menuCategory;

            lblCategory.ForeColor = Color.Gray;

            lblCategory.Location =
                new Point(10, 130);

            lblCategory.AutoSize = true;

            Label lblPrice = new Label();

            lblPrice.Text = "RM " + price;

            lblPrice.ForeColor = Color.Green;

            lblPrice.Font =
                new Font("Segoe UI", 10,
                FontStyle.Bold);

            lblPrice.Location =
                new Point(10, 150);

            lblPrice.AutoSize = true;

            Button btnAdd = new Button();

            btnAdd.Text = "+ Add";

            btnAdd.Size =
                new Size(180, 30);

            btnAdd.Location =
                new Point(20, 180);

            btnAdd.BackColor =
                Color.Crimson;

            btnAdd.ForeColor =
                Color.White;

            btnAdd.FlatStyle =
                FlatStyle.Flat;

            btnAdd.FlatAppearance.BorderSize = 0;

            btnAdd.Click += (sender, e) =>
            {
                Cart.AddItem(name);

                MessageBox.Show(
                    name + " added to cart!");
            };

            card.Controls.Add(pic);

            card.Controls.Add(lblName);

            card.Controls.Add(lblCategory);

            card.Controls.Add(lblPrice);

            card.Controls.Add(btnAdd);

            return card;
        }

        private void txtSearch_TextChanged(
            object sender,
            EventArgs e)
        {
            LoadMenu(
                txtSearch.Text,
                cmbCategory.Text);
        }

        private void cmbCategory_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            LoadMenu(
                txtSearch.Text,
                cmbCategory.Text);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
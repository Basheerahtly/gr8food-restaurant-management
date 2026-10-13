using assignment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gr8FoodSystem_Final
{
    public partial class Feedback : Form
    {
        private int customerId;
        DatabaseHelper db = new DatabaseHelper();
        public Feedback(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
            LoadCompletedOrders();
            this.TopLevel = false;
            this.FormBorderStyle =FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

        }
        private void LoadCompletedOrders()
        {
            string query =
                @"SELECT OrderID
          FROM Orders
          WHERE CustomerID=@id
          AND Status='Completed'";

            SqlParameter[] parameters =
            {
        new SqlParameter("@id", customerId)
    };

            DataTable dt =db.ExecuteQuery(query, parameters);

            cmbOrders.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                cmbOrders.Items.Add(
                    row["OrderID"].ToString());
            }
        }
        private void Feedback_Load(object sender, EventArgs e)
        {

        }

        private void txtFeedback_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbOrders.SelectedItem == null)
            {
                MessageBox.Show("Select an order.");
                return;
            }
            if (txtFeedback.Text.Trim() == "")
            {
                MessageBox.Show("Please enter feedback.");

                return;
            }

            if (!radioGood.Checked &&
              !radioBad.Checked &&
              !radioNeutral.Checked)
            {
                MessageBox.Show("Please select a rating.");

                return;
            }
            // RATING

            string rating = "";

            if (radioGood.Checked)
            {
                rating = "Good";
            }
            else if (radioBad.Checked)
            {
                rating = "Bad";
            }
            else if (radioNeutral.Checked)
            {
                rating = "Neutral";
            }

            // MESSAGE WITH RATING

            string message =txtFeedback.Text + "[" + rating + "] ";

            string query =  @"INSERT INTO Feedback
            (OrderID, Message, Response, Status, Date)
            VALUES
            (@oid, @msg, @res, @status, @date)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@oid", cmbOrders.SelectedItem.ToString()),
                new SqlParameter("@msg", message),
                new SqlParameter("@res", ""),
                new SqlParameter("@status", "Pending"),
                new SqlParameter("@date", DateTime.Now)
            };

            db.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Feedback submitted!");
            txtFeedback.Clear();
        }
        

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioGood_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }
    

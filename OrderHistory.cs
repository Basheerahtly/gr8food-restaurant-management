using assignment;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Gr8FoodSystem_Final
{
    public partial class OrderHistory : Form
    {
        DatabaseHelper db = new DatabaseHelper();
        private int customerId;
        public OrderHistory(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }
        private string GetWalletID(int customerId)
        {
            string query = "SELECT WalletID FROM Wallet WHERE CustomerID=@id";

            SqlParameter[] param =
            {
        new SqlParameter("@id", customerId)
    };

            object result = db.Executescalar(query, param);

            if (result == null || result == DBNull.Value)
                return null;

            return result.ToString();
        }



        // =========================
        // LOAD EVENT
        // =========================
        private void OrderHistory_Load(object sender, EventArgs e)
        {
            LoadOrderHistory();
        }

        // =========================
        // LOAD ORDERS
        // =========================
        private void LoadOrderHistory()
        {
            flowHistory.Controls.Clear();
            string query =
                @"SELECT *
                  FROM Orders
                  WHERE CustomerID = @id
                  ORDER BY OrderID DESC";

            SqlParameter[] param =
            {
                new SqlParameter("@id", customerId)
            };

            DataTable dt = db.ExecuteQuery(query, param);

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("No orders found!");
                return;
            }

            foreach (DataRow row in dt.Rows)
            {
                int orderId = Convert.ToInt32(row["OrderID"]);
                decimal total = Convert.ToDecimal(row["TotalAmount"]);
                string status = row["Status"].ToString();
                DateTime date = Convert.ToDateTime(row["OrderDateTime"]);

                flowHistory.Controls.Add(
                    CreateHistoryCard(orderId, total, status, date));
            }
        }

        // =========================
        // CREATE ORDER CARD
        // =========================
        private Panel CreateHistoryCard(
            int orderId,
            decimal total,
            string status,
            DateTime date)
        {
            Panel card = new Panel();
            card.Size = new Size(650, 120);
            card.BackColor = Color.White;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Margin = new Padding(10);

            Label lblOrder = new Label();
            lblOrder.Text = "Order #" + orderId;
            lblOrder.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblOrder.Location = new Point(20, 15);
            lblOrder.AutoSize = true;

            Label lblTotal = new Label();
            lblTotal.Text = "RM " + total;
            lblTotal.ForeColor = Color.Green;
            lblTotal.Location = new Point(20, 50);
            lblTotal.AutoSize = true;

            Label lblStatus = new Label();
            lblStatus.Text = "Status: " + status;

            if (status == "Completed")
                lblStatus.ForeColor = Color.Green;
            else if (status == "Pending")
                lblStatus.ForeColor = Color.Orange;
            else if (status == "Cancelled")
                lblStatus.ForeColor = Color.Red;

            lblStatus.Location = new Point(200, 50);
            lblStatus.AutoSize = true;

            Label lblDate = new Label();
            lblDate.Text = date.ToShortDateString();
            lblDate.Location = new Point(20, 80);
            lblDate.AutoSize = true;

            card.Controls.Add(lblOrder);
            card.Controls.Add(lblTotal);
            card.Controls.Add(lblStatus);
            card.Controls.Add(lblDate);

            // =========================
            // CANCEL BUTTON (ONLY PENDING)
            // =========================
            if (status == "Pending")
            {
                Button btnCancel = new Button();
                btnCancel.Text = "Cancel Order";
                btnCancel.Size = new Size(130, 40);
                btnCancel.Location = new Point(480, 35);
                btnCancel.BackColor = Color.Crimson;
                btnCancel.ForeColor = Color.White;
                btnCancel.FlatStyle = FlatStyle.Flat;
                btnCancel.FlatAppearance.BorderSize = 0;

                btnCancel.Click += (s, e) =>
                {
                    CancelOrder(orderId, total);
                };

                card.Controls.Add(btnCancel);
            }

            return card;
        }

        // =========================
        // CANCEL ORDER + REFUND
        // =========================
        private void CancelOrder(int orderId, decimal total)
        {

            // CANCEL ORDER
            string cancelQuery =
                @"UPDATE Orders
                  SET Status='Cancelled'
                  WHERE OrderID=@id AND CustomerID = @cust";

            SqlParameter[] cancelParams =
            {
                new SqlParameter("@id", orderId),
                new SqlParameter("@cust", customerId)
            };

            db.ExecuteNonQuery(cancelQuery, cancelParams);

            // REFUND WALLET
            string refundQuery =
                @"UPDATE Wallet
                  SET Balance = Balance + @amount
                  WHERE CustomerID=@cust";

            SqlParameter[] refundParams =
            {
                new SqlParameter("@amount", total),
                new SqlParameter("@cust", customerId)
            };

            db.ExecuteNonQuery(refundQuery, refundParams);

            // WALLET TRANSACTION

            string walletId = GetWalletID(customerId);

            if (walletId == null)
            {
                MessageBox.Show("Wallet not found!");
                return;
            }

            string transQuery =
                @"INSERT INTO WalletTransactions
      (TransactionID, WalletID, Amount, Type, Date)
      VALUES
      (@tid, @wid, @amt, @type, @date)";

            SqlParameter[] transParams =
            {
    new SqlParameter("@tid", "T" + DateTime.Now.Ticks.ToString().Substring(10)),
    new SqlParameter("@wid", walletId),   //  REAL WalletID (FIXED)
    new SqlParameter("@amt", total),
    new SqlParameter("@type", "Refund"),  // or "Top Up"
    new SqlParameter("@date", DateTime.Now)
};

            db.ExecuteNonQuery(transQuery, transParams);
            MessageBox.Show("Order cancelled and refund processed!");

            LoadOrderHistory();
        }

        private void flowHistory_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
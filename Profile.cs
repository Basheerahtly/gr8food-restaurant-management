using assignment;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gr8FoodSystem_Final
{
    public partial class Profile : Form
    {
        private int customerId;
        DatabaseHelper db = new DatabaseHelper();
        public Profile(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        // =========================
        // LOAD WALLET
        // =========================
        private void Profile_Load(object sender, EventArgs e)
        {
            LoadWallet();

        }

        private void LoadWallet()
        {
            try
            {
                if (customerId <= 0) return;

                string query = "SELECT Balance FROM Wallet WHERE CustomerID=@id";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@id", customerId)
                };

                object result =
                    db.Executescalar(query, parameters);

                if (result == null || result == DBNull.Value)
                {
                    CreateWallet(customerId);

                    labelWallet.Text =
                        "Wallet Balance: RM 0.00";

                    return;
                }

                labelWallet.Text =
                    "Wallet Balance: RM " + result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading wallet: " + ex.Message);
            }
        }

        // =========================
        // TOP UP WALLET
        // =========================

        private string GetWalletID(int customerId)
        {
            string query =
                "SELECT WalletID FROM Wallet WHERE CustomerID=@id";

            SqlParameter[] param =
            {
        new SqlParameter("@id", customerId)
    };

            object result =
                db.Executescalar(query, param);

            if (result == null || result == DBNull.Value)
                return null;

            return result.ToString();
        }

        private void CreateWallet(int customerId)
        {
            string walletId = GenerateWalletID();

            string query =
            @"INSERT INTO Wallet
    (
        WalletID,
        CustomerID,
        Balance
    )
    VALUES
    (
        @wid,
        @cid,
        0
    )";

            SqlParameter[] param =
            {
        new SqlParameter("@wid", walletId),
        new SqlParameter("@cid", customerId)
    };

            db.ExecuteNonQuery(query, param);
        }

        private string GenerateWalletID()
        {
            string query =
                "SELECT COUNT(*) FROM Wallet";

            int count =
                Convert.ToInt32(db.Executescalar(query));

            return "W" + (count + 1).ToString("000");
        }
        private void btnTopUp_Click(object sender, EventArgs e)
        {
            string walletId = GetWalletID(customerId);
            try
            {
                if (customerId <= 0) return;

                if (!decimal.TryParse(txtTopUp.Text, out decimal amount))
                {
                    MessageBox.Show("Enter valid amount!");
                    return;
                }

                if (amount <= 0)
                {
                    MessageBox.Show("Amount must be greater than 0!");
                    return;
                }

                // UPDATE WALLET
                string query =
                    @"UPDATE Wallet 
                      SET Balance = Balance + @amount 
                      WHERE CustomerID=@id";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@amount", amount),
                    new SqlParameter("@id", customerId)
                };

                db.ExecuteNonQuery(query, parameters);

                if (walletId == null)
                {
                    CreateWallet(customerId);

                    walletId = GetWalletID(customerId);
                }
                // INSERT TRANSACTION
                string transQuery =
                    @"INSERT INTO WalletTransactions
                      (TransactionID, WalletID, Amount, Type, Date)
                      VALUES
                      (@tid, @wid, @amt, @type, @date)";

                SqlParameter[] transParams =
                {
                    new SqlParameter("@tid", "T" + DateTime.Now.Ticks.ToString().Substring(10)),
                    new SqlParameter("@wid", walletId),
                    new SqlParameter("@amt", amount),
                    new SqlParameter("@type", "Top Up"),
                    new SqlParameter("@date", DateTime.Now)
                };

                db.ExecuteNonQuery(transQuery, transParams);

                MessageBox.Show("Wallet topped up successfully!");

                txtTopUp.Clear();

                LoadWallet();

                // refresh main wallet if needed
                Form1 main = Application.OpenForms["Form1"] as Form1;
                main?.RefreshWallet();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void labelLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged out!");
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateOwnProfile updateProfileForm = new frmUpdateOwnProfile();
            updateProfileForm.ShowDialog();
             
        }
    }
}
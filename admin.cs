using assignment.Helpers;
using assignment.Models;
using assignment.Repositories;
using System;
using System.Data;
using System.Windows.Forms;

namespace assignment
{
    // The dashboard form is only responsible for displaying data and navigating to other forms.
    // All data retrieval is delegated to UserRepository (Separation of Concerns)
    public partial class frmSystemAdmin : Form
    {
        private readonly UserRepository _userRepository;
        DatabaseHelper DatabaseHelper = new DatabaseHelper();
        User User = new User();

        public frmSystemAdmin()
        {
            InitializeComponent();
            _userRepository = new UserRepository();

            LoadDashboard();
        }

        // ─── Dashboard Load ───────────────────────────────────────────

        // Loads all dashboard data in one place — easy to maintain and extend
        private void LoadDashboard()
        {
            ShowWelcomeMessage();
            ShowLoginTime();
            LoadStatCards();
            LoadOrdersChart();
            
        }

        // Uses SessionManager to greet the logged-in admin by name
        private void ShowWelcomeMessage()
        {
            if (SessionManager.IsLoggedIn())
            {
                lblWelcome.Text = $"Welcome, {SessionManager.CurrentUser.Username}";
            }
        }

        private void ShowLoginTime()
        {
            lblTime.Text = "Login time: " + DateTime.Now.ToString("dd MMM yyyy, hh:mm tt");
        }

        // Loads all stat card values using UserRepository methods
        // The form does not write any SQL — that is the repository's job (Abstraction)
        private void LoadStatCards()
        {
            //lblTotalNumberofUsers.Text = "" + _userRepository.GetStaffCount();
            int totalMenuItems = Convert.ToInt32(DatabaseHelper.Executescalar("SELECT COUNT(*) FROM Menu_Table", null));
            lblNumberofCustomers.Text = "" + _userRepository.GetCustomerCount();
            lblTotalActiveUsers.Text = "" + _userRepository.GetActiveUserCount();
            lblTotalMenuItems.Text = totalMenuItems.ToString();

        }

        private void frmSystemAdmin_Load(object sender, EventArgs e)
        {

        }

        // ─── Menu Strip ───────────────────────────────────────────────

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show(
                "Are you sure you want to log out?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (response == DialogResult.Yes)
            {
                // Clear the session on logout
                SessionManager.Logout();
                this.Hide();
                frmLogin frmLogin = new frmLogin();
                frmLogin.ShowDialog();
                this.Close();
            }
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (response == DialogResult.Yes)
                this.Close();
        }

        private void menuUpdateProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateOwnProfile frmUpdateOwnProfiles = new frmUpdateOwnProfile();
            frmUpdateOwnProfiles.ShowDialog();
            this.Show();
        }

        private void menuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnViewSalesReport_Click(object sender, EventArgs e)
        {
            frmSalesReport frmSalesReport = new frmSalesReport();
            frmSalesReport.ShowDialog();
            this.Close();
        }

        private void lblSystemAdmin_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        // ─── Navigation Buttons ───────────────────────────────────────
        private void btnAddUser_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmAddUser frmAddUser = new frmAddUser();
            frmAddUser.ShowDialog();
            // Reload stat cards when returning — user count may have changed
            LoadStatCards();
            this.Show();
        }

        private void btnRemoveUser_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveUser frmRemoveUser = new frmRemoveUser();
            frmRemoveUser.ShowDialog();
            LoadStatCards();
            this.Show();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateUserProfiles frmUpdateUserProfiles = new frmUpdateUserProfiles();
            frmUpdateUserProfiles.ShowDialog();
            this.Show();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSalesReport frmSalesReport = new frmSalesReport();
            frmSalesReport.ShowDialog();
            this.Show();
        }

        private void btnViewAllAccounts_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmViewAllAccounts frmViewAllAccounts = new frmViewAllAccounts();
            frmViewAllAccounts.ShowDialog();
            this.Show();
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {

        }

        private void LoadOrdersChart()
        {
            DataTable dt = DatabaseHelper.ExecuteQuery(@"
        SELECT DATENAME(MONTH, OrderDateTime) AS MonthName,
               MONTH(OrderDateTime) AS MonthNumber,
               COUNT(*) AS TotalOrders
        FROM Orders
        GROUP BY DATENAME(MONTH, OrderDateTime), MONTH(OrderDateTime)
        ORDER BY MonthNumber", null);

            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Titles.Clear();

            chart1.ChartAreas.Add("MainArea");
            chart1.Titles.Add($"Total Orders by Month ({DateTime.Now.Year})");

            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Orders");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series.Color = System.Drawing.Color.SteelBlue;
            series.IsValueShownAsLabel = true;

            foreach (DataRow row in dt.Rows)
            {
                series.Points.AddXY(row["MonthName"].ToString(), Convert.ToInt32(row["TotalOrders"]));
            }

            chart1.Series.Add(series);
            chart1.ChartAreas["MainArea"].AxisX.Title = "Month";
            chart1.ChartAreas["MainArea"].AxisY.Title = "Total Orders";
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
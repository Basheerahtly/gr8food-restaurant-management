using assignment.Repositories;
using System;
using System.Data;
using System.Windows.Forms;

namespace assignment
{
    public partial class frmViewAllAccounts : Form
    {
        private readonly UserRepository _userRepository;

        public frmViewAllAccounts()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        private void view_all_accounts_Load(object sender, EventArgs e)
        {
            cmbFilterRole.SelectedIndexChanged -= cmbFilterRole_SelectedIndexChanged_1;
            cmbFilterGender.SelectedIndexChanged -= cmbFilterGender_SelectedIndexChanged_1;

            cmbFilterRole.Items.Clear();
            cmbFilterRole.Items.AddRange(new string[] { "All", "System Admin", "Manager", "Customer", "Chef1", "Chef2", "Chef3" });
            cmbFilterRole.SelectedIndex = 0;

            cmbFilterGender.Items.Clear();
            cmbFilterGender.Items.AddRange(new string[] { "All", "Male", "Female" });
            cmbFilterGender.SelectedIndex = 0;

            LoadAccounts();

            cmbFilterRole.SelectedIndexChanged += cmbFilterRole_SelectedIndexChanged_1;
            cmbFilterGender.SelectedIndexChanged += cmbFilterGender_SelectedIndexChanged_1;
        }

        private DataTable _fullData; // stores the unfiltered data

        private void LoadAccounts()
        {
            var users = _userRepository.GetAllUsers();

            _fullData = new DataTable();
            _fullData.Columns.Add("Username");
            _fullData.Columns.Add("Role");
            _fullData.Columns.Add("Email");
            _fullData.Columns.Add("Phone");
            _fullData.Columns.Add("Gender");

            foreach (var user in users)
            {
                _fullData.Rows.Add(
                    user.Username,
                    user.Role,
                    user.Email,
                    user.PhoneNumber,
                    user.Gender
                );
            }

            dataGridView1.DataSource = _fullData;
        }

        private void ApplyFilters()
        {
            if (_fullData == null) return;

            string search = txtSearch.Text.Trim().ToLower();
            string roleFilter = cmbFilterRole.SelectedItem?.ToString() ?? "All";
            string genderFilter = cmbFilterGender.SelectedItem?.ToString() ?? "All";

            // Build filter expression for DataTable
            string filter = "";

            if (!string.IsNullOrEmpty(search))
                filter += $"Username LIKE '%{search}%'";

            if (roleFilter != "All")
            {
                if (filter != "") filter += " AND ";
                filter += $"Role = '{roleFilter}'";
            }

            if (genderFilter != "All")
            {
                if (filter != "") filter += " AND ";
                filter += $"Gender = '{genderFilter}'";
            }

            // Apply filter directly to the DataTable view
            _fullData.DefaultView.RowFilter = filter;
            dataGridView1.DataSource = _fullData.DefaultView.ToTable();
        }


        // ─── Navigation Buttons ───────────────────────────────────────

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddUser frmAddUser = new frmAddUser();
            frmAddUser.ShowDialog();
            LoadAccounts();
            this.Show();
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveUser frmRemoveUser = new frmRemoveUser();
            frmRemoveUser.ShowDialog();
            LoadAccounts();
            this.Show();
        }

        private void btnUpdateUserProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateUserProfiles frmUpdateUserProfiles = new frmUpdateUserProfiles();
            frmUpdateUserProfiles.ShowDialog();
            LoadAccounts();
            this.Show();
        }

        private void pictureBoxBackToHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // ─── Filter Event Handlers ────────────────────────────────────
        private void cmbFilterRole_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void cmbFilterGender_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void btnClearFilters_Click_1(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbFilterRole.SelectedIndex = 0;
            cmbFilterGender.SelectedIndex = 0;
            ApplyFilters();
        }
    }
}
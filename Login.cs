using System;
using System.Windows.Forms;
using assignment.Helpers;
using assignment.Models;
using assignment.Repositories;
using CHEF;
using Gr8FoodSystem_Final;
using prac;

namespace assignment
{
    public partial class frmLogin : Form
    {
        private readonly UserRepository _userRepository;
        SessionManager SessionManager = new SessionManager();
        public string thisrole;
        public string thisname;
        public int thisId;
        PasswordHelper PasswordHelper = new PasswordHelper();

        // ─── State ────────────────────────────────────────────────────
        private int _attemptsRemaining = 3;

        public frmLogin()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        // ─── Show/Hide Password ───────────────────────────────────────

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        // ─── Login Button ─────────────────────────────────────────────
        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Basic empty field check
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lblError.Text = "Please enter your username and password.";
                return;
            }
            try
            {
                // Check if user exists
                User user = _userRepository.GetUserByUsername(username);
                if (user == null)
                {
                    MessageBox.Show("User does not exist.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Retrieve user from database via UserRepository
                // The form does not write any SQL — that is the repository's job (Separation of Concerns
                thisrole = user.Role;
                thisname = user.Username;
                thisId = user.Id;

                // Check if account has been disabled by admin
                if (!user.IsActive)
                {
                    MessageBox.Show(
                        "Your account has been disabled.\nPlease contact the system administrator.",
                        "Account Disabled",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                // Verify password using PasswordHelper
                // PasswordHelper hashes the entered password and compares it to the stored hash
                // Passwords are never stored or compared as plain text (Security best practice)
                if (PasswordHelper.VerifyPassword(password, user.Password))
                {
                    // Store the logged-in user globally using SessionManager
                    // This allows all other forms to access the current user without passing it manually
                    SessionManager.Login(user);

                    MessageBox.Show($"Welcome, {user.Username}!", "Login Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    OpenRoleForm(user.Role);
                }
                else
                {
                    HandleFailedAttempt();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Failed: " + ex.Message,
    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Role Routing ─────────────────────────────────────────────

        // Directs the user to the correct dashboard based on their role
        // Uses a switch statement so adding new roles only requires one new case here
        private void OpenRoleForm(string role)
        {
            try
            {
                Form nextForm;
                switch (role)
                {
                    case "System Admin":
                        nextForm = new frmSystemAdmin();
                        break;

                    case "Customer":
                        nextForm = new Form1(thisId);
                        break;
                    case "Manager":
                        nextForm = new Managerdashboard();
                        break;
                    case "Chef1":
                        nextForm = new Chef_Dashboard(thisrole, thisname);
                        break;
                    case "Chef2":
                        nextForm = new Chef_Dashboard(thisrole, thisname);
                        break;
                    case "Chef3":
                        nextForm = new Chef_Dashboard(thisrole, thisname);
                        break;
                    default:
                        MessageBox.Show($"No dashboard found for role: {role}",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Show();
                        return;
                }

                nextForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open dashboard: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show();
            }
        }

        // ─── Failed Login Handler ─────────────────────────────────────

        // Handles decrementing attempts and locking the form after 3 failures
        private void HandleFailedAttempt()
        {
            _attemptsRemaining--;

            if (_attemptsRemaining <= 0)
            {
                lblError.Text = "Account locked. Too many failed attempts.";
                btnLogin.Enabled = false;
                MessageBox.Show(
                    "You have exceeded the maximum number of login attempts.\nPlease contact the system administrator.",
                    "Account Locked",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
            {
                lblError.Text = $"Incorrect password. {_attemptsRemaining} attempt(s) remaining.";
            }
        }

        // ─── Menu Strip ───────────────────────────────────────────────

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult userResponse = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (userResponse == DialogResult.Yes)
                this.Close();
        }

        // ─── Back to Entrance ─────────────────────────────────────────

        private void lblRegisterNewAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEntrance frmEntrance = new frmEntrance();
            frmEntrance.ShowDialog();
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
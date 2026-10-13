namespace assignment
{
    partial class frmSystemAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSystemAdmin));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grpHome = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSystemAdmin = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.mnuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUpdateProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewAllAccounts = new System.Windows.Forms.Button();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblAdminTools = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNumberofCustomers = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalActiveUsers = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTotalMenuItems = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.grpHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // grpHome
            // 
            this.grpHome.BackColor = System.Drawing.Color.Transparent;
            this.grpHome.Controls.Add(this.pictureBox1);
            this.grpHome.Controls.Add(this.lblSystemAdmin);
            this.grpHome.Controls.Add(this.lblWelcome);
            this.grpHome.Controls.Add(this.lblTime);
            this.grpHome.Font = new System.Drawing.Font("Malgun Gothic", 8F);
            this.grpHome.Location = new System.Drawing.Point(332, 48);
            this.grpHome.Name = "grpHome";
            this.grpHome.Size = new System.Drawing.Size(812, 187);
            this.grpHome.TabIndex = 0;
            this.grpHome.TabStop = false;
            this.grpHome.Text = "Home";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(740, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblSystemAdmin
            // 
            this.lblSystemAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSystemAdmin.AutoSize = true;
            this.lblSystemAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblSystemAdmin.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lblSystemAdmin.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSystemAdmin.Location = new System.Drawing.Point(6, 102);
            this.lblSystemAdmin.Name = "lblSystemAdmin";
            this.lblSystemAdmin.Size = new System.Drawing.Size(262, 43);
            this.lblSystemAdmin.TabIndex = 1;
            this.lblSystemAdmin.Text = "System Admin";
            this.lblSystemAdmin.Click += new System.EventHandler(this.lblSystemAdmin_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblWelcome.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblWelcome.Location = new System.Drawing.Point(10, 42);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(164, 37);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome,";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Georgia", 6F);
            this.lblTime.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTime.Location = new System.Drawing.Point(23, 158);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 15);
            this.lblTime.TabIndex = 15;
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.Color.Transparent;
            this.menuMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuMain.BackgroundImage")));
            this.menuMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMain,
            this.menuUpdateProfile});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1676, 29);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuStrip1";
            this.menuMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuMain_ItemClicked);
            // 
            // mnuMain
            // 
            this.mnuMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogout,
            this.MnuExit});
            this.mnuMain.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(66, 25);
            this.mnuMain.Text = "Menu";
            // 
            // mnuLogout
            // 
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(270, 34);
            this.mnuLogout.Text = "Logout";
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // MnuExit
            // 
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(270, 34);
            this.MnuExit.Text = "Exit";
            this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // menuUpdateProfile
            // 
            this.menuUpdateProfile.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.menuUpdateProfile.Name = "menuUpdateProfile";
            this.menuUpdateProfile.Size = new System.Drawing.Size(125, 25);
            this.menuUpdateProfile.Text = "Update Profile";
            this.menuUpdateProfile.Click += new System.EventHandler(this.menuUpdateProfile_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7239, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.BackColor = System.Drawing.Color.Transparent;
            this.lblDashboard.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Underline);
            this.lblDashboard.Location = new System.Drawing.Point(326, 275);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(129, 32);
            this.lblDashboard.TabIndex = 14;
            this.lblDashboard.Text = "Dashboard";
            this.lblDashboard.Click += new System.EventHandler(this.lblDashboard_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.btnViewAllAccounts);
            this.panel1.Controls.Add(this.btnViewReport);
            this.panel1.Controls.Add(this.btnUpdateUser);
            this.panel1.Controls.Add(this.btnRemoveUser);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.lblAdminTools);
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 844);
            this.panel1.TabIndex = 15;
            // 
            // btnViewAllAccounts
            // 
            this.btnViewAllAccounts.BackColor = System.Drawing.Color.Transparent;
            this.btnViewAllAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAllAccounts.ForeColor = System.Drawing.Color.White;
            this.btnViewAllAccounts.Location = new System.Drawing.Point(0, 573);
            this.btnViewAllAccounts.Name = "btnViewAllAccounts";
            this.btnViewAllAccounts.Size = new System.Drawing.Size(281, 67);
            this.btnViewAllAccounts.TabIndex = 5;
            this.btnViewAllAccounts.Text = "View Accounts";
            this.btnViewAllAccounts.UseVisualStyleBackColor = false;
            this.btnViewAllAccounts.Click += new System.EventHandler(this.btnViewAllAccounts_Click_1);
            // 
            // btnViewReport
            // 
            this.btnViewReport.BackColor = System.Drawing.Color.Transparent;
            this.btnViewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReport.ForeColor = System.Drawing.Color.White;
            this.btnViewReport.Location = new System.Drawing.Point(3, 477);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(281, 67);
            this.btnViewReport.TabIndex = 4;
            this.btnViewReport.Text = "View Report";
            this.btnViewReport.UseVisualStyleBackColor = false;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.Location = new System.Drawing.Point(2, 377);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(281, 67);
            this.btnUpdateUser.TabIndex = 3;
            this.btnUpdateUser.Text = "Update User Profile";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveUser.ForeColor = System.Drawing.Color.White;
            this.btnRemoveUser.Location = new System.Drawing.Point(0, 273);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(281, 67);
            this.btnRemoveUser.TabIndex = 2;
            this.btnRemoveUser.Text = "Remove User";
            this.btnRemoveUser.UseVisualStyleBackColor = false;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click_1);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(0, 170);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(281, 67);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click_1);
            // 
            // lblAdminTools
            // 
            this.lblAdminTools.AutoSize = true;
            this.lblAdminTools.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold);
            this.lblAdminTools.ForeColor = System.Drawing.Color.White;
            this.lblAdminTools.Location = new System.Drawing.Point(35, 75);
            this.lblAdminTools.Name = "lblAdminTools";
            this.lblAdminTools.Size = new System.Drawing.Size(212, 35);
            this.lblAdminTools.TabIndex = 0;
            this.lblAdminTools.Text = "Admin Tools";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(252)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.lblNumberofCustomers);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(332, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 133);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total Number of Customers";
            // 
            // lblNumberofCustomers
            // 
            this.lblNumberofCustomers.AutoSize = true;
            this.lblNumberofCustomers.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold);
            this.lblNumberofCustomers.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblNumberofCustomers.Location = new System.Drawing.Point(80, 53);
            this.lblNumberofCustomers.Name = "lblNumberofCustomers";
            this.lblNumberofCustomers.Size = new System.Drawing.Size(52, 35);
            this.lblNumberofCustomers.TabIndex = 17;
            this.lblNumberofCustomers.Text = "25";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(252)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.lblTotalActiveUsers);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(655, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 133);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total Number of Users";
            // 
            // lblTotalActiveUsers
            // 
            this.lblTotalActiveUsers.AutoSize = true;
            this.lblTotalActiveUsers.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold);
            this.lblTotalActiveUsers.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblTotalActiveUsers.Location = new System.Drawing.Point(80, 53);
            this.lblTotalActiveUsers.Name = "lblTotalActiveUsers";
            this.lblTotalActiveUsers.Size = new System.Drawing.Size(52, 35);
            this.lblTotalActiveUsers.TabIndex = 17;
            this.lblTotalActiveUsers.Text = "25";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(252)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.lblTotalMenuItems);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox3.Location = new System.Drawing.Point(932, 328);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 133);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total Menu Items";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lblTotalMenuItems
            // 
            this.lblTotalMenuItems.AutoSize = true;
            this.lblTotalMenuItems.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold);
            this.lblTotalMenuItems.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblTotalMenuItems.Location = new System.Drawing.Point(80, 53);
            this.lblTotalMenuItems.Name = "lblTotalMenuItems";
            this.lblTotalMenuItems.Size = new System.Drawing.Size(52, 35);
            this.lblTotalMenuItems.TabIndex = 17;
            this.lblTotalMenuItems.Text = "25";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(375, 494);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(838, 337);
            this.chart1.TabIndex = 20;
            this.chart1.Text = "chart1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1358, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(318, 930);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1358, 317);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(331, 164);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // frmSystemAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1676, 874);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.grpHome);
            this.Controls.Add(this.menuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmSystemAdmin";
            this.Load += new System.EventHandler(this.frmSystemAdmin_Load);
            this.grpHome.ResumeLayout(false);
            this.grpHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpHome;
        private System.Windows.Forms.Label lblSystemAdmin;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.ToolStripMenuItem menuUpdateProfile;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAdminTools;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.Button btnViewAllAccounts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNumberofCustomers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalActiveUsers;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTotalMenuItems;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
namespace assignment
{
    partial class frmSalesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesReport));
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.lblResultCount = new System.Windows.Forms.Label();
            this.dgvSalesReport = new System.Windows.Forms.DataGridView();
            this.lblViewReport = new System.Windows.Forms.Label();
            this.pictureBoxBackToHome = new System.Windows.Forms.PictureBox();
            this.lblBackToHome = new System.Windows.Forms.Label();
            this.lblSelectMonth = new System.Windows.Forms.Label();
            this.lblSelectYear = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrders = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.lblTotalItemsDisplay = new System.Windows.Forms.Label();
            this.lblResultCountDisplay = new System.Windows.Forms.Label();
            this.lblSummary = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackToHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(429, 262);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(231, 28);
            this.cmbYear.TabIndex = 0;
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(65, 262);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(228, 28);
            this.cmbMonth.TabIndex = 1;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(65, 371);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(233, 28);
            this.cmbCategory.TabIndex = 2;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(429, 370);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(101, 42);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(549, 370);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(113, 42);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.AutoSize = true;
            this.lblTotalOrders.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrders.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblTotalOrders.Location = new System.Drawing.Point(242, 548);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(34, 28);
            this.lblTotalOrders.TabIndex = 5;
            this.lblTotalOrders.Text = "25";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblTotalRevenue.Location = new System.Drawing.Point(240, 599);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(34, 28);
            this.lblTotalRevenue.TabIndex = 6;
            this.lblTotalRevenue.Text = "10";
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItems.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblTotalItems.Location = new System.Drawing.Point(237, 644);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(45, 28);
            this.lblTotalItems.TabIndex = 7;
            this.lblTotalItems.Text = "546";
            // 
            // lblResultCount
            // 
            this.lblResultCount.AutoSize = true;
            this.lblResultCount.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultCount.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblResultCount.Location = new System.Drawing.Point(238, 693);
            this.lblResultCount.Name = "lblResultCount";
            this.lblResultCount.Size = new System.Drawing.Size(34, 28);
            this.lblResultCount.TabIndex = 8;
            this.lblResultCount.Text = "56";
            // 
            // dgvSalesReport
            // 
            this.dgvSalesReport.AllowUserToAddRows = false;
            this.dgvSalesReport.AllowUserToDeleteRows = false;
            this.dgvSalesReport.AllowUserToOrderColumns = true;
            this.dgvSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesReport.Location = new System.Drawing.Point(797, 171);
            this.dgvSalesReport.Name = "dgvSalesReport";
            this.dgvSalesReport.ReadOnly = true;
            this.dgvSalesReport.RowHeadersWidth = 62;
            this.dgvSalesReport.RowTemplate.Height = 28;
            this.dgvSalesReport.Size = new System.Drawing.Size(935, 613);
            this.dgvSalesReport.TabIndex = 9;
            // 
            // lblViewReport
            // 
            this.lblViewReport.AutoSize = true;
            this.lblViewReport.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewReport.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblViewReport.Location = new System.Drawing.Point(55, 126);
            this.lblViewReport.Name = "lblViewReport";
            this.lblViewReport.Size = new System.Drawing.Size(408, 56);
            this.lblViewReport.TabIndex = 10;
            this.lblViewReport.Text = "View Sales Report";
            // 
            // pictureBoxBackToHome
            // 
            this.pictureBoxBackToHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBackToHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackToHome.Image")));
            this.pictureBoxBackToHome.Location = new System.Drawing.Point(65, 68);
            this.pictureBoxBackToHome.Name = "pictureBoxBackToHome";
            this.pictureBoxBackToHome.Size = new System.Drawing.Size(40, 43);
            this.pictureBoxBackToHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBackToHome.TabIndex = 12;
            this.pictureBoxBackToHome.TabStop = false;
            this.pictureBoxBackToHome.Click += new System.EventHandler(this.pictureBoxBackToHome_Click);
            // 
            // lblBackToHome
            // 
            this.lblBackToHome.AutoSize = true;
            this.lblBackToHome.BackColor = System.Drawing.Color.Transparent;
            this.lblBackToHome.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackToHome.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBackToHome.Location = new System.Drawing.Point(108, 79);
            this.lblBackToHome.Name = "lblBackToHome";
            this.lblBackToHome.Size = new System.Drawing.Size(150, 23);
            this.lblBackToHome.TabIndex = 11;
            this.lblBackToHome.Text = "Back To Home";
            // 
            // lblSelectMonth
            // 
            this.lblSelectMonth.AutoSize = true;
            this.lblSelectMonth.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectMonth.Location = new System.Drawing.Point(61, 235);
            this.lblSelectMonth.Name = "lblSelectMonth";
            this.lblSelectMonth.Size = new System.Drawing.Size(126, 24);
            this.lblSelectMonth.TabIndex = 13;
            this.lblSelectMonth.Text = "Select Month";
            // 
            // lblSelectYear
            // 
            this.lblSelectYear.AutoSize = true;
            this.lblSelectYear.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectYear.Location = new System.Drawing.Point(425, 235);
            this.lblSelectYear.Name = "lblSelectYear";
            this.lblSelectYear.Size = new System.Drawing.Size(105, 24);
            this.lblSelectYear.TabIndex = 14;
            this.lblSelectYear.Text = "Select Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Select Category";
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrders.ForeColor = System.Drawing.Color.DarkRed;
            this.lblOrders.Location = new System.Drawing.Point(60, 548);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(143, 28);
            this.lblOrders.TabIndex = 16;
            this.lblOrders.Text = "Total Orders:";
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenue.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRevenue.Location = new System.Drawing.Point(60, 598);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(159, 28);
            this.lblRevenue.TabIndex = 17;
            this.lblRevenue.Text = "Total Revenue:";
            // 
            // lblTotalItemsDisplay
            // 
            this.lblTotalItemsDisplay.AutoSize = true;
            this.lblTotalItemsDisplay.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItemsDisplay.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotalItemsDisplay.Location = new System.Drawing.Point(60, 645);
            this.lblTotalItemsDisplay.Name = "lblTotalItemsDisplay";
            this.lblTotalItemsDisplay.Size = new System.Drawing.Size(129, 28);
            this.lblTotalItemsDisplay.TabIndex = 18;
            this.lblTotalItemsDisplay.Text = "Total Items:";
            // 
            // lblResultCountDisplay
            // 
            this.lblResultCountDisplay.AutoSize = true;
            this.lblResultCountDisplay.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultCountDisplay.ForeColor = System.Drawing.Color.DarkRed;
            this.lblResultCountDisplay.Location = new System.Drawing.Point(60, 693);
            this.lblResultCountDisplay.Name = "lblResultCountDisplay";
            this.lblResultCountDisplay.Size = new System.Drawing.Size(149, 28);
            this.lblResultCountDisplay.TabIndex = 19;
            this.lblResultCountDisplay.Text = "Result Count:";
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.Location = new System.Drawing.Point(56, 490);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(155, 32);
            this.lblSummary.TabIndex = 20;
            this.lblSummary.Text = "Summary";
            this.lblSummary.Click += new System.EventHandler(this.lblSummary_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(217, 488);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // frmSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1785, 847);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.lblTotalItems);
            this.Controls.Add(this.lblTotalItemsDisplay);
            this.Controls.Add(this.lblTotalRevenue);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.lblOrders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSelectYear);
            this.Controls.Add(this.lblSelectMonth);
            this.Controls.Add(this.pictureBoxBackToHome);
            this.Controls.Add(this.lblBackToHome);
            this.Controls.Add(this.lblViewReport);
            this.Controls.Add(this.dgvSalesReport);
            this.Controls.Add(this.lblResultCount);
            this.Controls.Add(this.lblTotalOrders);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblResultCountDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSalesReport";
            this.Text = "SalesReport";
            this.Load += new System.EventHandler(this.frmSalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackToHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTotalOrders;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Label lblResultCount;
        private System.Windows.Forms.DataGridView dgvSalesReport;
        private System.Windows.Forms.Label lblViewReport;
        private System.Windows.Forms.PictureBox pictureBoxBackToHome;
        private System.Windows.Forms.Label lblBackToHome;
        private System.Windows.Forms.Label lblSelectMonth;
        private System.Windows.Forms.Label lblSelectYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblTotalItemsDisplay;
        private System.Windows.Forms.Label lblResultCountDisplay;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
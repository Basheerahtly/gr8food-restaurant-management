namespace prac
{
    partial class WalletReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WalletReport));
            this.dgvWalletTrans = new System.Windows.Forms.DataGridView();
            this.lblMonthYear = new System.Windows.Forms.Label();
            this.pnlWalletReportHdr = new System.Windows.Forms.Panel();
            this.lblWalletSubtitle = new System.Windows.Forms.Label();
            this.lblHeadingWalletTransaction = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlTotalTopupCard = new System.Windows.Forms.Panel();
            this.picTopUp = new System.Windows.Forms.PictureBox();
            this.lblTtlTopupNo = new System.Windows.Forms.Label();
            this.lblTotalTopup = new System.Windows.Forms.Label();
            this.pnlNetBalanceCard = new System.Windows.Forms.Panel();
            this.picBalance = new System.Windows.Forms.PictureBox();
            this.lblNetBalanceNo = new System.Windows.Forms.Label();
            this.lblNetBalance = new System.Windows.Forms.Label();
            this.pnlTotalTransactionCard = new System.Windows.Forms.Panel();
            this.picTransaction = new System.Windows.Forms.PictureBox();
            this.lblTtlTransactionNo = new System.Windows.Forms.Label();
            this.lblTotalTransaction = new System.Windows.Forms.Label();
            this.pnlTotalUseCard = new System.Windows.Forms.Panel();
            this.picUsage = new System.Windows.Forms.PictureBox();
            this.lblTtlUsageNo = new System.Windows.Forms.Label();
            this.lblTotalUse = new System.Windows.Forms.Label();
            this.lblTransactionHistory = new System.Windows.Forms.Label();
            this.picTransactionHistory = new System.Windows.Forms.PictureBox();
            this.btnDasboard = new System.Windows.Forms.Button();
            this.btnUpdProf = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnWallet = new System.Windows.Forms.Button();
            this.pnlSidebarWallet = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tlpnlOuterDetailsWallet = new System.Windows.Forms.TableLayoutPanel();
            this.tlpnlInnerWallet = new System.Windows.Forms.TableLayoutPanel();
            this.pnlWalletFilterReset = new System.Windows.Forms.Panel();
            this.tlpnlWalletCards = new System.Windows.Forms.TableLayoutPanel();
            this.pnlWalletTrans = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWalletTrans)).BeginInit();
            this.pnlWalletReportHdr.SuspendLayout();
            this.pnlTotalTopupCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTopUp)).BeginInit();
            this.pnlNetBalanceCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBalance)).BeginInit();
            this.pnlTotalTransactionCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTransaction)).BeginInit();
            this.pnlTotalUseCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTransactionHistory)).BeginInit();
            this.pnlSidebarWallet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tlpnlOuterDetailsWallet.SuspendLayout();
            this.tlpnlInnerWallet.SuspendLayout();
            this.pnlWalletFilterReset.SuspendLayout();
            this.tlpnlWalletCards.SuspendLayout();
            this.pnlWalletTrans.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvWalletTrans
            // 
            this.dgvWalletTrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWalletTrans.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvWalletTrans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvWalletTrans.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvWalletTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWalletTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWalletTrans.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvWalletTrans.Location = new System.Drawing.Point(0, 0);
            this.dgvWalletTrans.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvWalletTrans.Name = "dgvWalletTrans";
            this.dgvWalletTrans.ReadOnly = true;
            this.dgvWalletTrans.RowHeadersVisible = false;
            this.dgvWalletTrans.RowHeadersWidth = 62;
            this.dgvWalletTrans.Size = new System.Drawing.Size(1095, 393);
            this.dgvWalletTrans.TabIndex = 1;
            this.dgvWalletTrans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWalletTrans_CellContentClick);
            // 
            // lblMonthYear
            // 
            this.lblMonthYear.AutoSize = true;
            this.lblMonthYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMonthYear.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthYear.Location = new System.Drawing.Point(374, 0);
            this.lblMonthYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonthYear.Name = "lblMonthYear";
            this.lblMonthYear.Size = new System.Drawing.Size(362, 32);
            this.lblMonthYear.TabIndex = 2;
            this.lblMonthYear.Text = "Select Month and Year:";
            // 
            // pnlWalletReportHdr
            // 
            this.pnlWalletReportHdr.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pnlWalletReportHdr.Controls.Add(this.lblWalletSubtitle);
            this.pnlWalletReportHdr.Controls.Add(this.lblHeadingWalletTransaction);
            this.pnlWalletReportHdr.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWalletReportHdr.Location = new System.Drawing.Point(0, 0);
            this.pnlWalletReportHdr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlWalletReportHdr.Name = "pnlWalletReportHdr";
            this.pnlWalletReportHdr.Size = new System.Drawing.Size(1312, 62);
            this.pnlWalletReportHdr.TabIndex = 3;
            // 
            // lblWalletSubtitle
            // 
            this.lblWalletSubtitle.AutoSize = true;
            this.lblWalletSubtitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWalletSubtitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWalletSubtitle.Location = new System.Drawing.Point(5, 38);
            this.lblWalletSubtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWalletSubtitle.Name = "lblWalletSubtitle";
            this.lblWalletSubtitle.Size = new System.Drawing.Size(460, 22);
            this.lblWalletSubtitle.TabIndex = 10;
            this.lblWalletSubtitle.Text = "View and analyze wallet transactions for your customers.";
            // 
            // lblHeadingWalletTransaction
            // 
            this.lblHeadingWalletTransaction.AutoSize = true;
            this.lblHeadingWalletTransaction.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingWalletTransaction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHeadingWalletTransaction.Location = new System.Drawing.Point(16, 11);
            this.lblHeadingWalletTransaction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeadingWalletTransaction.Name = "lblHeadingWalletTransaction";
            this.lblHeadingWalletTransaction.Size = new System.Drawing.Size(328, 31);
            this.lblHeadingWalletTransaction.TabIndex = 0;
            this.lblHeadingWalletTransaction.Text = "Wallet Transaction Report";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(4, 0);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(362, 32);
            this.lblCustomer.TabIndex = 4;
            this.lblCustomer.Text = "Select Customer:";
            // 
            // cmbUser
            // 
            this.cmbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUser.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(4, 36);
            this.cmbUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(362, 26);
            this.cmbUser.TabIndex = 5;
            this.cmbUser.Text = " 👤 --Select Customer--";
            this.cmbUser.SelectedIndexChanged += new System.EventHandler(this.cmbUser_SelectedIndexChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.CustomFormat = "MM/yyy";
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(374, 36);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(362, 26);
            this.dtpDate.TabIndex = 6;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.ForestGreen;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(18, 36);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(142, 32);
            this.btnFilter.TabIndex = 7;
            this.btnFilter.Text = " ⌕ Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.IndianRed;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(168, 36);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(132, 30);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = " ⟳ Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pnlTotalTopupCard
            // 
            this.pnlTotalTopupCard.BackColor = System.Drawing.Color.Honeydew;
            this.pnlTotalTopupCard.Controls.Add(this.picTopUp);
            this.pnlTotalTopupCard.Controls.Add(this.lblTtlTopupNo);
            this.pnlTotalTopupCard.Controls.Add(this.lblTotalTopup);
            this.pnlTotalTopupCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotalTopupCard.Location = new System.Drawing.Point(4, 4);
            this.pnlTotalTopupCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTotalTopupCard.Name = "pnlTotalTopupCard";
            this.pnlTotalTopupCard.Size = new System.Drawing.Size(263, 134);
            this.pnlTotalTopupCard.TabIndex = 13;
            // 
            // picTopUp
            // 
            this.picTopUp.ErrorImage = null;
            this.picTopUp.Image = ((System.Drawing.Image)(resources.GetObject("picTopUp.Image")));
            this.picTopUp.InitialImage = null;
            this.picTopUp.Location = new System.Drawing.Point(12, 25);
            this.picTopUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picTopUp.Name = "picTopUp";
            this.picTopUp.Size = new System.Drawing.Size(88, 76);
            this.picTopUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTopUp.TabIndex = 9;
            this.picTopUp.TabStop = false;
            // 
            // lblTtlTopupNo
            // 
            this.lblTtlTopupNo.AutoSize = true;
            this.lblTtlTopupNo.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtlTopupNo.Location = new System.Drawing.Point(130, 71);
            this.lblTtlTopupNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTtlTopupNo.Name = "lblTtlTopupNo";
            this.lblTtlTopupNo.Size = new System.Drawing.Size(70, 31);
            this.lblTtlTopupNo.TabIndex = 5;
            this.lblTtlTopupNo.Text = "$400";
            // 
            // lblTotalTopup
            // 
            this.lblTotalTopup.AutoSize = true;
            this.lblTotalTopup.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTopup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotalTopup.Location = new System.Drawing.Point(108, 25);
            this.lblTotalTopup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalTopup.Name = "lblTotalTopup";
            this.lblTotalTopup.Size = new System.Drawing.Size(126, 28);
            this.lblTotalTopup.TabIndex = 4;
            this.lblTotalTopup.Text = "Total Top-up\r\n";
            // 
            // pnlNetBalanceCard
            // 
            this.pnlNetBalanceCard.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pnlNetBalanceCard.Controls.Add(this.picBalance);
            this.pnlNetBalanceCard.Controls.Add(this.lblNetBalanceNo);
            this.pnlNetBalanceCard.Controls.Add(this.lblNetBalance);
            this.pnlNetBalanceCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNetBalanceCard.Location = new System.Drawing.Point(546, 4);
            this.pnlNetBalanceCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlNetBalanceCard.Name = "pnlNetBalanceCard";
            this.pnlNetBalanceCard.Size = new System.Drawing.Size(263, 134);
            this.pnlNetBalanceCard.TabIndex = 14;
            // 
            // picBalance
            // 
            this.picBalance.ErrorImage = null;
            this.picBalance.Image = ((System.Drawing.Image)(resources.GetObject("picBalance.Image")));
            this.picBalance.InitialImage = null;
            this.picBalance.Location = new System.Drawing.Point(13, 25);
            this.picBalance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBalance.Name = "picBalance";
            this.picBalance.Size = new System.Drawing.Size(88, 76);
            this.picBalance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBalance.TabIndex = 11;
            this.picBalance.TabStop = false;
            // 
            // lblNetBalanceNo
            // 
            this.lblNetBalanceNo.AutoSize = true;
            this.lblNetBalanceNo.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetBalanceNo.Location = new System.Drawing.Point(151, 71);
            this.lblNetBalanceNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNetBalanceNo.Name = "lblNetBalanceNo";
            this.lblNetBalanceNo.Size = new System.Drawing.Size(56, 31);
            this.lblNetBalanceNo.TabIndex = 7;
            this.lblNetBalanceNo.Text = "$20";
            // 
            // lblNetBalance
            // 
            this.lblNetBalance.AutoSize = true;
            this.lblNetBalance.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetBalance.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblNetBalance.Location = new System.Drawing.Point(109, 25);
            this.lblNetBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNetBalance.Name = "lblNetBalance";
            this.lblNetBalance.Size = new System.Drawing.Size(120, 28);
            this.lblNetBalance.TabIndex = 5;
            this.lblNetBalance.Text = "Net Balance";
            // 
            // pnlTotalTransactionCard
            // 
            this.pnlTotalTransactionCard.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnlTotalTransactionCard.Controls.Add(this.picTransaction);
            this.pnlTotalTransactionCard.Controls.Add(this.lblTtlTransactionNo);
            this.pnlTotalTransactionCard.Controls.Add(this.lblTotalTransaction);
            this.pnlTotalTransactionCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotalTransactionCard.Location = new System.Drawing.Point(817, 4);
            this.pnlTotalTransactionCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTotalTransactionCard.Name = "pnlTotalTransactionCard";
            this.pnlTotalTransactionCard.Size = new System.Drawing.Size(265, 134);
            this.pnlTotalTransactionCard.TabIndex = 14;
            // 
            // picTransaction
            // 
            this.picTransaction.ErrorImage = null;
            this.picTransaction.Image = ((System.Drawing.Image)(resources.GetObject("picTransaction.Image")));
            this.picTransaction.InitialImage = null;
            this.picTransaction.Location = new System.Drawing.Point(8, 25);
            this.picTransaction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picTransaction.Name = "picTransaction";
            this.picTransaction.Size = new System.Drawing.Size(88, 76);
            this.picTransaction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTransaction.TabIndex = 11;
            this.picTransaction.TabStop = false;
            // 
            // lblTtlTransactionNo
            // 
            this.lblTtlTransactionNo.AutoSize = true;
            this.lblTtlTransactionNo.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtlTransactionNo.Location = new System.Drawing.Point(149, 66);
            this.lblTtlTransactionNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTtlTransactionNo.Name = "lblTtlTransactionNo";
            this.lblTtlTransactionNo.Size = new System.Drawing.Size(70, 31);
            this.lblTtlTransactionNo.TabIndex = 8;
            this.lblTtlTransactionNo.Text = "$250";
            // 
            // lblTotalTransaction
            // 
            this.lblTotalTransaction.AutoSize = true;
            this.lblTotalTransaction.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTransaction.ForeColor = System.Drawing.Color.Purple;
            this.lblTotalTransaction.Location = new System.Drawing.Point(96, 25);
            this.lblTotalTransaction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalTransaction.Name = "lblTotalTransaction";
            this.lblTotalTransaction.Size = new System.Drawing.Size(163, 28);
            this.lblTotalTransaction.TabIndex = 6;
            this.lblTotalTransaction.Text = "Total Transaction";
            // 
            // pnlTotalUseCard
            // 
            this.pnlTotalUseCard.BackColor = System.Drawing.Color.Lavender;
            this.pnlTotalUseCard.Controls.Add(this.picUsage);
            this.pnlTotalUseCard.Controls.Add(this.lblTtlUsageNo);
            this.pnlTotalUseCard.Controls.Add(this.lblTotalUse);
            this.pnlTotalUseCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotalUseCard.Location = new System.Drawing.Point(275, 4);
            this.pnlTotalUseCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTotalUseCard.Name = "pnlTotalUseCard";
            this.pnlTotalUseCard.Size = new System.Drawing.Size(263, 134);
            this.pnlTotalUseCard.TabIndex = 14;
            // 
            // picUsage
            // 
            this.picUsage.ErrorImage = null;
            this.picUsage.Image = ((System.Drawing.Image)(resources.GetObject("picUsage.Image")));
            this.picUsage.InitialImage = null;
            this.picUsage.Location = new System.Drawing.Point(7, 25);
            this.picUsage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picUsage.Name = "picUsage";
            this.picUsage.Size = new System.Drawing.Size(88, 76);
            this.picUsage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsage.TabIndex = 10;
            this.picUsage.TabStop = false;
            // 
            // lblTtlUsageNo
            // 
            this.lblTtlUsageNo.AutoSize = true;
            this.lblTtlUsageNo.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtlUsageNo.Location = new System.Drawing.Point(131, 71);
            this.lblTtlUsageNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTtlUsageNo.Name = "lblTtlUsageNo";
            this.lblTtlUsageNo.Size = new System.Drawing.Size(70, 31);
            this.lblTtlUsageNo.TabIndex = 6;
            this.lblTtlUsageNo.Text = "$100";
            // 
            // lblTotalUse
            // 
            this.lblTotalUse.AutoSize = true;
            this.lblTotalUse.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUse.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTotalUse.Location = new System.Drawing.Point(103, 25);
            this.lblTotalUse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalUse.Name = "lblTotalUse";
            this.lblTotalUse.Size = new System.Drawing.Size(117, 28);
            this.lblTotalUse.TabIndex = 2;
            this.lblTotalUse.Text = "Total Usage\r\n";
            // 
            // lblTransactionHistory
            // 
            this.lblTransactionHistory.AutoSize = true;
            this.lblTransactionHistory.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionHistory.Location = new System.Drawing.Point(265, 306);
            this.lblTransactionHistory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionHistory.Name = "lblTransactionHistory";
            this.lblTransactionHistory.Size = new System.Drawing.Size(223, 32);
            this.lblTransactionHistory.TabIndex = 14;
            this.lblTransactionHistory.Text = "Transaction History";
            // 
            // picTransactionHistory
            // 
            this.picTransactionHistory.ErrorImage = null;
            this.picTransactionHistory.Image = ((System.Drawing.Image)(resources.GetObject("picTransactionHistory.Image")));
            this.picTransactionHistory.InitialImage = null;
            this.picTransactionHistory.Location = new System.Drawing.Point(213, 293);
            this.picTransactionHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picTransactionHistory.Name = "picTransactionHistory";
            this.picTransactionHistory.Size = new System.Drawing.Size(44, 43);
            this.picTransactionHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTransactionHistory.TabIndex = 10;
            this.picTransactionHistory.TabStop = false;
            // 
            // btnDasboard
            // 
            this.btnDasboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDasboard.FlatAppearance.BorderSize = 0;
            this.btnDasboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDasboard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDasboard.ForeColor = System.Drawing.Color.White;
            this.btnDasboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDasboard.Location = new System.Drawing.Point(-32, 134);
            this.btnDasboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDasboard.Name = "btnDasboard";
            this.btnDasboard.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnDasboard.Size = new System.Drawing.Size(245, 74);
            this.btnDasboard.TabIndex = 7;
            this.btnDasboard.Text = " ≡  Dashboard";
            this.btnDasboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDasboard.UseVisualStyleBackColor = false;
            this.btnDasboard.Click += new System.EventHandler(this.btnDasboard_Click);
            // 
            // btnUpdProf
            // 
            this.btnUpdProf.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdProf.FlatAppearance.BorderSize = 0;
            this.btnUpdProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdProf.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdProf.ForeColor = System.Drawing.Color.White;
            this.btnUpdProf.Location = new System.Drawing.Point(-7, 354);
            this.btnUpdProf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdProf.Name = "btnUpdProf";
            this.btnUpdProf.Size = new System.Drawing.Size(216, 73);
            this.btnUpdProf.TabIndex = 3;
            this.btnUpdProf.Text = "👤 Update Profile";
            this.btnUpdProf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdProf.UseVisualStyleBackColor = false;
            this.btnUpdProf.Click += new System.EventHandler(this.btnUpdProf_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 594);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(210, 76);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = " ➜] Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.BackColor = System.Drawing.Color.Transparent;
            this.btnFeedback.FlatAppearance.BorderSize = 0;
            this.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedback.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.ForeColor = System.Drawing.Color.White;
            this.btnFeedback.Location = new System.Drawing.Point(-36, 202);
            this.btnFeedback.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnFeedback.Size = new System.Drawing.Size(249, 73);
            this.btnFeedback.TabIndex = 1;
            this.btnFeedback.Text = " 💬 Manage Feedback\r\n";
            this.btnFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFeedback.UseVisualStyleBackColor = false;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnWallet
            // 
            this.btnWallet.BackColor = System.Drawing.Color.Transparent;
            this.btnWallet.FlatAppearance.BorderSize = 0;
            this.btnWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWallet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWallet.ForeColor = System.Drawing.Color.White;
            this.btnWallet.Location = new System.Drawing.Point(-36, 272);
            this.btnWallet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWallet.Name = "btnWallet";
            this.btnWallet.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnWallet.Size = new System.Drawing.Size(242, 74);
            this.btnWallet.TabIndex = 3;
            this.btnWallet.Text = "📝 Wallet Report";
            this.btnWallet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWallet.UseVisualStyleBackColor = false;
            this.btnWallet.Click += new System.EventHandler(this.btnWallet_Click);
            // 
            // pnlSidebarWallet
            // 
            this.pnlSidebarWallet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(78)))), ((int)(((byte)(65)))));
            this.pnlSidebarWallet.Controls.Add(this.picLogo);
            this.pnlSidebarWallet.Controls.Add(this.btnDasboard);
            this.pnlSidebarWallet.Controls.Add(this.btnFeedback);
            this.pnlSidebarWallet.Controls.Add(this.btnWallet);
            this.pnlSidebarWallet.Controls.Add(this.btnUpdProf);
            this.pnlSidebarWallet.Controls.Add(this.btnLogout);
            this.pnlSidebarWallet.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebarWallet.Location = new System.Drawing.Point(0, 62);
            this.pnlSidebarWallet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSidebarWallet.Name = "pnlSidebarWallet";
            this.pnlSidebarWallet.Size = new System.Drawing.Size(210, 670);
            this.pnlSidebarWallet.TabIndex = 15;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.ErrorImage = null;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.InitialImage = null;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(205, 132);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 8;
            this.picLogo.TabStop = false;
            // 
            // tlpnlOuterDetailsWallet
            // 
            this.tlpnlOuterDetailsWallet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpnlOuterDetailsWallet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tlpnlOuterDetailsWallet.ColumnCount = 2;
            this.tlpnlOuterDetailsWallet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpnlOuterDetailsWallet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpnlOuterDetailsWallet.Controls.Add(this.tlpnlInnerWallet, 0, 0);
            this.tlpnlOuterDetailsWallet.Controls.Add(this.pnlWalletFilterReset, 1, 0);
            this.tlpnlOuterDetailsWallet.Location = new System.Drawing.Point(217, 62);
            this.tlpnlOuterDetailsWallet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpnlOuterDetailsWallet.Name = "tlpnlOuterDetailsWallet";
            this.tlpnlOuterDetailsWallet.RowCount = 1;
            this.tlpnlOuterDetailsWallet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnlOuterDetailsWallet.Size = new System.Drawing.Size(1084, 82);
            this.tlpnlOuterDetailsWallet.TabIndex = 17;
            // 
            // tlpnlInnerWallet
            // 
            this.tlpnlInnerWallet.ColumnCount = 2;
            this.tlpnlInnerWallet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpnlInnerWallet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpnlInnerWallet.Controls.Add(this.lblCustomer, 0, 0);
            this.tlpnlInnerWallet.Controls.Add(this.lblMonthYear, 1, 0);
            this.tlpnlInnerWallet.Controls.Add(this.cmbUser, 0, 1);
            this.tlpnlInnerWallet.Controls.Add(this.dtpDate, 1, 1);
            this.tlpnlInnerWallet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpnlInnerWallet.Location = new System.Drawing.Point(9, 9);
            this.tlpnlInnerWallet.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.tlpnlInnerWallet.Name = "tlpnlInnerWallet";
            this.tlpnlInnerWallet.RowCount = 2;
            this.tlpnlInnerWallet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpnlInnerWallet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpnlInnerWallet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpnlInnerWallet.Size = new System.Drawing.Size(740, 64);
            this.tlpnlInnerWallet.TabIndex = 0;
            // 
            // pnlWalletFilterReset
            // 
            this.pnlWalletFilterReset.Controls.Add(this.btnReset);
            this.pnlWalletFilterReset.Controls.Add(this.btnFilter);
            this.pnlWalletFilterReset.Location = new System.Drawing.Point(762, 4);
            this.pnlWalletFilterReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlWalletFilterReset.Name = "pnlWalletFilterReset";
            this.pnlWalletFilterReset.Size = new System.Drawing.Size(316, 74);
            this.pnlWalletFilterReset.TabIndex = 1;
            // 
            // tlpnlWalletCards
            // 
            this.tlpnlWalletCards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpnlWalletCards.BackColor = System.Drawing.Color.Ivory;
            this.tlpnlWalletCards.ColumnCount = 4;
            this.tlpnlWalletCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlWalletCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlWalletCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlWalletCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlWalletCards.Controls.Add(this.pnlTotalTransactionCard, 3, 0);
            this.tlpnlWalletCards.Controls.Add(this.pnlTotalTopupCard, 0, 0);
            this.tlpnlWalletCards.Controls.Add(this.pnlNetBalanceCard, 2, 0);
            this.tlpnlWalletCards.Controls.Add(this.pnlTotalUseCard, 1, 0);
            this.tlpnlWalletCards.Location = new System.Drawing.Point(217, 146);
            this.tlpnlWalletCards.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpnlWalletCards.Name = "tlpnlWalletCards";
            this.tlpnlWalletCards.RowCount = 1;
            this.tlpnlWalletCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnlWalletCards.Size = new System.Drawing.Size(1086, 142);
            this.tlpnlWalletCards.TabIndex = 0;
            // 
            // pnlWalletTrans
            // 
            this.pnlWalletTrans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWalletTrans.Controls.Add(this.dgvWalletTrans);
            this.pnlWalletTrans.Location = new System.Drawing.Point(217, 340);
            this.pnlWalletTrans.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlWalletTrans.Name = "pnlWalletTrans";
            this.pnlWalletTrans.Size = new System.Drawing.Size(1095, 393);
            this.pnlWalletTrans.TabIndex = 16;
            // 
            // WalletReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1312, 732);
            this.Controls.Add(this.tlpnlWalletCards);
            this.Controls.Add(this.tlpnlOuterDetailsWallet);
            this.Controls.Add(this.picTransactionHistory);
            this.Controls.Add(this.pnlWalletTrans);
            this.Controls.Add(this.lblTransactionHistory);
            this.Controls.Add(this.pnlSidebarWallet);
            this.Controls.Add(this.pnlWalletReportHdr);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WalletReport";
            this.Text = "Wallet transaction report";
            this.Load += new System.EventHandler(this.WalletReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWalletTrans)).EndInit();
            this.pnlWalletReportHdr.ResumeLayout(false);
            this.pnlWalletReportHdr.PerformLayout();
            this.pnlTotalTopupCard.ResumeLayout(false);
            this.pnlTotalTopupCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTopUp)).EndInit();
            this.pnlNetBalanceCard.ResumeLayout(false);
            this.pnlNetBalanceCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBalance)).EndInit();
            this.pnlTotalTransactionCard.ResumeLayout(false);
            this.pnlTotalTransactionCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTransaction)).EndInit();
            this.pnlTotalUseCard.ResumeLayout(false);
            this.pnlTotalUseCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTransactionHistory)).EndInit();
            this.pnlSidebarWallet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.tlpnlOuterDetailsWallet.ResumeLayout(false);
            this.tlpnlInnerWallet.ResumeLayout(false);
            this.tlpnlInnerWallet.PerformLayout();
            this.pnlWalletFilterReset.ResumeLayout(false);
            this.tlpnlWalletCards.ResumeLayout(false);
            this.pnlWalletTrans.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvWalletTrans;
        private System.Windows.Forms.Label lblMonthYear;
        private System.Windows.Forms.Panel pnlWalletReportHdr;
        private System.Windows.Forms.Label lblHeadingWalletTransaction;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblWalletSubtitle;
        private System.Windows.Forms.Label lblTotalTopup;
        private System.Windows.Forms.Label lblTotalUse;
        private System.Windows.Forms.Panel pnlTotalTransactionCard;
        private System.Windows.Forms.Panel pnlNetBalanceCard;
        private System.Windows.Forms.Panel pnlTotalUseCard;
        private System.Windows.Forms.Panel pnlTotalTopupCard;
        private System.Windows.Forms.Label lblNetBalance;
        private System.Windows.Forms.Label lblTotalTransaction;
        private System.Windows.Forms.Label lblTtlTransactionNo;
        private System.Windows.Forms.Label lblTtlTopupNo;
        private System.Windows.Forms.Label lblTtlUsageNo;
        private System.Windows.Forms.Label lblNetBalanceNo;
        private System.Windows.Forms.PictureBox picTopUp;
        private System.Windows.Forms.PictureBox picBalance;
        private System.Windows.Forms.PictureBox picUsage;
        private System.Windows.Forms.PictureBox picTransaction;
        private System.Windows.Forms.PictureBox picTransactionHistory;
        private System.Windows.Forms.Label lblTransactionHistory;
        private System.Windows.Forms.Button btnUpdProf;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnWallet;
        private System.Windows.Forms.Button btnDasboard;
        private System.Windows.Forms.Panel pnlSidebarWallet;
        private System.Windows.Forms.TableLayoutPanel tlpnlOuterDetailsWallet;
        private System.Windows.Forms.TableLayoutPanel tlpnlInnerWallet;
        private System.Windows.Forms.Panel pnlWalletFilterReset;
        private System.Windows.Forms.TableLayoutPanel tlpnlWalletCards;
        private System.Windows.Forms.Panel pnlWalletTrans;
        private System.Windows.Forms.PictureBox picLogo;
    }
}
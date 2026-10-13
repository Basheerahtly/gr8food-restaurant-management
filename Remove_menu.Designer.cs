namespace CHEF
{
    partial class Remove_menu
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblRemove1 = new System.Windows.Forms.Label();
            this.pnlRemove = new System.Windows.Forms.Panel();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblRemove = new System.Windows.Forms.Label();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picBoxWarning = new System.Windows.Forms.PictureBox();
            this.pnlRemove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.IndianRed;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(513, 12);
            this.pnlTop.TabIndex = 0;
            // 
            // lblRemove1
            // 
            this.lblRemove1.AutoSize = true;
            this.lblRemove1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemove1.Location = new System.Drawing.Point(109, 154);
            this.lblRemove1.Name = "lblRemove1";
            this.lblRemove1.Size = new System.Drawing.Size(309, 32);
            this.lblRemove1.TabIndex = 2;
            this.lblRemove1.Text = "Remove Menu Item?";
            // 
            // pnlRemove
            // 
            this.pnlRemove.BackColor = System.Drawing.Color.White;
            this.pnlRemove.Controls.Add(this.lblWarning);
            this.pnlRemove.Controls.Add(this.lblRemove);
            this.pnlRemove.Location = new System.Drawing.Point(94, 211);
            this.pnlRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlRemove.Name = "pnlRemove";
            this.pnlRemove.Size = new System.Drawing.Size(308, 125);
            this.pnlRemove.TabIndex = 3;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblWarning.Location = new System.Drawing.Point(45, 91);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(253, 19);
            this.lblWarning.TabIndex = 1;
            this.lblWarning.Text = "THIS ACTION CANNOT BE UNDONE";
            // 
            // lblRemove
            // 
            this.lblRemove.AutoSize = true;
            this.lblRemove.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemove.Location = new System.Drawing.Point(16, 21);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(318, 50);
            this.lblRemove.TabIndex = 0;
            this.lblRemove.Text = "Are you sure you want to remove \r\nthe selected item from menu?";
            this.lblRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.IndianRed;
            this.pnlSide.Location = new System.Drawing.Point(94, 211);
            this.pnlSide.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(11, 125);
            this.pnlSide.TabIndex = 4;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(115, 364);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(258, 44);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "🗑 Remove Item";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(143, 415);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(186, 44);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Keep Item";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picBoxWarning
            // 
            this.picBoxWarning.Image = global::assignment.Properties.Resources._331_3312690_warning_icon_hd_png_download;
            this.picBoxWarning.Location = new System.Drawing.Point(222, 75);
            this.picBoxWarning.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBoxWarning.Name = "picBoxWarning";
            this.picBoxWarning.Size = new System.Drawing.Size(47, 62);
            this.picBoxWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxWarning.TabIndex = 1;
            this.picBoxWarning.TabStop = false;
            // 
            // Remove_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 492);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.pnlSide);
            this.Controls.Add(this.pnlRemove);
            this.Controls.Add(this.lblRemove1);
            this.Controls.Add(this.picBoxWarning);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Remove_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove_menu";
            this.Load += new System.EventHandler(this.Remove_menu_Load);
            this.pnlRemove.ResumeLayout(false);
            this.pnlRemove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWarning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox picBoxWarning;
        private System.Windows.Forms.Label lblRemove1;
        private System.Windows.Forms.Panel pnlRemove;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblRemove;
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCancel;
    }
}
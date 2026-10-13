namespace Gr8FoodSystem_Final
{
    partial class Feedback
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
            this.cmbOrders = new System.Windows.Forms.ComboBox();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.lblSelectOrder = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioNeutral = new System.Windows.Forms.RadioButton();
            this.radioBad = new System.Windows.Forms.RadioButton();
            this.radioGood = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbOrders
            // 
            this.cmbOrders.FormattingEnabled = true;
            this.cmbOrders.Location = new System.Drawing.Point(146, 60);
            this.cmbOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbOrders.Name = "cmbOrders";
            this.cmbOrders.Size = new System.Drawing.Size(180, 28);
            this.cmbOrders.TabIndex = 0;
            // 
            // txtFeedback
            // 
            this.txtFeedback.Location = new System.Drawing.Point(146, 177);
            this.txtFeedback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(598, 182);
            this.txtFeedback.TabIndex = 1;
            this.txtFeedback.TextChanged += new System.EventHandler(this.txtFeedback_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Crimson;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(146, 503);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(210, 69);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.Location = new System.Drawing.Point(141, 129);
            this.lblFeedback.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(188, 28);
            this.lblFeedback.TabIndex = 5;
            this.lblFeedback.Text = "Feedback Message";
            // 
            // lblSelectOrder
            // 
            this.lblSelectOrder.AutoSize = true;
            this.lblSelectOrder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectOrder.Location = new System.Drawing.Point(141, 14);
            this.lblSelectOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectOrder.Name = "lblSelectOrder";
            this.lblSelectOrder.Size = new System.Drawing.Size(129, 28);
            this.lblSelectOrder.TabIndex = 6;
            this.lblSelectOrder.Text = "Select Order";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioNeutral);
            this.groupBox1.Controls.Add(this.radioBad);
            this.groupBox1.Controls.Add(this.radioGood);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(146, 397);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(600, 83);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rating";
            // 
            // radioNeutral
            // 
            this.radioNeutral.AutoSize = true;
            this.radioNeutral.Location = new System.Drawing.Point(448, 37);
            this.radioNeutral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioNeutral.Name = "radioNeutral";
            this.radioNeutral.Size = new System.Drawing.Size(120, 35);
            this.radioNeutral.TabIndex = 2;
            this.radioNeutral.TabStop = true;
            this.radioNeutral.Text = "Neutral\r\n";
            this.radioNeutral.UseVisualStyleBackColor = true;
            // 
            // radioBad
            // 
            this.radioBad.AutoSize = true;
            this.radioBad.Location = new System.Drawing.Point(243, 37);
            this.radioBad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioBad.Name = "radioBad";
            this.radioBad.Size = new System.Drawing.Size(80, 35);
            this.radioBad.TabIndex = 1;
            this.radioBad.TabStop = true;
            this.radioBad.Text = "Bad\r\n";
            this.radioBad.UseVisualStyleBackColor = true;
            this.radioBad.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioGood
            // 
            this.radioGood.AutoSize = true;
            this.radioGood.Location = new System.Drawing.Point(9, 37);
            this.radioGood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioGood.Name = "radioGood";
            this.radioGood.Size = new System.Drawing.Size(97, 35);
            this.radioGood.TabIndex = 0;
            this.radioGood.TabStop = true;
            this.radioGood.Text = "Good\r\n";
            this.radioGood.UseVisualStyleBackColor = true;
            this.radioGood.CheckedChanged += new System.EventHandler(this.radioGood_CheckedChanged);
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSelectOrder);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.cmbOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Feedback";
            this.Text = "Select Order";
            this.Load += new System.EventHandler(this.Feedback_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOrders;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label lblSelectOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBad;
        private System.Windows.Forms.RadioButton radioGood;
        private System.Windows.Forms.RadioButton radioNeutral;
    }
}
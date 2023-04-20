
namespace NBA_Tickets_Retail
{
    partial class frmReturnSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReturnSale));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRTback = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpSaleDetails = new System.Windows.Forms.GroupBox();
            this.txtSalesID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotSales = new System.Windows.Forms.TextBox();
            this.dtPickSalesDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMatchID = new System.Windows.Forms.TextBox();
            this.txtSeats = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dgvSale = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpSaleDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRTback
            // 
            this.btnRTback.BackColor = System.Drawing.SystemColors.Menu;
            this.btnRTback.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRTback.Location = new System.Drawing.Point(1, 2);
            this.btnRTback.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRTback.Name = "btnRTback";
            this.btnRTback.Size = new System.Drawing.Size(43, 21);
            this.btnRTback.TabIndex = 17;
            this.btnRTback.TabStop = false;
            this.btnRTback.Text = "Back";
            this.btnRTback.UseVisualStyleBackColor = false;
            this.btnRTback.Click += new System.EventHandler(this.btnRTback_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Imprint MT Shadow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 32);
            this.label6.TabIndex = 23;
            this.label6.Text = "Return Sale";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(696, 341);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // grpSaleDetails
            // 
            this.grpSaleDetails.Controls.Add(this.txtSalesID);
            this.grpSaleDetails.Controls.Add(this.label1);
            this.grpSaleDetails.Controls.Add(this.txtName);
            this.grpSaleDetails.Controls.Add(this.txtEmail);
            this.grpSaleDetails.Controls.Add(this.label4);
            this.grpSaleDetails.Controls.Add(this.label3);
            this.grpSaleDetails.Controls.Add(this.txtTotSales);
            this.grpSaleDetails.Controls.Add(this.dtPickSalesDate);
            this.grpSaleDetails.Controls.Add(this.label9);
            this.grpSaleDetails.Controls.Add(this.label8);
            this.grpSaleDetails.Controls.Add(this.txtMatchID);
            this.grpSaleDetails.Controls.Add(this.txtSeats);
            this.grpSaleDetails.Controls.Add(this.label7);
            this.grpSaleDetails.Controls.Add(this.label2);
            this.grpSaleDetails.Controls.Add(this.btnReturn);
            this.grpSaleDetails.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSaleDetails.Location = new System.Drawing.Point(10, 243);
            this.grpSaleDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSaleDetails.Name = "grpSaleDetails";
            this.grpSaleDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSaleDetails.Size = new System.Drawing.Size(682, 174);
            this.grpSaleDetails.TabIndex = 35;
            this.grpSaleDetails.TabStop = false;
            this.grpSaleDetails.Text = "Sale details";
            this.grpSaleDetails.Visible = false;
            // 
            // txtSalesID
            // 
            this.txtSalesID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesID.Location = new System.Drawing.Point(104, 22);
            this.txtSalesID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSalesID.Name = "txtSalesID";
            this.txtSalesID.ReadOnly = true;
            this.txtSalesID.Size = new System.Drawing.Size(228, 27);
            this.txtSalesID.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 75;
            this.label1.Text = "Sales ID:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(104, 61);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(228, 27);
            this.txtName.TabIndex = 74;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(104, 98);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(228, 27);
            this.txtEmail.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 72;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 71;
            this.label3.Text = "Email:";
            // 
            // txtTotSales
            // 
            this.txtTotSales.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotSales.Location = new System.Drawing.Point(488, 61);
            this.txtTotSales.Name = "txtTotSales";
            this.txtTotSales.ReadOnly = true;
            this.txtTotSales.Size = new System.Drawing.Size(176, 27);
            this.txtTotSales.TabIndex = 70;
            // 
            // dtPickSalesDate
            // 
            this.dtPickSalesDate.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickSalesDate.Enabled = false;
            this.dtPickSalesDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickSalesDate.Location = new System.Drawing.Point(104, 135);
            this.dtPickSalesDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtPickSalesDate.Name = "dtPickSalesDate";
            this.dtPickSalesDate.Size = new System.Drawing.Size(241, 27);
            this.dtPickSalesDate.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(8, 135);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 23);
            this.label9.TabIndex = 68;
            this.label9.Text = "Sales Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(385, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 23);
            this.label8.TabIndex = 67;
            this.label8.Text = "Total Sales:";
            // 
            // txtMatchID
            // 
            this.txtMatchID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatchID.Location = new System.Drawing.Point(488, 22);
            this.txtMatchID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMatchID.Name = "txtMatchID";
            this.txtMatchID.ReadOnly = true;
            this.txtMatchID.Size = new System.Drawing.Size(176, 27);
            this.txtMatchID.TabIndex = 66;
            // 
            // txtSeats
            // 
            this.txtSeats.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeats.Location = new System.Drawing.Point(488, 100);
            this.txtSeats.Name = "txtSeats";
            this.txtSeats.ReadOnly = true;
            this.txtSeats.Size = new System.Drawing.Size(176, 27);
            this.txtSeats.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(385, 99);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 23);
            this.label7.TabIndex = 63;
            this.label7.Text = "Seats:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(385, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 61;
            this.label2.Text = "Match ID:";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReturn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReturn.Location = new System.Drawing.Point(542, 135);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(85, 29);
            this.btnReturn.TabIndex = 60;
            this.btnReturn.Text = "RETURN";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dgvSale
            // 
            this.dgvSale.AllowUserToAddRows = false;
            this.dgvSale.AllowUserToDeleteRows = false;
            this.dgvSale.AllowUserToResizeColumns = false;
            this.dgvSale.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSale.Location = new System.Drawing.Point(10, 63);
            this.dgvSale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSale.Name = "dgvSale";
            this.dgvSale.ReadOnly = true;
            this.dgvSale.RowHeadersVisible = false;
            this.dgvSale.RowHeadersWidth = 51;
            this.dgvSale.RowTemplate.Height = 24;
            this.dgvSale.Size = new System.Drawing.Size(766, 164);
            this.dgvSale.TabIndex = 36;
            this.dgvSale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSale_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvSale);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.grpSaleDetails);
            this.panel1.Location = new System.Drawing.Point(105, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 424);
            this.panel1.TabIndex = 37;
            // 
            // frmReturnSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::NBA_Tickets_Retail.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1015, 557);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRTback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmReturnSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Tickets Retail - [Tickets] - [Return Tickets]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReturnTickets_FormClosed);
            this.Load += new System.EventHandler(this.frmReturnTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpSaleDetails.ResumeLayout(false);
            this.grpSaleDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRTback;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpSaleDetails;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotSales;
        private System.Windows.Forms.DateTimePicker dtPickSalesDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMatchID;
        private System.Windows.Forms.TextBox txtSeats;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dgvSale;
        private System.Windows.Forms.TextBox txtSalesID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

namespace NBA_Tickets_Retail
{
    partial class frmManageSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageSales));
            this.btnMSback = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.assignedID = new System.Windows.Forms.Label();
            this.grpSales = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtPickSalesDate = new System.Windows.Forms.DateTimePicker();
            this.txtSeatSold = new System.Windows.Forms.TextBox();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.cboManageSales = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpSales.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMSback
            // 
            this.btnMSback.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMSback.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMSback.Location = new System.Drawing.Point(3, 2);
            this.btnMSback.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMSback.Name = "btnMSback";
            this.btnMSback.Size = new System.Drawing.Size(57, 26);
            this.btnMSback.TabIndex = 18;
            this.btnMSback.Text = "Back";
            this.btnMSback.UseVisualStyleBackColor = false;
            this.btnMSback.Click += new System.EventHandler(this.btnMSback_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(668, 320);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 39);
            this.label1.TabIndex = 20;
            this.label1.Text = "Manage Sales";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "Seat Sold:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Type Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "Sale Ticket ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Sales Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 29);
            this.label6.TabIndex = 27;
            this.label6.Text = "Sales:";
            // 
            // assignedID
            // 
            this.assignedID.AutoSize = true;
            this.assignedID.BackColor = System.Drawing.SystemColors.Control;
            this.assignedID.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignedID.Location = new System.Drawing.Point(215, 106);
            this.assignedID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.assignedID.Name = "assignedID";
            this.assignedID.Size = new System.Drawing.Size(25, 29);
            this.assignedID.TabIndex = 28;
            this.assignedID.Text = "1";
            // 
            // grpSales
            // 
            this.grpSales.Controls.Add(this.btnAdd);
            this.grpSales.Controls.Add(this.dtPickSalesDate);
            this.grpSales.Controls.Add(this.txtSeatSold);
            this.grpSales.Controls.Add(this.txtSales);
            this.grpSales.Controls.Add(this.label6);
            this.grpSales.Controls.Add(this.label4);
            this.grpSales.Controls.Add(this.label5);
            this.grpSales.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSales.Location = new System.Drawing.Point(53, 161);
            this.grpSales.Margin = new System.Windows.Forms.Padding(4);
            this.grpSales.Name = "grpSales";
            this.grpSales.Padding = new System.Windows.Forms.Padding(4);
            this.grpSales.Size = new System.Drawing.Size(536, 251);
            this.grpSales.TabIndex = 29;
            this.grpSales.TabStop = false;
            this.grpSales.Text = "Seat Type Sales details";
            this.grpSales.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(433, 207);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 34);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtPickSalesDate
            // 
            this.dtPickSalesDate.Location = new System.Drawing.Point(183, 123);
            this.dtPickSalesDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtPickSalesDate.Name = "dtPickSalesDate";
            this.dtPickSalesDate.Size = new System.Drawing.Size(324, 32);
            this.dtPickSalesDate.TabIndex = 2;
            // 
            // txtSeatSold
            // 
            this.txtSeatSold.Location = new System.Drawing.Point(183, 208);
            this.txtSeatSold.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeatSold.Name = "txtSeatSold";
            this.txtSeatSold.Size = new System.Drawing.Size(101, 32);
            this.txtSeatSold.TabIndex = 3;
            // 
            // txtSales
            // 
            this.txtSales.Location = new System.Drawing.Point(183, 46);
            this.txtSales.Margin = new System.Windows.Forms.Padding(4);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(147, 32);
            this.txtSales.TabIndex = 1;
            // 
            // cboManageSales
            // 
            this.cboManageSales.BackColor = System.Drawing.SystemColors.Menu;
            this.cboManageSales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboManageSales.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboManageSales.FormattingEnabled = true;
            this.cboManageSales.Location = new System.Drawing.Point(472, 107);
            this.cboManageSales.Margin = new System.Windows.Forms.Padding(4);
            this.cboManageSales.Name = "cboManageSales";
            this.cboManageSales.Size = new System.Drawing.Size(180, 32);
            this.cboManageSales.TabIndex = 0;
            this.cboManageSales.SelectedIndexChanged += new System.EventHandler(this.cboManageSales_SelectedIndexChanged);
            // 
            // frmManageSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(840, 446);
            this.Controls.Add(this.cboManageSales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpSales);
            this.Controls.Add(this.assignedID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMSback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmManageSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Tickets Retail - [Matches] - [Manage Sales]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmManageSales_FormClosed);
            this.Load += new System.EventHandler(this.frmManageSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpSales.ResumeLayout(false);
            this.grpSales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMSback;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label assignedID;
        private System.Windows.Forms.GroupBox grpSales;
        private System.Windows.Forms.ComboBox cboManageSales;
        private System.Windows.Forms.TextBox txtSeatSold;
        private System.Windows.Forms.TextBox txtSales;
        private System.Windows.Forms.DateTimePicker dtPickSalesDate;
        private System.Windows.Forms.Button btnAdd;
    }
}
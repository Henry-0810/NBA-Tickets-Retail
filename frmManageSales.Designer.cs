
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
            this.btnMSback.Location = new System.Drawing.Point(2, 2);
            this.btnMSback.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMSback.Name = "btnMSback";
            this.btnMSback.Size = new System.Drawing.Size(43, 21);
            this.btnMSback.TabIndex = 18;
            this.btnMSback.Text = "Back";
            this.btnMSback.UseVisualStyleBackColor = false;
            this.btnMSback.Click += new System.EventHandler(this.btnMSback_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(501, 260);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Manage Sales";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Seat Sold:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Type Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Sale ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "Sales Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Sales:";
            // 
            // assignedID
            // 
            this.assignedID.AutoSize = true;
            this.assignedID.BackColor = System.Drawing.SystemColors.Control;
            this.assignedID.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignedID.Location = new System.Drawing.Point(133, 87);
            this.assignedID.Name = "assignedID";
            this.assignedID.Size = new System.Drawing.Size(20, 23);
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
            this.grpSales.Location = new System.Drawing.Point(40, 131);
            this.grpSales.Name = "grpSales";
            this.grpSales.Size = new System.Drawing.Size(402, 204);
            this.grpSales.TabIndex = 29;
            this.grpSales.TabStop = false;
            this.grpSales.Text = "Seat Type Sales details";
            this.grpSales.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(325, 168);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 28);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtPickSalesDate
            // 
            this.dtPickSalesDate.Location = new System.Drawing.Point(137, 100);
            this.dtPickSalesDate.Name = "dtPickSalesDate";
            this.dtPickSalesDate.Size = new System.Drawing.Size(244, 27);
            this.dtPickSalesDate.TabIndex = 2;
            // 
            // txtSeatSold
            // 
            this.txtSeatSold.Location = new System.Drawing.Point(137, 169);
            this.txtSeatSold.Name = "txtSeatSold";
            this.txtSeatSold.Size = new System.Drawing.Size(77, 27);
            this.txtSeatSold.TabIndex = 3;
            // 
            // txtSales
            // 
            this.txtSales.Location = new System.Drawing.Point(137, 37);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(111, 27);
            this.txtSales.TabIndex = 1;
            // 
            // cboManageSales
            // 
            this.cboManageSales.BackColor = System.Drawing.SystemColors.Menu;
            this.cboManageSales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboManageSales.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboManageSales.FormattingEnabled = true;
            this.cboManageSales.Location = new System.Drawing.Point(354, 87);
            this.cboManageSales.Name = "cboManageSales";
            this.cboManageSales.Size = new System.Drawing.Size(136, 27);
            this.cboManageSales.TabIndex = 0;
            this.cboManageSales.SelectedIndexChanged += new System.EventHandler(this.cboManageSales_SelectedIndexChanged);
            // 
            // frmManageSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 362);
            this.Controls.Add(this.cboManageSales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpSales);
            this.Controls.Add(this.assignedID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMSback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageSales";
            this.Text = "NBA Tickets Retail - [Matches] - [Manage Sales]";
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
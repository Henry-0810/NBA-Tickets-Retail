
namespace NBA_Tickets_Retail
{
    partial class frmProcessSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcessSales));
            this.btnPSback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMatches = new System.Windows.Forms.ComboBox();
            this.cboSeatType = new System.Windows.Forms.ComboBox();
            this.lblSeatType = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numberOfSeats = new System.Windows.Forms.NumericUpDown();
            this.grpBoxCart = new System.Windows.Forms.GroupBox();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.TypeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSeats)).BeginInit();
            this.grpBoxCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPSback
            // 
            this.btnPSback.BackColor = System.Drawing.SystemColors.Menu;
            this.btnPSback.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSback.Location = new System.Drawing.Point(3, 2);
            this.btnPSback.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPSback.Name = "btnPSback";
            this.btnPSback.Size = new System.Drawing.Size(57, 26);
            this.btnPSback.TabIndex = 18;
            this.btnPSback.Text = "Back";
            this.btnPSback.UseVisualStyleBackColor = false;
            this.btnPSback.Click += new System.EventHandler(this.btnPSback_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Matches:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(892, 464);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProcess.Enabled = false;
            this.btnProcess.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProcess.Location = new System.Drawing.Point(148, 394);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(113, 36);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "ADD";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(36, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 39);
            this.label6.TabIndex = 22;
            this.label6.Text = "Process Sales";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(37, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 29);
            this.label5.TabIndex = 31;
            this.label5.Text = "Choose seat type:";
            // 
            // cboMatches
            // 
            this.cboMatches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMatches.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMatches.FormattingEnabled = true;
            this.cboMatches.Location = new System.Drawing.Point(163, 219);
            this.cboMatches.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMatches.Name = "cboMatches";
            this.cboMatches.Size = new System.Drawing.Size(276, 32);
            this.cboMatches.TabIndex = 2;
            this.cboMatches.SelectedIndexChanged += new System.EventHandler(this.CboMatches_SelectedIndexChanged);
            // 
            // cboSeatType
            // 
            this.cboSeatType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSeatType.Enabled = false;
            this.cboSeatType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSeatType.FormattingEnabled = true;
            this.cboSeatType.Location = new System.Drawing.Point(237, 270);
            this.cboSeatType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSeatType.Name = "cboSeatType";
            this.cboSeatType.Size = new System.Drawing.Size(108, 32);
            this.cboSeatType.TabIndex = 3;
            this.cboSeatType.SelectedIndexChanged += new System.EventHandler(this.CboSeatTypes_SelectedIndexChanged);
            // 
            // lblSeatType
            // 
            this.lblSeatType.AutoSize = true;
            this.lblSeatType.BackColor = System.Drawing.Color.Transparent;
            this.lblSeatType.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeatType.ForeColor = System.Drawing.Color.Black;
            this.lblSeatType.Location = new System.Drawing.Point(39, 321);
            this.lblSeatType.Name = "lblSeatType";
            this.lblSeatType.Size = new System.Drawing.Size(125, 29);
            this.lblSeatType.TabIndex = 36;
            this.lblSeatType.Text = "Seat Type - ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(37, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 29);
            this.label8.TabIndex = 43;
            this.label8.Text = "E-mail:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(37, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 29);
            this.label9.TabIndex = 44;
            this.label9.Text = "Name:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(127, 167);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.MaxLength = 28888;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(312, 32);
            this.txtEmail.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(127, 114);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.MaxLength = 28888;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(312, 32);
            this.txtName.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.DarkGray;
            this.label10.Location = new System.Drawing.Point(445, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 45;
            this.label10.Text = "(optional)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.DarkGray;
            this.label11.Location = new System.Drawing.Point(445, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 46;
            this.label11.Text = "(optional)";
            // 
            // numberOfSeats
            // 
            this.numberOfSeats.Enabled = false;
            this.numberOfSeats.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfSeats.Location = new System.Drawing.Point(237, 321);
            this.numberOfSeats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numberOfSeats.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numberOfSeats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfSeats.Name = "numberOfSeats";
            this.numberOfSeats.Size = new System.Drawing.Size(64, 32);
            this.numberOfSeats.TabIndex = 47;
            this.numberOfSeats.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grpBoxCart
            // 
            this.grpBoxCart.Controls.Add(this.dgvCart);
            this.grpBoxCart.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxCart.Location = new System.Drawing.Point(532, 58);
            this.grpBoxCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxCart.Name = "grpBoxCart";
            this.grpBoxCart.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxCart.Size = new System.Drawing.Size(421, 400);
            this.grpBoxCart.TabIndex = 48;
            this.grpBoxCart.TabStop = false;
            this.grpBoxCart.Text = "Cart";
            this.grpBoxCart.Visible = false;
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeCode,
            this.seatNum,
            this.Price});
            this.dgvCart.Location = new System.Drawing.Point(8, 57);
            this.dgvCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.Size = new System.Drawing.Size(405, 240);
            this.dgvCart.TabIndex = 0;
            // 
            // TypeCode
            // 
            this.TypeCode.HeaderText = "Seat Type";
            this.TypeCode.MinimumWidth = 6;
            this.TypeCode.Name = "TypeCode";
            this.TypeCode.Width = 125;
            // 
            // seatNum
            // 
            this.seatNum.HeaderText = "Seat Number";
            this.seatNum.MinimumWidth = 6;
            this.seatNum.Name = "seatNum";
            this.seatNum.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // frmProcessSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1024, 567);
            this.Controls.Add(this.grpBoxCart);
            this.Controls.Add(this.numberOfSeats);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSeatType);
            this.Controls.Add(this.cboSeatType);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboMatches);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPSback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProcessSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Tickets Retail - [Tickets] - [Process Sales]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmProcessSales_FormClosed);
            this.Load += new System.EventHandler(this.FrmProcessSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSeats)).EndInit();
            this.grpBoxCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPSback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMatches;
        private System.Windows.Forms.ComboBox cboSeatType;
        private System.Windows.Forms.Label lblSeatType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numberOfSeats;
        private System.Windows.Forms.GroupBox grpBoxCart;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}
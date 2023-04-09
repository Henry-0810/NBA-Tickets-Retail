
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.txtTotPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.TypeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancellation = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.label1.Location = new System.Drawing.Point(37, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Matches:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(900, 437);
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
            this.btnProcess.Location = new System.Drawing.Point(148, 437);
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
            this.label5.Location = new System.Drawing.Point(37, 300);
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
            this.cboMatches.Location = new System.Drawing.Point(158, 239);
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
            this.cboSeatType.Location = new System.Drawing.Point(237, 301);
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
            this.lblSeatType.Location = new System.Drawing.Point(39, 362);
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
            this.label8.Location = new System.Drawing.Point(37, 176);
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
            this.txtEmail.Location = new System.Drawing.Point(122, 177);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 28888;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(312, 32);
            this.txtEmail.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(122, 115);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
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
            this.label10.Location = new System.Drawing.Point(441, 126);
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
            this.label11.Location = new System.Drawing.Point(441, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 46;
            this.label11.Text = "(optional)";
            // 
            // numberOfSeats
            // 
            this.numberOfSeats.Enabled = false;
            this.numberOfSeats.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfSeats.Location = new System.Drawing.Point(237, 364);
            this.numberOfSeats.Margin = new System.Windows.Forms.Padding(4);
            this.numberOfSeats.Maximum = new decimal(new int[] {
            4,
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
            this.grpBoxCart.Controls.Add(this.btnCheckOut);
            this.grpBoxCart.Controls.Add(this.txtTotPrice);
            this.grpBoxCart.Controls.Add(this.label2);
            this.grpBoxCart.Controls.Add(this.dgvCart);
            this.grpBoxCart.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxCart.Location = new System.Drawing.Point(531, 58);
            this.grpBoxCart.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxCart.Name = "grpBoxCart";
            this.grpBoxCart.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxCart.Size = new System.Drawing.Size(485, 372);
            this.grpBoxCart.TabIndex = 48;
            this.grpBoxCart.TabStop = false;
            this.grpBoxCart.Text = "Cart";
            this.grpBoxCart.Visible = false;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheckOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCheckOut.Location = new System.Drawing.Point(354, 310);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(124, 36);
            this.btnCheckOut.TabIndex = 34;
            this.btnCheckOut.Text = "CHECKOUT";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // txtTotPrice
            // 
            this.txtTotPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotPrice.Location = new System.Drawing.Point(135, 313);
            this.txtTotPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotPrice.MaxLength = 28888;
            this.txtTotPrice.Name = "txtTotPrice";
            this.txtTotPrice.Size = new System.Drawing.Size(113, 32);
            this.txtTotPrice.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "Total Price:";
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeCode,
            this.seatNum,
            this.Price,
            this.Cancellation});
            this.dgvCart.Location = new System.Drawing.Point(8, 37);
            this.dgvCart.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.Size = new System.Drawing.Size(469, 255);
            this.dgvCart.TabIndex = 10;
            this.dgvCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellContentClick);
            // 
            // TypeCode
            // 
            this.TypeCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeCode.DefaultCellStyle = dataGridViewCellStyle2;
            this.TypeCode.FillWeight = 87.2514F;
            this.TypeCode.HeaderText = "Seat Type";
            this.TypeCode.MinimumWidth = 6;
            this.TypeCode.Name = "TypeCode";
            this.TypeCode.ReadOnly = true;
            // 
            // seatNum
            // 
            this.seatNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatNum.DefaultCellStyle = dataGridViewCellStyle3;
            this.seatNum.FillWeight = 130.9569F;
            this.seatNum.HeaderText = "Seat Number";
            this.seatNum.MinimumWidth = 6;
            this.seatNum.Name = "seatNum";
            this.seatNum.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Price.DefaultCellStyle = dataGridViewCellStyle4;
            this.Price.FillWeight = 106.9519F;
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Cancellation
            // 
            this.Cancellation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancellation.DefaultCellStyle = dataGridViewCellStyle5;
            this.Cancellation.FillWeight = 74.83984F;
            this.Cancellation.HeaderText = "Cancel";
            this.Cancellation.MinimumWidth = 6;
            this.Cancellation.Name = "Cancellation";
            this.Cancellation.ReadOnly = true;
            // 
            // frmProcessSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1029, 538);
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
            this.grpBoxCart.PerformLayout();
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
        private System.Windows.Forms.TextBox txtTotPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewButtonColumn Cancellation;
    }
}
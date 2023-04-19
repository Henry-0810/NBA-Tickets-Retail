namespace NBA_Tickets_Retail
{
    partial class frmAddSeatType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddSeatType));
            this.lblTypeCode = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtTypeCode = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnASTback = new System.Windows.Forms.Button();
            this.lblNumSeats = new System.Windows.Forms.Label();
            this.txtNumSeats = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTypeCode
            // 
            this.lblTypeCode.AutoSize = true;
            this.lblTypeCode.BackColor = System.Drawing.Color.Transparent;
            this.lblTypeCode.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeCode.ForeColor = System.Drawing.Color.Black;
            this.lblTypeCode.Location = new System.Drawing.Point(31, 72);
            this.lblTypeCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeCode.Name = "lblTypeCode";
            this.lblTypeCode.Size = new System.Drawing.Size(94, 23);
            this.lblTypeCode.TabIndex = 0;
            this.lblTypeCode.Text = "Type Code:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(31, 202);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 23);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblDesc.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.Black;
            this.lblDesc.Location = new System.Drawing.Point(31, 118);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(104, 23);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Description:";
            // 
            // txtTypeCode
            // 
            this.txtTypeCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtTypeCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeCode.Location = new System.Drawing.Point(219, 73);
            this.txtTypeCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTypeCode.MaxLength = 8;
            this.txtTypeCode.Name = "txtTypeCode";
            this.txtTypeCode.Size = new System.Drawing.Size(114, 27);
            this.txtTypeCode.TabIndex = 0;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(219, 202);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPrice.MaxLength = 7;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(65, 27);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.Text = "0.00";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(219, 118);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDescription.MaxLength = 50;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(250, 66);
            this.txtDescription.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(170, 302);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(374, 248);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Imprint MT Shadow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(29, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 32);
            this.label6.TabIndex = 16;
            this.label6.Text = "Add Seat Type";
            // 
            // btnASTback
            // 
            this.btnASTback.BackColor = System.Drawing.SystemColors.Menu;
            this.btnASTback.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnASTback.Location = new System.Drawing.Point(1, 2);
            this.btnASTback.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnASTback.Name = "btnASTback";
            this.btnASTback.Size = new System.Drawing.Size(57, 26);
            this.btnASTback.TabIndex = 20;
            this.btnASTback.Text = "Back";
            this.btnASTback.UseVisualStyleBackColor = false;
            this.btnASTback.Click += new System.EventHandler(this.btnASTback_Click_1);
            // 
            // lblNumSeats
            // 
            this.lblNumSeats.AutoSize = true;
            this.lblNumSeats.BackColor = System.Drawing.Color.Transparent;
            this.lblNumSeats.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSeats.ForeColor = System.Drawing.Color.Black;
            this.lblNumSeats.Location = new System.Drawing.Point(31, 247);
            this.lblNumSeats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumSeats.Name = "lblNumSeats";
            this.lblNumSeats.Size = new System.Drawing.Size(143, 23);
            this.lblNumSeats.TabIndex = 21;
            this.lblNumSeats.Text = "Number of Seats:";
            // 
            // txtNumSeats
            // 
            this.txtNumSeats.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumSeats.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumSeats.Location = new System.Drawing.Point(219, 247);
            this.txtNumSeats.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNumSeats.MaxLength = 8;
            this.txtNumSeats.Name = "txtNumSeats";
            this.txtNumSeats.Size = new System.Drawing.Size(65, 27);
            this.txtNumSeats.TabIndex = 22;
            this.txtNumSeats.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNumSeats);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtTypeCode);
            this.panel1.Controls.Add(this.lblTypeCode);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.lblDesc);
            this.panel1.Controls.Add(this.lblNumSeats);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Location = new System.Drawing.Point(184, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 353);
            this.panel1.TabIndex = 10;
            // 
            // frmAddSeatType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::NBA_Tickets_Retail.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(876, 557);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnASTback);
            this.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "frmAddSeatType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Tickets Retail - [Seat Type] - [Add Seat Type]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddSeatType_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTypeCode;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtTypeCode;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnASTback;
        private System.Windows.Forms.Label lblNumSeats;
        private System.Windows.Forms.TextBox txtNumSeats;
        private System.Windows.Forms.Panel panel1;
    }
}
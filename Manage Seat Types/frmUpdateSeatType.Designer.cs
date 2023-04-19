namespace NBA_Tickets_Retail
{
    partial class frmUpdateSeatType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateSeatType));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSeatTypes = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUSTback = new System.Windows.Forms.Button();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpType.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(31, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Update Seat Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose Seat Type:";
            // 
            // cboSeatTypes
            // 
            this.cboSeatTypes.BackColor = System.Drawing.SystemColors.Window;
            this.cboSeatTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSeatTypes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSeatTypes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboSeatTypes.FormattingEnabled = true;
            this.cboSeatTypes.Location = new System.Drawing.Point(173, 70);
            this.cboSeatTypes.Name = "cboSeatTypes";
            this.cboSeatTypes.Size = new System.Drawing.Size(219, 27);
            this.cboSeatTypes.TabIndex = 0;
            this.cboSeatTypes.SelectedIndexChanged += new System.EventHandler(this.cboSeatTypes_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(293, 302);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnUSTback
            // 
            this.btnUSTback.BackColor = System.Drawing.SystemColors.Menu;
            this.btnUSTback.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUSTback.Location = new System.Drawing.Point(0, 0);
            this.btnUSTback.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUSTback.Name = "btnUSTback";
            this.btnUSTback.Size = new System.Drawing.Size(43, 21);
            this.btnUSTback.TabIndex = 16;
            this.btnUSTback.Text = "Back";
            this.btnUSTback.UseVisualStyleBackColor = false;
            this.btnUSTback.Click += new System.EventHandler(this.btnUSTback_Click);
            // 
            // grpType
            // 
            this.grpType.BackColor = System.Drawing.Color.Transparent;
            this.grpType.Controls.Add(this.txtDescription);
            this.grpType.Controls.Add(this.label4);
            this.grpType.Controls.Add(this.txtPrice);
            this.grpType.Controls.Add(this.label3);
            this.grpType.Controls.Add(this.btnUpdate);
            this.grpType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpType.ForeColor = System.Drawing.Color.Black;
            this.grpType.Location = new System.Drawing.Point(22, 122);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(376, 167);
            this.grpType.TabIndex = 17;
            this.grpType.TabStop = false;
            this.grpType.Text = "Update Details";
            this.grpType.Visible = false;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescription.Location = new System.Drawing.Point(122, 26);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(248, 100);
            this.txtDescription.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description:";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(122, 134);
            this.txtPrice.MaxLength = 6;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(58, 27);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.Text = "0.00";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Location = new System.Drawing.Point(292, 132);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 29);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.grpType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboSeatTypes);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(228, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 402);
            this.panel1.TabIndex = 10;
            // 
            // frmUpdateSeatType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::NBA_Tickets_Retail.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(836, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUSTback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUpdateSeatType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Tickets Retail - [Seat Type] - [Update Seat Type]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUpdateSeatType_FormClosed);
            this.Load += new System.EventHandler(this.frmUpdateSeatType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSeatTypes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUSTback;
        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Panel panel1;
    }
}
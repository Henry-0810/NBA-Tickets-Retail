
namespace NBA_Tickets_Retail
{
    partial class frmCheckAvailability
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckAvailability));
            this.btnCAback = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboMatchID = new System.Windows.Forms.ComboBox();
            this.grpProcessSales = new System.Windows.Forms.GroupBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numSeatFrom = new System.Windows.Forms.NumericUpDown();
            this.numSeatTo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpProcessSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeatFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeatTo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCAback
            // 
            this.btnCAback.BackColor = System.Drawing.SystemColors.Menu;
            this.btnCAback.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCAback.Location = new System.Drawing.Point(1, 1);
            this.btnCAback.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCAback.Name = "btnCAback";
            this.btnCAback.Size = new System.Drawing.Size(57, 26);
            this.btnCAback.TabIndex = 18;
            this.btnCAback.Text = "Back";
            this.btnCAback.UseVisualStyleBackColor = false;
            this.btnCAback.Click += new System.EventHandler(this.btnCAback_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(33, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 39);
            this.label6.TabIndex = 24;
            this.label6.Text = "Check Availability";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(403, 272);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // cboMatchID
            // 
            this.cboMatchID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMatchID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMatchID.FormattingEnabled = true;
            this.cboMatchID.Location = new System.Drawing.Point(177, 101);
            this.cboMatchID.Name = "cboMatchID";
            this.cboMatchID.Size = new System.Drawing.Size(131, 32);
            this.cboMatchID.TabIndex = 0;
            this.cboMatchID.SelectedIndexChanged += new System.EventHandler(this.cboMatchID_SelectedIndexChanged);
            // 
            // grpProcessSales
            // 
            this.grpProcessSales.Controls.Add(this.btnCheck);
            this.grpProcessSales.Controls.Add(this.label2);
            this.grpProcessSales.Controls.Add(this.numSeatFrom);
            this.grpProcessSales.Controls.Add(this.numSeatTo);
            this.grpProcessSales.Controls.Add(this.label4);
            this.grpProcessSales.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProcessSales.Location = new System.Drawing.Point(40, 147);
            this.grpProcessSales.Name = "grpProcessSales";
            this.grpProcessSales.Size = new System.Drawing.Size(357, 210);
            this.grpProcessSales.TabIndex = 32;
            this.grpProcessSales.TabStop = false;
            this.grpProcessSales.Text = "Sales details";
            this.grpProcessSales.Visible = false;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheck.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCheck.Location = new System.Drawing.Point(104, 147);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(147, 36);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check Status";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Seat To:";
            // 
            // numSeatFrom
            // 
            this.numSeatFrom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSeatFrom.Location = new System.Drawing.Point(223, 32);
            this.numSeatFrom.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numSeatFrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSeatFrom.Name = "numSeatFrom";
            this.numSeatFrom.Size = new System.Drawing.Size(117, 32);
            this.numSeatFrom.TabIndex = 1;
            this.numSeatFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numSeatTo
            // 
            this.numSeatTo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSeatTo.Location = new System.Drawing.Point(223, 92);
            this.numSeatTo.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numSeatTo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSeatTo.Name = "numSeatTo";
            this.numSeatTo.Size = new System.Drawing.Size(117, 32);
            this.numSeatTo.TabIndex = 2;
            this.numSeatTo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(20, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "Seat From:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(35, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 29);
            this.label5.TabIndex = 31;
            this.label5.Text = "Match ID:";
            // 
            // frmCheckAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(532, 374);
            this.Controls.Add(this.cboMatchID);
            this.Controls.Add(this.grpProcessSales);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCAback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCheckAvailability";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Tickets Retail - [Tickets] - [Check Availability]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCheckAvailability_FormClosed);
            this.Load += new System.EventHandler(this.frmCheckAvailability_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpProcessSales.ResumeLayout(false);
            this.grpProcessSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeatFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeatTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCAback;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboMatchID;
        private System.Windows.Forms.GroupBox grpProcessSales;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSeatFrom;
        private System.Windows.Forms.NumericUpDown numSeatTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

namespace NBA_Tickets_Retail
{
    partial class frmReturnTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReturnTickets));
            this.btnRTback = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cboStatusRT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.grpReturn = new System.Windows.Forms.GroupBox();
            this.getSeatFrom = new System.Windows.Forms.Label();
            this.getSeatTo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSTID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpReturn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRTback
            // 
            this.btnRTback.BackColor = System.Drawing.SystemColors.Menu;
            this.btnRTback.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRTback.Location = new System.Drawing.Point(1, 2);
            this.btnRTback.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRTback.Name = "btnRTback";
            this.btnRTback.Size = new System.Drawing.Size(57, 26);
            this.btnRTback.TabIndex = 17;
            this.btnRTback.Text = "Back";
            this.btnRTback.UseVisualStyleBackColor = false;
            this.btnRTback.Click += new System.EventHandler(this.btnRTback_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(37, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 39);
            this.label6.TabIndex = 23;
            this.label6.Text = "Return Tickets";
            // 
            // cboStatusRT
            // 
            this.cboStatusRT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatusRT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatusRT.FormattingEnabled = true;
            this.cboStatusRT.Location = new System.Drawing.Point(182, 138);
            this.cboStatusRT.Name = "cboStatusRT";
            this.cboStatusRT.Size = new System.Drawing.Size(117, 32);
            this.cboStatusRT.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(35, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 32;
            this.label3.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(39, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 30;
            this.label1.Text = "Sale Ticket ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(362, 369);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReturn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReturn.Location = new System.Drawing.Point(330, 153);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(113, 36);
            this.btnReturn.TabIndex = 35;
            this.btnReturn.Text = "RETURN";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // grpReturn
            // 
            this.grpReturn.Controls.Add(this.getSeatFrom);
            this.grpReturn.Controls.Add(this.getSeatTo);
            this.grpReturn.Controls.Add(this.cboStatusRT);
            this.grpReturn.Controls.Add(this.btnReturn);
            this.grpReturn.Controls.Add(this.label2);
            this.grpReturn.Controls.Add(this.label3);
            this.grpReturn.Controls.Add(this.label4);
            this.grpReturn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReturn.Location = new System.Drawing.Point(21, 159);
            this.grpReturn.Name = "grpReturn";
            this.grpReturn.Size = new System.Drawing.Size(459, 204);
            this.grpReturn.TabIndex = 36;
            this.grpReturn.TabStop = false;
            this.grpReturn.Text = "Tickets details:";
            this.grpReturn.Visible = false;
            // 
            // getSeatFrom
            // 
            this.getSeatFrom.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getSeatFrom.Location = new System.Drawing.Point(177, 84);
            this.getSeatFrom.Name = "getSeatFrom";
            this.getSeatFrom.Size = new System.Drawing.Size(164, 32);
            this.getSeatFrom.TabIndex = 37;
            this.getSeatFrom.Text = "*getFromFile*";
            // 
            // getSeatTo
            // 
            this.getSeatTo.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getSeatTo.Location = new System.Drawing.Point(177, 30);
            this.getSeatTo.Name = "getSeatTo";
            this.getSeatTo.Size = new System.Drawing.Size(164, 32);
            this.getSeatTo.TabIndex = 36;
            this.getSeatTo.Text = "*getFromFile*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "Seat To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(35, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 29);
            this.label4.TabIndex = 33;
            this.label4.Text = "Seat From:";
            // 
            // cboSTID
            // 
            this.cboSTID.BackColor = System.Drawing.SystemColors.Window;
            this.cboSTID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSTID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSTID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboSTID.FormattingEnabled = true;
            this.cboSTID.Location = new System.Drawing.Point(213, 107);
            this.cboSTID.Margin = new System.Windows.Forms.Padding(4);
            this.cboSTID.Name = "cboSTID";
            this.cboSTID.Size = new System.Drawing.Size(149, 32);
            this.cboSTID.TabIndex = 0;
            this.cboSTID.SelectedIndexChanged += new System.EventHandler(this.cboSTID_SelectedIndexChanged);
            // 
            // frmReturnTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(491, 471);
            this.Controls.Add(this.cboSTID);
            this.Controls.Add(this.grpReturn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRTback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReturnTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Tickets Retail - [Tickets] - [Return Tickets]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReturnTickets_FormClosed);
            this.Load += new System.EventHandler(this.frmReturnTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpReturn.ResumeLayout(false);
            this.grpReturn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRTback;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboStatusRT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.GroupBox grpReturn;
        private System.Windows.Forms.ComboBox cboSTID;
        private System.Windows.Forms.Label getSeatFrom;
        private System.Windows.Forms.Label getSeatTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}
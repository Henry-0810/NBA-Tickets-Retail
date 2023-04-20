
namespace NBA_Tickets_Retail
{
    partial class frmScheduleMatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScheduleMatch));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSMback = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtPickMatchTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboAwayTeam = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatchTime = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Schedule Match";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(295, 290);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnSMback
            // 
            this.btnSMback.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSMback.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSMback.Location = new System.Drawing.Point(1, 0);
            this.btnSMback.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSMback.Name = "btnSMback";
            this.btnSMback.Size = new System.Drawing.Size(43, 21);
            this.btnSMback.TabIndex = 17;
            this.btnSMback.TabStop = false;
            this.btnSMback.Text = "Back";
            this.btnSMback.UseVisualStyleBackColor = false;
            this.btnSMback.Click += new System.EventHandler(this.btnSMback_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSchedule.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSchedule.Location = new System.Drawing.Point(114, 285);
            this.btnSchedule.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(113, 36);
            this.btnSchedule.TabIndex = 2;
            this.btnSchedule.Text = "SCHEDULE";
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Match Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Away Team:";
            // 
            // dtPickMatchTime
            // 
            this.dtPickMatchTime.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickMatchTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickMatchTime.Location = new System.Drawing.Point(150, 71);
            this.dtPickMatchTime.Name = "dtPickMatchTime";
            this.dtPickMatchTime.Size = new System.Drawing.Size(133, 27);
            this.dtPickMatchTime.TabIndex = 0;
            this.dtPickMatchTime.TabStop = false;
            this.dtPickMatchTime.Value = new System.DateTime(2022, 12, 9, 4, 12, 40, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Home Team:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Menu;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(146, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Golden State Warriors";
            // 
            // cboAwayTeam
            // 
            this.cboAwayTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAwayTeam.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAwayTeam.FormattingEnabled = true;
            this.cboAwayTeam.Location = new System.Drawing.Point(150, 218);
            this.cboAwayTeam.Name = "cboAwayTeam";
            this.cboAwayTeam.Size = new System.Drawing.Size(186, 27);
            this.cboAwayTeam.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 23);
            this.label5.TabIndex = 27;
            this.label5.Text = "Match Time:";
            // 
            // txtMatchTime
            // 
            this.txtMatchTime.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatchTime.Location = new System.Drawing.Point(150, 120);
            this.txtMatchTime.Mask = "00:00";
            this.txtMatchTime.Name = "txtMatchTime";
            this.txtMatchTime.Size = new System.Drawing.Size(133, 27);
            this.txtMatchTime.TabIndex = 28;
            this.txtMatchTime.Validating += new System.ComponentModel.CancelEventHandler(this.txtMatchTime_Validating);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMatchTime);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnSchedule);
            this.panel1.Controls.Add(this.cboAwayTeam);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtPickMatchTime);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(229, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 385);
            this.panel1.TabIndex = 29;
            // 
            // frmScheduleMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::NBA_Tickets_Retail.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(876, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSMback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmScheduleMatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Tickets Retail - [Matches] - [Schedule Match]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmScheduleMatch_FormClosed);
            this.Load += new System.EventHandler(this.frmScheduleMatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSMback;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtPickMatchTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboAwayTeam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtMatchTime;
        private System.Windows.Forms.Panel panel1;
    }
}
﻿
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMatchID = new System.Windows.Forms.ComboBox();
            this.cboNumSeats = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSeat1 = new System.Windows.Forms.TextBox();
            this.txtSeat2 = new System.Windows.Forms.TextBox();
            this.txtSeat3 = new System.Windows.Forms.TextBox();
            this.txtSeat4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPSback
            // 
            this.btnPSback.BackColor = System.Drawing.SystemColors.Menu;
            this.btnPSback.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSback.Location = new System.Drawing.Point(2, 2);
            this.btnPSback.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPSback.Name = "btnPSback";
            this.btnPSback.Size = new System.Drawing.Size(43, 21);
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
            this.label1.Location = new System.Drawing.Point(34, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Match ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(34, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Seat 1:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(313, 409);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 73);
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
            this.btnProcess.Location = new System.Drawing.Point(92, 396);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(85, 29);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "PROCESS";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(32, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 31);
            this.label6.TabIndex = 22;
            this.label6.Text = "Process Sales";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(34, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Choose number of seats:";
            // 
            // cboMatchID
            // 
            this.cboMatchID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMatchID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMatchID.FormattingEnabled = true;
            this.cboMatchID.Location = new System.Drawing.Point(140, 79);
            this.cboMatchID.Margin = new System.Windows.Forms.Padding(2);
            this.cboMatchID.Name = "cboMatchID";
            this.cboMatchID.Size = new System.Drawing.Size(99, 27);
            this.cboMatchID.TabIndex = 30;
            this.cboMatchID.SelectedIndexChanged += new System.EventHandler(this.cboMatchID_SelectedIndexChanged);
            // 
            // cboNumSeats
            // 
            this.cboNumSeats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNumSeats.Enabled = false;
            this.cboNumSeats.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNumSeats.FormattingEnabled = true;
            this.cboNumSeats.Location = new System.Drawing.Point(250, 127);
            this.cboNumSeats.Margin = new System.Windows.Forms.Padding(2);
            this.cboNumSeats.Name = "cboNumSeats";
            this.cboNumSeats.Size = new System.Drawing.Size(99, 27);
            this.cboNumSeats.TabIndex = 32;
            this.cboNumSeats.SelectedIndexChanged += new System.EventHandler(this.cboNumSeats_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(34, 331);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 36;
            this.label3.Text = "Seat 4:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(34, 282);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 37;
            this.label4.Text = "Seat 3:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(34, 233);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 23);
            this.label7.TabIndex = 38;
            this.label7.Text = "Seat 2:";
            // 
            // txtSeat1
            // 
            this.txtSeat1.Enabled = false;
            this.txtSeat1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeat1.Location = new System.Drawing.Point(115, 184);
            this.txtSeat1.Name = "txtSeat1";
            this.txtSeat1.Size = new System.Drawing.Size(100, 27);
            this.txtSeat1.TabIndex = 39;
            // 
            // txtSeat2
            // 
            this.txtSeat2.Enabled = false;
            this.txtSeat2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeat2.Location = new System.Drawing.Point(115, 233);
            this.txtSeat2.Name = "txtSeat2";
            this.txtSeat2.Size = new System.Drawing.Size(100, 27);
            this.txtSeat2.TabIndex = 40;
            // 
            // txtSeat3
            // 
            this.txtSeat3.Enabled = false;
            this.txtSeat3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeat3.Location = new System.Drawing.Point(115, 282);
            this.txtSeat3.Name = "txtSeat3";
            this.txtSeat3.Size = new System.Drawing.Size(100, 27);
            this.txtSeat3.TabIndex = 41;
            // 
            // txtSeat4
            // 
            this.txtSeat4.Enabled = false;
            this.txtSeat4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeat4.Location = new System.Drawing.Point(115, 331);
            this.txtSeat4.Name = "txtSeat4";
            this.txtSeat4.Size = new System.Drawing.Size(100, 27);
            this.txtSeat4.TabIndex = 42;
            // 
            // frmProcessSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(412, 493);
            this.Controls.Add(this.txtSeat4);
            this.Controls.Add(this.txtSeat3);
            this.Controls.Add(this.txtSeat2);
            this.Controls.Add(this.txtSeat1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboNumSeats);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboMatchID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPSback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmProcessSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Tickets Retail - [Tickets] - [Process Sales]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProcessSales_FormClosed);
            this.Load += new System.EventHandler(this.frmProcessSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPSback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMatchID;
        private System.Windows.Forms.ComboBox cboNumSeats;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSeat1;
        private System.Windows.Forms.TextBox txtSeat2;
        private System.Windows.Forms.TextBox txtSeat3;
        private System.Windows.Forms.TextBox txtSeat4;
    }
}
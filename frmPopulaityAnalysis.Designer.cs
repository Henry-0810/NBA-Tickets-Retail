
namespace NBA_Tickets_Retail
{
    partial class frmPopulaityAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPopulaityAnalysis));
            this.btnSAback = new System.Windows.Forms.Button();
            this.btnGraph = new System.Windows.Forms.Button();
            this.btnMostSeatsSold = new System.Windows.Forms.Button();
            this.btnCalcTotSales = new System.Windows.Forms.Button();
            this.grpSeats = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSeats = new System.Windows.Forms.TextBox();
            this.cboMatchID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpSeats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSAback
            // 
            this.btnSAback.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSAback.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAback.Location = new System.Drawing.Point(2, 2);
            this.btnSAback.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSAback.Name = "btnSAback";
            this.btnSAback.Size = new System.Drawing.Size(57, 26);
            this.btnSAback.TabIndex = 19;
            this.btnSAback.Text = "Back";
            this.btnSAback.UseVisualStyleBackColor = false;
            this.btnSAback.Click += new System.EventHandler(this.btnSAback_Click);
            // 
            // btnGraph
            // 
            this.btnGraph.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGraph.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraph.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGraph.Location = new System.Drawing.Point(243, 297);
            this.btnGraph.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(183, 37);
            this.btnGraph.TabIndex = 45;
            this.btnGraph.Text = "Show graph";
            this.btnGraph.UseVisualStyleBackColor = false;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // btnMostSeatsSold
            // 
            this.btnMostSeatsSold.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMostSeatsSold.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostSeatsSold.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMostSeatsSold.Location = new System.Drawing.Point(42, 297);
            this.btnMostSeatsSold.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMostSeatsSold.Name = "btnMostSeatsSold";
            this.btnMostSeatsSold.Size = new System.Drawing.Size(183, 37);
            this.btnMostSeatsSold.TabIndex = 44;
            this.btnMostSeatsSold.Text = "Most Seats sold";
            this.btnMostSeatsSold.UseVisualStyleBackColor = false;
            this.btnMostSeatsSold.Click += new System.EventHandler(this.btnMostSeatsSold_Click);
            // 
            // btnCalcTotSales
            // 
            this.btnCalcTotSales.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcTotSales.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcTotSales.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalcTotSales.Location = new System.Drawing.Point(332, 119);
            this.btnCalcTotSales.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCalcTotSales.Name = "btnCalcTotSales";
            this.btnCalcTotSales.Size = new System.Drawing.Size(152, 37);
            this.btnCalcTotSales.TabIndex = 42;
            this.btnCalcTotSales.Text = "Show seats sold";
            this.btnCalcTotSales.UseVisualStyleBackColor = false;
            this.btnCalcTotSales.Click += new System.EventHandler(this.btnCalcTotSales_Click);
            // 
            // grpSeats
            // 
            this.grpSeats.Controls.Add(this.label2);
            this.grpSeats.Controls.Add(this.txtSeats);
            this.grpSeats.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSeats.Location = new System.Drawing.Point(42, 169);
            this.grpSeats.Name = "grpSeats";
            this.grpSeats.Size = new System.Drawing.Size(442, 84);
            this.grpSeats.TabIndex = 43;
            this.grpSeats.TabStop = false;
            this.grpSeats.Text = "Seats details";
            this.grpSeats.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "Seats sold for this Match:";
            // 
            // txtSeats
            // 
            this.txtSeats.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeats.Location = new System.Drawing.Point(281, 32);
            this.txtSeats.Name = "txtSeats";
            this.txtSeats.Size = new System.Drawing.Size(131, 32);
            this.txtSeats.TabIndex = 34;
         
            // 
            // cboMatchID
            // 
            this.cboMatchID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMatchID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMatchID.FormattingEnabled = true;
            this.cboMatchID.Location = new System.Drawing.Point(179, 120);
            this.cboMatchID.Name = "cboMatchID";
            this.cboMatchID.Size = new System.Drawing.Size(131, 32);
            this.cboMatchID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 40;
            this.label1.Text = "Match ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(35, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(355, 39);
            this.label6.TabIndex = 39;
            this.label6.Text = "Seats sold per Match";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(457, 277);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // frmSeatsSoldperMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(586, 379);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.btnMostSeatsSold);
            this.Controls.Add(this.btnCalcTotSales);
            this.Controls.Add(this.grpSeats);
            this.Controls.Add(this.cboMatchID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSAback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSeatsSoldperMatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Ticktes Retail - [Admin] - [Seats sold per Match]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSeatsSoldperMatch_FormClosed);
            this.Load += new System.EventHandler(this.frmSeatsSoldperMatch_Load);
            this.grpSeats.ResumeLayout(false);
            this.grpSeats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSAback;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.Button btnMostSeatsSold;
        private System.Windows.Forms.Button btnCalcTotSales;
        private System.Windows.Forms.GroupBox grpSeats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSeats;
        private System.Windows.Forms.ComboBox cboMatchID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
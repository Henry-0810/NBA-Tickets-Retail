
namespace NBA_Tickets_Retail
{
    partial class frmSeasonalSalesAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeasonalSalesAnalysis));
            this.btnYRAback = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboMatchID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.grpSales = new System.Windows.Forms.GroupBox();
            this.btnCalcTotSales = new System.Windows.Forms.Button();
            this.btnTotRev = new System.Windows.Forms.Button();
            this.btnGraph = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpSales.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYRAback
            // 
            this.btnYRAback.BackColor = System.Drawing.SystemColors.Menu;
            this.btnYRAback.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYRAback.Location = new System.Drawing.Point(1, 1);
            this.btnYRAback.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnYRAback.Name = "btnYRAback";
            this.btnYRAback.Size = new System.Drawing.Size(57, 26);
            this.btnYRAback.TabIndex = 18;
            this.btnYRAback.Text = "Back";
            this.btnYRAback.UseVisualStyleBackColor = false;
            this.btnYRAback.Click += new System.EventHandler(this.btnYRAback_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(435, 270);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(32, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(419, 39);
            this.label6.TabIndex = 20;
            this.label6.Text = "Yearly Revenue Analysis";
            // 
            // cboMatchID
            // 
            this.cboMatchID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMatchID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMatchID.FormattingEnabled = true;
            this.cboMatchID.Location = new System.Drawing.Point(176, 117);
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
            this.label1.Location = new System.Drawing.Point(34, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Match ID:";
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
            this.label2.Size = new System.Drawing.Size(265, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "Total Sales for this Match:";
            // 
            // txtSales
            // 
            this.txtSales.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSales.Location = new System.Drawing.Point(281, 32);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(131, 32);
            this.txtSales.TabIndex = 34;
            // 
            // grpSales
            // 
            this.grpSales.Controls.Add(this.label2);
            this.grpSales.Controls.Add(this.txtSales);
            this.grpSales.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSales.Location = new System.Drawing.Point(39, 166);
            this.grpSales.Name = "grpSales";
            this.grpSales.Size = new System.Drawing.Size(434, 84);
            this.grpSales.TabIndex = 36;
            this.grpSales.TabStop = false;
            this.grpSales.Text = "Sales details";
            this.grpSales.Visible = false;
            // 
            // btnCalcTotSales
            // 
            this.btnCalcTotSales.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcTotSales.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcTotSales.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalcTotSales.Location = new System.Drawing.Point(329, 116);
            this.btnCalcTotSales.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCalcTotSales.Name = "btnCalcTotSales";
            this.btnCalcTotSales.Size = new System.Drawing.Size(122, 37);
            this.btnCalcTotSales.TabIndex = 35;
            this.btnCalcTotSales.Text = "Calculate";
            this.btnCalcTotSales.UseVisualStyleBackColor = false;
            this.btnCalcTotSales.Click += new System.EventHandler(this.btnCalcTotSales_Click);
            // 
            // btnTotRev
            // 
            this.btnTotRev.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTotRev.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotRev.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTotRev.Location = new System.Drawing.Point(39, 294);
            this.btnTotRev.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTotRev.Name = "btnTotRev";
            this.btnTotRev.Size = new System.Drawing.Size(183, 37);
            this.btnTotRev.TabIndex = 37;
            this.btnTotRev.Text = "See Total Revenue";
            this.btnTotRev.UseVisualStyleBackColor = false;
            this.btnTotRev.Click += new System.EventHandler(this.btnTotRev_Click);
            // 
            // btnGraph
            // 
            this.btnGraph.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGraph.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraph.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGraph.Location = new System.Drawing.Point(240, 294);
            this.btnGraph.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(183, 37);
            this.btnGraph.TabIndex = 38;
            this.btnGraph.Text = "Show graph";
            this.btnGraph.UseVisualStyleBackColor = false;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // frmYearlyRevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(564, 372);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.btnTotRev);
            this.Controls.Add(this.btnCalcTotSales);
            this.Controls.Add(this.grpSales);
            this.Controls.Add(this.cboMatchID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnYRAback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmYearlyRevenueAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Tickets Retail - [Admin] - [Yearly Revenue Analysis]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmYearlyRevenueAnalysis_FormClosed);
            this.Load += new System.EventHandler(this.frmYearlyRevenueAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpSales.ResumeLayout(false);
            this.grpSales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYRAback;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboMatchID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSales;
        private System.Windows.Forms.GroupBox grpSales;
        private System.Windows.Forms.Button btnCalcTotSales;
        private System.Windows.Forms.Button btnTotRev;
        private System.Windows.Forms.Button btnGraph;
    }
}
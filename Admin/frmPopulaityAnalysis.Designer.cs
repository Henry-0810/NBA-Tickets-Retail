
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnSAback = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chartPopularity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtLeastSales = new System.Windows.Forms.TextBox();
            this.txtMostSales = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPopularity)).BeginInit();
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
            this.btnSAback.TabStop = false;
            this.btnSAback.Text = "Back";
            this.btnSAback.UseVisualStyleBackColor = false;
            this.btnSAback.Click += new System.EventHandler(this.btnSAback_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(26, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(325, 39);
            this.label6.TabIndex = 39;
            this.label6.Text = "Popularity Analysis";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(947, 423);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // chartPopularity
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPopularity.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPopularity.Legends.Add(legend1);
            this.chartPopularity.Location = new System.Drawing.Point(33, 92);
            this.chartPopularity.Name = "chartPopularity";
            this.chartPopularity.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartPopularity.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.DimGray};
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "No. of times purchased";
            this.chartPopularity.Series.Add(series1);
            this.chartPopularity.Size = new System.Drawing.Size(1007, 301);
            this.chartPopularity.TabIndex = 47;
            this.chartPopularity.TabStop = false;
            this.chartPopularity.Text = "chart1";
            // 
            // txtLeastSales
            // 
            this.txtLeastSales.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeastSales.Location = new System.Drawing.Point(272, 460);
            this.txtLeastSales.Name = "txtLeastSales";
            this.txtLeastSales.ReadOnly = true;
            this.txtLeastSales.Size = new System.Drawing.Size(197, 29);
            this.txtLeastSales.TabIndex = 90;
            this.txtLeastSales.TabStop = false;
            // 
            // txtMostSales
            // 
            this.txtMostSales.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMostSales.Location = new System.Drawing.Point(272, 422);
            this.txtMostSales.Name = "txtMostSales";
            this.txtMostSales.ReadOnly = true;
            this.txtMostSales.Size = new System.Drawing.Size(197, 29);
            this.txtMostSales.TabIndex = 88;
            this.txtMostSales.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(43, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 24);
            this.label1.TabIndex = 87;
            this.label1.Text = "Fan-favourite Seat Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(43, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 24);
            this.label4.TabIndex = 86;
            this.label4.Text = "Least popular Seat Type:";
            // 
            // frmPopulaityAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1076, 525);
            this.Controls.Add(this.txtLeastSales);
            this.Controls.Add(this.txtMostSales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chartPopularity);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSAback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPopulaityAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Ticktes Retail - [Admin] - [Popularity Analysis]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSeatsSoldperMatch_FormClosed);
            this.Load += new System.EventHandler(this.frmPopulaityAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPopularity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSAback;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPopularity;
        private System.Windows.Forms.TextBox txtLeastSales;
        private System.Windows.Forms.TextBox txtMostSales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}
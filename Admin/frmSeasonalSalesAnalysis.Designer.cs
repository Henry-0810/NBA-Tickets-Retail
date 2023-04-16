
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnYRAback = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtMostSales = new System.Windows.Forms.TextBox();
            this.txtSumOfSales = new System.Windows.Forms.TextBox();
            this.txtAvgSales = new System.Windows.Forms.TextBox();
            this.txtLeastSales = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).BeginInit();
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
            this.btnYRAback.TabStop = false;
            this.btnYRAback.Text = "Back";
            this.btnYRAback.UseVisualStyleBackColor = false;
            this.btnYRAback.Click += new System.EventHandler(this.btnYRAback_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(947, 528);
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
            this.label6.Location = new System.Drawing.Point(26, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(415, 39);
            this.label6.TabIndex = 20;
            this.label6.Text = "Seasonal Sales Analysis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 79;
            this.label1.Text = "Most Sales:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(29, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 78;
            this.label4.Text = "Least Sales:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(29, 535);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 24);
            this.label3.TabIndex = 77;
            this.label3.Text = "Average Sales:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(29, 573);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(251, 24);
            this.label9.TabIndex = 76;
            this.label9.Text = "Total Sales for whole season:";
            // 
            // chartSales
            // 
            this.chartSales.BorderlineColor = System.Drawing.Color.Black;
            chartArea6.AxisX.Title = "Match ID";
            chartArea6.AxisX.TitleFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.AxisY.Title = "Sales";
            chartArea6.AxisY.TitleFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.Name = "ChartArea1";
            this.chartSales.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartSales.Legends.Add(legend6);
            this.chartSales.Location = new System.Drawing.Point(16, 90);
            this.chartSales.Name = "chartSales";
            this.chartSales.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartSales.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.DimGray};
            series6.ChartArea = "ChartArea1";
            series6.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series6.Legend = "Legend1";
            series6.Name = "Total Sales";
            this.chartSales.Series.Add(series6);
            this.chartSales.Size = new System.Drawing.Size(1035, 350);
            this.chartSales.TabIndex = 80;
            this.chartSales.TabStop = false;
            this.chartSales.Text = "chart1";
            // 
            // txtMostSales
            // 
            this.txtMostSales.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMostSales.Location = new System.Drawing.Point(149, 458);
            this.txtMostSales.Name = "txtMostSales";
            this.txtMostSales.ReadOnly = true;
            this.txtMostSales.Size = new System.Drawing.Size(197, 29);
            this.txtMostSales.TabIndex = 81;
            this.txtMostSales.TabStop = false;
            // 
            // txtSumOfSales
            // 
            this.txtSumOfSales.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumOfSales.Location = new System.Drawing.Point(298, 572);
            this.txtSumOfSales.Name = "txtSumOfSales";
            this.txtSumOfSales.ReadOnly = true;
            this.txtSumOfSales.Size = new System.Drawing.Size(154, 29);
            this.txtSumOfSales.TabIndex = 82;
            this.txtSumOfSales.TabStop = false;
            // 
            // txtAvgSales
            // 
            this.txtAvgSales.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvgSales.Location = new System.Drawing.Point(164, 534);
            this.txtAvgSales.Name = "txtAvgSales";
            this.txtAvgSales.ReadOnly = true;
            this.txtAvgSales.Size = new System.Drawing.Size(386, 29);
            this.txtAvgSales.TabIndex = 83;
            this.txtAvgSales.TabStop = false;
            // 
            // txtLeastSales
            // 
            this.txtLeastSales.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeastSales.Location = new System.Drawing.Point(149, 496);
            this.txtLeastSales.Name = "txtLeastSales";
            this.txtLeastSales.ReadOnly = true;
            this.txtLeastSales.Size = new System.Drawing.Size(197, 29);
            this.txtLeastSales.TabIndex = 84;
            this.txtLeastSales.TabStop = false;
            // 
            // frmSeasonalSalesAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1076, 630);
            this.Controls.Add(this.txtLeastSales);
            this.Controls.Add(this.txtAvgSales);
            this.Controls.Add(this.txtSumOfSales);
            this.Controls.Add(this.txtMostSales);
            this.Controls.Add(this.chartSales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnYRAback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSeasonalSalesAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Tickets Retail - [Admin] - [Seasonal Sales Analysis]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmYearlyRevenueAnalysis_FormClosed);
            this.Load += new System.EventHandler(this.frmSeasonalSalesAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYRAback;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSales;
        private System.Windows.Forms.TextBox txtMostSales;
        private System.Windows.Forms.TextBox txtSumOfSales;
        private System.Windows.Forms.TextBox txtAvgSales;
        private System.Windows.Forms.TextBox txtLeastSales;
    }
}
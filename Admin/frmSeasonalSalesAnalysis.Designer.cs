
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeasonalSalesAnalysis));
            this.btnYRAback = new System.Windows.Forms.Button();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYRAback
            // 
            this.btnYRAback.BackColor = System.Drawing.SystemColors.Menu;
            this.btnYRAback.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYRAback.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnYRAback.Location = new System.Drawing.Point(1, 1);
            this.btnYRAback.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnYRAback.Name = "btnYRAback";
            this.btnYRAback.Size = new System.Drawing.Size(43, 21);
            this.btnYRAback.TabIndex = 18;
            this.btnYRAback.TabStop = false;
            this.btnYRAback.Text = "Back";
            this.btnYRAback.UseVisualStyleBackColor = false;
            this.btnYRAback.Click += new System.EventHandler(this.btnYRAback_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Imprint MT Shadow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(302, 32);
            this.label6.TabIndex = 20;
            this.label6.Text = "Seasonal Sales Analysis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 403);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 79;
            this.label1.Text = "Most Sales:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 434);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 78;
            this.label4.Text = "Least Sales:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 465);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 77;
            this.label3.Text = "Average Sales:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(22, 496);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 19);
            this.label9.TabIndex = 76;
            this.label9.Text = "Total Sales for whole season:";
            // 
            // chartSales
            // 
            this.chartSales.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.Title = "Match ID";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.Title = "Sales";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.chartSales.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSales.Legends.Add(legend1);
            this.chartSales.Location = new System.Drawing.Point(12, 73);
            this.chartSales.Margin = new System.Windows.Forms.Padding(2);
            this.chartSales.Name = "chartSales";
            this.chartSales.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartSales.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.LightGray};
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Total Sales";
            this.chartSales.Series.Add(series1);
            this.chartSales.Size = new System.Drawing.Size(913, 311);
            this.chartSales.TabIndex = 80;
            this.chartSales.TabStop = false;
            this.chartSales.Text = "chart1";
            // 
            // txtMostSales
            // 
            this.txtMostSales.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtMostSales.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMostSales.ForeColor = System.Drawing.Color.White;
            this.txtMostSales.Location = new System.Drawing.Point(112, 402);
            this.txtMostSales.Margin = new System.Windows.Forms.Padding(2);
            this.txtMostSales.Name = "txtMostSales";
            this.txtMostSales.ReadOnly = true;
            this.txtMostSales.Size = new System.Drawing.Size(149, 25);
            this.txtMostSales.TabIndex = 81;
            this.txtMostSales.TabStop = false;
            // 
            // txtSumOfSales
            // 
            this.txtSumOfSales.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSumOfSales.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumOfSales.ForeColor = System.Drawing.Color.White;
            this.txtSumOfSales.Location = new System.Drawing.Point(224, 495);
            this.txtSumOfSales.Margin = new System.Windows.Forms.Padding(2);
            this.txtSumOfSales.Name = "txtSumOfSales";
            this.txtSumOfSales.ReadOnly = true;
            this.txtSumOfSales.Size = new System.Drawing.Size(116, 25);
            this.txtSumOfSales.TabIndex = 82;
            this.txtSumOfSales.TabStop = false;
            // 
            // txtAvgSales
            // 
            this.txtAvgSales.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAvgSales.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvgSales.ForeColor = System.Drawing.Color.White;
            this.txtAvgSales.Location = new System.Drawing.Point(123, 464);
            this.txtAvgSales.Margin = new System.Windows.Forms.Padding(2);
            this.txtAvgSales.Name = "txtAvgSales";
            this.txtAvgSales.ReadOnly = true;
            this.txtAvgSales.Size = new System.Drawing.Size(290, 25);
            this.txtAvgSales.TabIndex = 83;
            this.txtAvgSales.TabStop = false;
            // 
            // txtLeastSales
            // 
            this.txtLeastSales.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtLeastSales.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeastSales.ForeColor = System.Drawing.Color.White;
            this.txtLeastSales.Location = new System.Drawing.Point(112, 433);
            this.txtLeastSales.Margin = new System.Windows.Forms.Padding(2);
            this.txtLeastSales.Name = "txtLeastSales";
            this.txtLeastSales.ReadOnly = true;
            this.txtLeastSales.Size = new System.Drawing.Size(149, 25);
            this.txtLeastSales.TabIndex = 84;
            this.txtLeastSales.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(815, 434);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // frmSeasonalSalesAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::NBA_Tickets_Retail.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(945, 535);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLeastSales);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chartSales);
            this.Controls.Add(this.txtAvgSales);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSumOfSales);
            this.Controls.Add(this.btnYRAback);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMostSales);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSeasonalSalesAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Tickets Retail - [Admin] - [Seasonal Sales Analysis]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmYearlyRevenueAnalysis_FormClosed);
            this.Load += new System.EventHandler(this.frmSeasonalSalesAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
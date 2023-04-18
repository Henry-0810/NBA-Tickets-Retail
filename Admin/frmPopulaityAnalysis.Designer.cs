
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnSAback = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chartPopularity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtLeastFavSeatType = new System.Windows.Forms.TextBox();
            this.txtFavSeatType = new System.Windows.Forms.TextBox();
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
            this.btnSAback.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSAback.Name = "btnSAback";
            this.btnSAback.Size = new System.Drawing.Size(43, 21);
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
            this.label6.Location = new System.Drawing.Point(20, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 31);
            this.label6.TabIndex = 39;
            this.label6.Text = "Popularity Analysis";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(710, 344);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // chartPopularity
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPopularity.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPopularity.Legends.Add(legend2);
            this.chartPopularity.Location = new System.Drawing.Point(25, 75);
            this.chartPopularity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartPopularity.Name = "chartPopularity";
            this.chartPopularity.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartPopularity.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.DimGray};
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "No. of times purchased";
            this.chartPopularity.Series.Add(series2);
            this.chartPopularity.Size = new System.Drawing.Size(755, 245);
            this.chartPopularity.TabIndex = 47;
            this.chartPopularity.TabStop = false;
            this.chartPopularity.Text = "chart1";
            // 
            // txtLeastFavSeatType
            // 
            this.txtLeastFavSeatType.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeastFavSeatType.Location = new System.Drawing.Point(218, 374);
            this.txtLeastFavSeatType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLeastFavSeatType.Name = "txtLeastFavSeatType";
            this.txtLeastFavSeatType.ReadOnly = true;
            this.txtLeastFavSeatType.Size = new System.Drawing.Size(149, 25);
            this.txtLeastFavSeatType.TabIndex = 90;
            this.txtLeastFavSeatType.TabStop = false;
            // 
            // txtFavSeatType
            // 
            this.txtFavSeatType.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFavSeatType.Location = new System.Drawing.Point(218, 343);
            this.txtFavSeatType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFavSeatType.Name = "txtFavSeatType";
            this.txtFavSeatType.ReadOnly = true;
            this.txtFavSeatType.Size = new System.Drawing.Size(149, 25);
            this.txtFavSeatType.TabIndex = 88;
            this.txtFavSeatType.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 344);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 19);
            this.label1.TabIndex = 87;
            this.label1.Text = "Fan-favourite Seat Type(s):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(32, 375);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 19);
            this.label4.TabIndex = 86;
            this.label4.Text = "Least popular Seat Type(s):";
            // 
            // frmPopulaityAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(807, 427);
            this.Controls.Add(this.txtLeastFavSeatType);
            this.Controls.Add(this.txtFavSeatType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chartPopularity);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSAback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox txtLeastFavSeatType;
        private System.Windows.Forms.TextBox txtFavSeatType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}
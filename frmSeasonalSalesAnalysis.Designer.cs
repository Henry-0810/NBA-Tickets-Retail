
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
            this.btnMaxSales = new System.Windows.Forms.Button();
            this.btnMinSales = new System.Windows.Forms.Button();
            this.btnAvgSales = new System.Windows.Forms.Button();
            this.btnSeasonRevenue = new System.Windows.Forms.Button();
            this.btnGraph = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pictureBox1.Location = new System.Drawing.Point(339, 270);
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
            this.label6.Size = new System.Drawing.Size(415, 39);
            this.label6.TabIndex = 20;
            this.label6.Text = "Seasonal Sales Analysis";
            // 
            // btnMaxSales
            // 
            this.btnMaxSales.BackColor = System.Drawing.SystemColors.Window;
            this.btnMaxSales.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxSales.Location = new System.Drawing.Point(39, 115);
            this.btnMaxSales.Name = "btnMaxSales";
            this.btnMaxSales.Size = new System.Drawing.Size(109, 89);
            this.btnMaxSales.TabIndex = 0;
            this.btnMaxSales.Text = "Most Sales per Match";
            this.btnMaxSales.UseVisualStyleBackColor = false;
            this.btnMaxSales.Click += new System.EventHandler(this.btnMaxSales_Click);
            // 
            // btnMinSales
            // 
            this.btnMinSales.BackColor = System.Drawing.SystemColors.Window;
            this.btnMinSales.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinSales.Location = new System.Drawing.Point(176, 115);
            this.btnMinSales.Name = "btnMinSales";
            this.btnMinSales.Size = new System.Drawing.Size(109, 89);
            this.btnMinSales.TabIndex = 22;
            this.btnMinSales.Text = "Least Sales per Match";
            this.btnMinSales.UseVisualStyleBackColor = false;
            this.btnMinSales.Click += new System.EventHandler(this.btnMinSales_Click);
            // 
            // btnAvgSales
            // 
            this.btnAvgSales.BackColor = System.Drawing.SystemColors.Window;
            this.btnAvgSales.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvgSales.Location = new System.Drawing.Point(176, 257);
            this.btnAvgSales.Name = "btnAvgSales";
            this.btnAvgSales.Size = new System.Drawing.Size(109, 89);
            this.btnAvgSales.TabIndex = 23;
            this.btnAvgSales.Text = "Average Sales per Match";
            this.btnAvgSales.UseVisualStyleBackColor = false;
            this.btnAvgSales.Click += new System.EventHandler(this.btnAvgSales_Click);
            // 
            // btnSeasonRevenue
            // 
            this.btnSeasonRevenue.BackColor = System.Drawing.SystemColors.Window;
            this.btnSeasonRevenue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeasonRevenue.Location = new System.Drawing.Point(39, 257);
            this.btnSeasonRevenue.Name = "btnSeasonRevenue";
            this.btnSeasonRevenue.Size = new System.Drawing.Size(109, 89);
            this.btnSeasonRevenue.TabIndex = 24;
            this.btnSeasonRevenue.Text = "Total sales for this season";
            this.btnSeasonRevenue.UseVisualStyleBackColor = false;
            this.btnSeasonRevenue.Click += new System.EventHandler(this.btnSeasonRevenue_Click);
            // 
            // btnGraph
            // 
            this.btnGraph.BackColor = System.Drawing.SystemColors.Window;
            this.btnGraph.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraph.Location = new System.Drawing.Point(313, 115);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(109, 89);
            this.btnGraph.TabIndex = 25;
            this.btnGraph.Text = "Graphical analysis";
            this.btnGraph.UseVisualStyleBackColor = false;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // frmSeasonalSalesAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(468, 372);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.btnSeasonRevenue);
            this.Controls.Add(this.btnAvgSales);
            this.Controls.Add(this.btnMinSales);
            this.Controls.Add(this.btnMaxSales);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnYRAback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSeasonalSalesAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Tickets Retail - [Admin] - [Seasonal Sales Analysis]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmYearlyRevenueAnalysis_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYRAback;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMaxSales;
        private System.Windows.Forms.Button btnMinSales;
        private System.Windows.Forms.Button btnAvgSales;
        private System.Windows.Forms.Button btnSeasonRevenue;
        private System.Windows.Forms.Button btnGraph;
    }
}

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
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGraph = new System.Windows.Forms.Button();
            this.btnAvgSeats = new System.Windows.Forms.Button();
            this.btnMinSales = new System.Windows.Forms.Button();
            this.btnMaxSeats = new System.Windows.Forms.Button();
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
            this.pictureBox1.Location = new System.Drawing.Point(348, 277);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // btnGraph
            // 
            this.btnGraph.BackColor = System.Drawing.SystemColors.Window;
            this.btnGraph.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraph.Location = new System.Drawing.Point(180, 238);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(109, 89);
            this.btnGraph.TabIndex = 51;
            this.btnGraph.Text = "Graphical analysis";
            this.btnGraph.UseVisualStyleBackColor = false;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // btnAvgSeats
            // 
            this.btnAvgSeats.BackColor = System.Drawing.SystemColors.Window;
            this.btnAvgSeats.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvgSeats.Location = new System.Drawing.Point(42, 238);
            this.btnAvgSeats.Name = "btnAvgSeats";
            this.btnAvgSeats.Size = new System.Drawing.Size(109, 89);
            this.btnAvgSeats.TabIndex = 49;
            this.btnAvgSeats.Text = "Average Seats Sold per match";
            this.btnAvgSeats.UseVisualStyleBackColor = false;
            this.btnAvgSeats.Click += new System.EventHandler(this.btnAvgSeats_Click);
            // 
            // btnMinSales
            // 
            this.btnMinSales.BackColor = System.Drawing.SystemColors.Window;
            this.btnMinSales.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinSales.Location = new System.Drawing.Point(180, 112);
            this.btnMinSales.Name = "btnMinSales";
            this.btnMinSales.Size = new System.Drawing.Size(109, 89);
            this.btnMinSales.TabIndex = 48;
            this.btnMinSales.Text = "Least Seats Sold per match";
            this.btnMinSales.UseVisualStyleBackColor = false;
            this.btnMinSales.Click += new System.EventHandler(this.btnMinSales_Click);
            // 
            // btnMaxSeats
            // 
            this.btnMaxSeats.BackColor = System.Drawing.SystemColors.Window;
            this.btnMaxSeats.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxSeats.Location = new System.Drawing.Point(42, 112);
            this.btnMaxSeats.Name = "btnMaxSeats";
            this.btnMaxSeats.Size = new System.Drawing.Size(109, 89);
            this.btnMaxSeats.TabIndex = 0;
            this.btnMaxSeats.Text = "Most Seats Sold per match";
            this.btnMaxSeats.UseVisualStyleBackColor = false;
            this.btnMaxSeats.Click += new System.EventHandler(this.btnMaxSeats_Click);
            // 
            // frmPopulaityAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(477, 379);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.btnAvgSeats);
            this.Controls.Add(this.btnMinSales);
            this.Controls.Add(this.btnMaxSeats);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSAback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPopulaityAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Ticktes Retail - [Admin] - [Popularity Analysis]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSeatsSoldperMatch_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSAback;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.Button btnAvgSeats;
        private System.Windows.Forms.Button btnMinSales;
        private System.Windows.Forms.Button btnMaxSeats;
    }
}
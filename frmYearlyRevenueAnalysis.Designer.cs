
namespace NBA_Tickets_Retail
{
    partial class frmYearlyRevenueAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYearlyRevenueAnalysis));
            this.btnYRAback = new System.Windows.Forms.Button();
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
            // frmYearlyRevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnYRAback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmYearlyRevenueAnalysis";
            this.Text = "NBA Tickets Retail - [Admin] - [Yearly Revenue Analysis]";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYRAback;
    }
}
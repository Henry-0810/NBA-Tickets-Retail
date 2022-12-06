
namespace NBA_Tickets_Retail
{
    partial class frmSeatsAvailability
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeatsAvailability));
            this.btnSAback = new System.Windows.Forms.Button();
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
            // frmSeatsAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSAback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSeatsAvailability";
            this.Text = "NBA Ticktes Retail - [Admin] - [Seats Availability per Match]";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSAback;
    }
}
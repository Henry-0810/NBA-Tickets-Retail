namespace NBA_Tickets_Retail
{
    partial class frmUpdateSeatType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateSeatType));
            this.btnUSTback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUSTback
            // 
            this.btnUSTback.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUSTback.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUSTback.Location = new System.Drawing.Point(1, 1);
            this.btnUSTback.Name = "btnUSTback";
            this.btnUSTback.Size = new System.Drawing.Size(31, 31);
            this.btnUSTback.TabIndex = 0;
            this.btnUSTback.Text = "<--";
            this.btnUSTback.UseVisualStyleBackColor = false;
            this.btnUSTback.Click += new System.EventHandler(this.btnUSTback_Click);
            // 
            // frmUpdateSeatType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.btnUSTback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateSeatType";
            this.Text = "NBA Tickets Retail - [Update Seat Type]";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUSTback;
    }
}
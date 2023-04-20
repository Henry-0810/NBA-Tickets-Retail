
namespace NBA_Tickets_Retail
{
    partial class frmViewMatches
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewMatches));
            this.btnVMback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVMback
            // 
            this.btnVMback.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVMback.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVMback.Location = new System.Drawing.Point(2, 2);
            this.btnVMback.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVMback.Name = "btnVMback";
            this.btnVMback.Size = new System.Drawing.Size(43, 21);
            this.btnVMback.TabIndex = 49;
            this.btnVMback.TabStop = false;
            this.btnVMback.Text = "Back";
            this.btnVMback.UseVisualStyleBackColor = false;
            this.btnVMback.Click += new System.EventHandler(this.btnVMback_Click);
            // 
            // frmViewMatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NBA_Tickets_Retail.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVMback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewMatches";
            this.Text = "Match Schedule";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmViewMatches_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVMback;
    }
}
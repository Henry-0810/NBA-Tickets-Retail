
namespace NBA_Tickets_Retail
{
    partial class frmReturnTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReturnTickets));
            this.btnRTback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRTback
            // 
            this.btnRTback.BackColor = System.Drawing.SystemColors.Menu;
            this.btnRTback.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRTback.Location = new System.Drawing.Point(1, 2);
            this.btnRTback.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRTback.Name = "btnRTback";
            this.btnRTback.Size = new System.Drawing.Size(57, 26);
            this.btnRTback.TabIndex = 17;
            this.btnRTback.Text = "Back";
            this.btnRTback.UseVisualStyleBackColor = false;
            this.btnRTback.Click += new System.EventHandler(this.btnRTback_Click);
            // 
            // frmReturnTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRTback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReturnTickets";
            this.Text = "NBA Tickets Retail - [Tickets] - [Return Tickets]";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRTback;
    }
}
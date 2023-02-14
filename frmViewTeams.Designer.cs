
namespace NBA_Tickets_Retail
{
    partial class frmViewTeams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewTeams));
            this.dgvTeamList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeamList
            // 
            this.dgvTeamList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTeamList.Location = new System.Drawing.Point(0, 0);
            this.dgvTeamList.Name = "dgvTeamList";
            this.dgvTeamList.Size = new System.Drawing.Size(538, 343);
            this.dgvTeamList.TabIndex = 0;
            // 
            // frmViewTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 343);
            this.Controls.Add(this.dgvTeamList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewTeams";
            this.Text = "Team List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmViewTeams_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeamList;
    }
}
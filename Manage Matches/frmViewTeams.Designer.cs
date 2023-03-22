
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
            this.teamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeamList
            // 
            this.dgvTeamList.AllowUserToAddRows = false;
            this.dgvTeamList.AllowUserToResizeRows = false;
            this.dgvTeamList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTeamList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTeamList.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvTeamList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTeamList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamID,
            this.teamName});
            this.dgvTeamList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTeamList.Location = new System.Drawing.Point(0, 0);
            this.dgvTeamList.Name = "dgvTeamList";
            this.dgvTeamList.RowHeadersVisible = false;
            this.dgvTeamList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvTeamList.Size = new System.Drawing.Size(214, 247);
            this.dgvTeamList.TabIndex = 0;
            // 
            // teamID
            // 
            this.teamID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.teamID.HeaderText = "Team ID";
            this.teamID.Name = "teamID";
            this.teamID.ReadOnly = true;
            this.teamID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.teamID.Width = 54;
            // 
            // teamName
            // 
            this.teamName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.teamName.HeaderText = "Team Name";
            this.teamName.Name = "teamName";
            this.teamName.ReadOnly = true;
            this.teamName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.teamName.Width = 71;
            // 
            // frmViewTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 247);
            this.Controls.Add(this.dgvTeamList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmViewTeams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmViewTeams_FormClosed);
            this.Load += new System.EventHandler(this.FrmViewTeams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeamList;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamName;
    }
}
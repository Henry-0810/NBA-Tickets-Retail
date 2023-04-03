
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVTback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.teamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeamList
            // 
            this.dgvTeamList.AllowUserToAddRows = false;
            this.dgvTeamList.AllowUserToResizeColumns = false;
            this.dgvTeamList.AllowUserToResizeRows = false;
            this.dgvTeamList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTeamList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeamList.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvTeamList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTeamList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamID,
            this.teamName});
            this.dgvTeamList.Location = new System.Drawing.Point(28, 88);
            this.dgvTeamList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTeamList.Name = "dgvTeamList";
            this.dgvTeamList.RowHeadersVisible = false;
            this.dgvTeamList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvTeamList.Size = new System.Drawing.Size(341, 314);
            this.dgvTeamList.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(383, 315);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // btnVTback
            // 
            this.btnVTback.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVTback.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVTback.Location = new System.Drawing.Point(0, 1);
            this.btnVTback.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVTback.Name = "btnVTback";
            this.btnVTback.Size = new System.Drawing.Size(57, 26);
            this.btnVTback.TabIndex = 48;
            this.btnVTback.Text = "Back";
            this.btnVTback.UseVisualStyleBackColor = false;
            this.btnVTback.Click += new System.EventHandler(this.btnVTback_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 39);
            this.label1.TabIndex = 49;
            this.label1.Text = "Teams";
            // 
            // teamID
            // 
            this.teamID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teamID.FillWeight = 35.29412F;
            this.teamID.HeaderText = "Team ID";
            this.teamID.MinimumWidth = 6;
            this.teamID.Name = "teamID";
            this.teamID.ReadOnly = true;
            this.teamID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // teamName
            // 
            this.teamName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teamName.FillWeight = 74.70589F;
            this.teamName.HeaderText = "Team Name";
            this.teamName.MinimumWidth = 6;
            this.teamName.Name = "teamName";
            this.teamName.ReadOnly = true;
            this.teamName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmViewTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVTback);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvTeamList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmViewTeams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmViewTeams_FormClosed);
            this.Load += new System.EventHandler(this.FrmViewTeams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeamList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVTback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamName;
    }
}
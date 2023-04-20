
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewTeams));
            this.btnVTback = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTeamList = new System.Windows.Forms.DataGridView();
            this.teamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVTback
            // 
            this.btnVTback.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVTback.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVTback.Location = new System.Drawing.Point(0, 1);
            this.btnVTback.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVTback.Name = "btnVTback";
            this.btnVTback.Size = new System.Drawing.Size(43, 21);
            this.btnVTback.TabIndex = 48;
            this.btnVTback.TabStop = false;
            this.btnVTback.Text = "Back";
            this.btnVTback.UseVisualStyleBackColor = false;
            this.btnVTback.Click += new System.EventHandler(this.btnVTback_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvTeamList);
            this.panel1.Location = new System.Drawing.Point(72, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 329);
            this.panel1.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 32);
            this.label1.TabIndex = 51;
            this.label1.Text = "Teams";
            // 
            // dgvTeamList
            // 
            this.dgvTeamList.AllowUserToAddRows = false;
            this.dgvTeamList.AllowUserToDeleteRows = false;
            this.dgvTeamList.AllowUserToResizeColumns = false;
            this.dgvTeamList.AllowUserToResizeRows = false;
            this.dgvTeamList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTeamList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeamList.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvTeamList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTeamList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTeamList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamID,
            this.teamName});
            this.dgvTeamList.Location = new System.Drawing.Point(46, 54);
            this.dgvTeamList.Name = "dgvTeamList";
            this.dgvTeamList.ReadOnly = true;
            this.dgvTeamList.RowHeadersVisible = false;
            this.dgvTeamList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvTeamList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTeamList.Size = new System.Drawing.Size(230, 247);
            this.dgvTeamList.TabIndex = 50;
            // 
            // teamID
            // 
            this.teamID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teamID.FillWeight = 47.05883F;
            this.teamID.HeaderText = "Team ID";
            this.teamID.MinimumWidth = 6;
            this.teamID.Name = "teamID";
            this.teamID.ReadOnly = true;
            this.teamID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // teamName
            // 
            this.teamName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teamName.FillWeight = 62.94118F;
            this.teamName.HeaderText = "Team Name";
            this.teamName.MinimumWidth = 6;
            this.teamName.Name = "teamName";
            this.teamName.ReadOnly = true;
            this.teamName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmViewTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NBA_Tickets_Retail.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(469, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVTback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmViewTeams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmViewTeams_FormClosed);
            this.Load += new System.EventHandler(this.FrmViewTeams_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVTback;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTeamList;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamName;
    }
}

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewMatches));
            this.btnVMback = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            this.MatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatchDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatchTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvMatches);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(72, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 332);
            this.panel1.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 32);
            this.label1.TabIndex = 52;
            this.label1.Text = "Matches";
            // 
            // dgvMatches
            // 
            this.dgvMatches.AllowUserToAddRows = false;
            this.dgvMatches.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MatchID,
            this.MatchDate,
            this.MatchTime,
            this.TeamName});
            this.dgvMatches.Location = new System.Drawing.Point(24, 49);
            this.dgvMatches.Name = "dgvMatches";
            this.dgvMatches.ReadOnly = true;
            this.dgvMatches.RowHeadersVisible = false;
            this.dgvMatches.Size = new System.Drawing.Size(566, 251);
            this.dgvMatches.TabIndex = 53;
            // 
            // MatchID
            // 
            this.MatchID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MatchID.FillWeight = 69.8209F;
            this.MatchID.HeaderText = "Match ID";
            this.MatchID.Name = "MatchID";
            this.MatchID.ReadOnly = true;
            // 
            // MatchDate
            // 
            this.MatchDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MatchDate.FillWeight = 129.5565F;
            this.MatchDate.HeaderText = "Match Date";
            this.MatchDate.Name = "MatchDate";
            this.MatchDate.ReadOnly = true;
            // 
            // MatchTime
            // 
            this.MatchTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MatchTime.FillWeight = 71.06599F;
            this.MatchTime.HeaderText = "Match Time";
            this.MatchTime.Name = "MatchTime";
            this.MatchTime.ReadOnly = true;
            // 
            // TeamName
            // 
            this.TeamName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TeamName.FillWeight = 129.5565F;
            this.TeamName.HeaderText = "Team Name";
            this.TeamName.Name = "TeamName";
            this.TeamName.ReadOnly = true;
            // 
            // frmViewMatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NBA_Tickets_Retail.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVMback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmViewMatches";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Match Schedule";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmViewMatches_FormClosed);
            this.Load += new System.EventHandler(this.frmViewMatches_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVMback;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMatches;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamName;
    }
}
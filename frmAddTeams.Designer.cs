
namespace NBA_Tickets_Retail
{
    partial class frmAddTeams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddTeams));
            this.btnATback = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnViewTeams = new System.Windows.Forms.Button();
            this.lblTeamID = new System.Windows.Forms.Label();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.txtTeamID = new System.Windows.Forms.TextBox();
            this.btnAddTeams = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnATback
            // 
            this.btnATback.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnATback.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnATback.Location = new System.Drawing.Point(0, 1);
            this.btnATback.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnATback.Name = "btnATback";
            this.btnATback.Size = new System.Drawing.Size(43, 21);
            this.btnATback.TabIndex = 18;
            this.btnATback.Text = "Back";
            this.btnATback.UseVisualStyleBackColor = false;
            this.btnATback.Click += new System.EventHandler(this.btnATback_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(262, 170);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnViewTeams
            // 
            this.btnViewTeams.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTeams.Location = new System.Drawing.Point(257, 12);
            this.btnViewTeams.Name = "btnViewTeams";
            this.btnViewTeams.Size = new System.Drawing.Size(107, 30);
            this.btnViewTeams.TabIndex = 20;
            this.btnViewTeams.Text = "View Teams";
            this.btnViewTeams.UseVisualStyleBackColor = true;
            this.btnViewTeams.Click += new System.EventHandler(this.btnViewTeams_Click);
            // 
            // lblTeamID
            // 
            this.lblTeamID.AutoSize = true;
            this.lblTeamID.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamID.Location = new System.Drawing.Point(34, 53);
            this.lblTeamID.Name = "lblTeamID";
            this.lblTeamID.Size = new System.Drawing.Size(81, 23);
            this.lblTeamID.TabIndex = 21;
            this.lblTeamID.Text = "Team ID: ";
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.Location = new System.Drawing.Point(34, 99);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(108, 23);
            this.lblTeamName.TabIndex = 22;
            this.lblTeamName.Text = "Team Name: ";
            // 
            // txtTeamName
            // 
            this.txtTeamName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeamName.Location = new System.Drawing.Point(153, 99);
            this.txtTeamName.Multiline = true;
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(171, 49);
            this.txtTeamName.TabIndex = 1;
            // 
            // txtTeamID
            // 
            this.txtTeamID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeamID.Location = new System.Drawing.Point(153, 53);
            this.txtTeamID.Name = "txtTeamID";
            this.txtTeamID.Size = new System.Drawing.Size(89, 27);
            this.txtTeamID.TabIndex = 0;
            // 
            // btnAddTeams
            // 
            this.btnAddTeams.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAddTeams.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeams.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddTeams.Location = new System.Drawing.Point(68, 195);
            this.btnAddTeams.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddTeams.Name = "btnAddTeams";
            this.btnAddTeams.Size = new System.Drawing.Size(113, 36);
            this.btnAddTeams.TabIndex = 2;
            this.btnAddTeams.Text = "ADD";
            this.btnAddTeams.UseVisualStyleBackColor = false;
            this.btnAddTeams.Click += new System.EventHandler(this.btnAddTeams_Click);
            // 
            // frmAddTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(391, 272);
            this.Controls.Add(this.btnAddTeams);
            this.Controls.Add(this.txtTeamID);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.lblTeamID);
            this.Controls.Add(this.btnViewTeams);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnATback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddTeams";
            this.Text = "NBA Tickets Retail - [Matches] - [Add Teams]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddTeams_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnATback;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnViewTeams;
        private System.Windows.Forms.Label lblTeamID;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.TextBox txtTeamID;
        private System.Windows.Forms.Button btnAddTeams;
    }
}
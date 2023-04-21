
namespace NBA_Tickets_Retail
{
    partial class frmAddTeam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddTeam));
            this.btnATback = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnViewTeams = new System.Windows.Forms.Button();
            this.lblTeamID = new System.Windows.Forms.Label();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.txtTeamID = new System.Windows.Forms.TextBox();
            this.btnAddTeams = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnATback
            // 
            this.btnATback.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnATback.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnATback.Location = new System.Drawing.Point(0, 1);
            this.btnATback.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnATback.Name = "btnATback";
            this.btnATback.Size = new System.Drawing.Size(57, 26);
            this.btnATback.TabIndex = 18;
            this.btnATback.TabStop = false;
            this.btnATback.Text = "Back";
            this.btnATback.UseVisualStyleBackColor = false;
            this.btnATback.Click += new System.EventHandler(this.btnATback_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(416, 236);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnViewTeams
            // 
            this.btnViewTeams.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTeams.Location = new System.Drawing.Point(396, 4);
            this.btnViewTeams.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewTeams.Name = "btnViewTeams";
            this.btnViewTeams.Size = new System.Drawing.Size(143, 37);
            this.btnViewTeams.TabIndex = 20;
            this.btnViewTeams.TabStop = false;
            this.btnViewTeams.Text = "View Teams";
            this.btnViewTeams.UseVisualStyleBackColor = true;
            this.btnViewTeams.Click += new System.EventHandler(this.btnViewTeams_Click);
            // 
            // lblTeamID
            // 
            this.lblTeamID.AutoSize = true;
            this.lblTeamID.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamID.Location = new System.Drawing.Point(44, 76);
            this.lblTeamID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeamID.Name = "lblTeamID";
            this.lblTeamID.Size = new System.Drawing.Size(103, 29);
            this.lblTeamID.TabIndex = 21;
            this.lblTeamID.Text = "Team ID: ";
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.Location = new System.Drawing.Point(44, 133);
            this.lblTeamName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(141, 29);
            this.lblTeamName.TabIndex = 22;
            this.lblTeamName.Text = "Team Name: ";
            // 
            // txtTeamName
            // 
            this.txtTeamName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeamName.Location = new System.Drawing.Point(203, 133);
            this.txtTeamName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTeamName.Multiline = true;
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(227, 77);
            this.txtTeamName.TabIndex = 1;
            // 
            // txtTeamID
            // 
            this.txtTeamID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeamID.Location = new System.Drawing.Point(203, 76);
            this.txtTeamID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTeamID.Name = "txtTeamID";
            this.txtTeamID.Size = new System.Drawing.Size(117, 32);
            this.txtTeamID.TabIndex = 0;
            // 
            // btnAddTeams
            // 
            this.btnAddTeams.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAddTeams.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeams.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddTeams.Location = new System.Drawing.Point(133, 236);
            this.btnAddTeams.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddTeams.Name = "btnAddTeams";
            this.btnAddTeams.Size = new System.Drawing.Size(151, 44);
            this.btnAddTeams.TabIndex = 2;
            this.btnAddTeams.Text = "ADD";
            this.btnAddTeams.UseVisualStyleBackColor = false;
            this.btnAddTeams.Click += new System.EventHandler(this.btnAddTeams_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 39);
            this.label1.TabIndex = 23;
            this.label1.Text = "Add Teams";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnViewTeams);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnAddTeams);
            this.panel1.Controls.Add(this.lblTeamID);
            this.panel1.Controls.Add(this.txtTeamID);
            this.panel1.Controls.Add(this.lblTeamName);
            this.panel1.Controls.Add(this.txtTeamName);
            this.panel1.Location = new System.Drawing.Point(272, 139);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 328);
            this.panel1.TabIndex = 24;
            // 
            // frmAddTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::NBA_Tickets_Retail.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1089, 606);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnATback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmAddTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Tickets Retail - [Matches] - [Add Teams]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddTeams_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
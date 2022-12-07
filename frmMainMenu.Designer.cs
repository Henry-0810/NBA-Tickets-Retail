namespace NBA_Tickets_Retail
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.picMainMenu = new System.Windows.Forms.PictureBox();
            this.seatTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSeatTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSeatTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAvailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyRevenueAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenu)).BeginInit();
            this.mnuMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMainMenu
            // 
            this.picMainMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.picMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("picMainMenu.Image")));
            this.picMainMenu.Location = new System.Drawing.Point(0, 30);
            this.picMainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMainMenu.Name = "picMainMenu";
            this.picMainMenu.Size = new System.Drawing.Size(941, 491);
            this.picMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMainMenu.TabIndex = 0;
            this.picMainMenu.TabStop = false;
            // 
            // seatTypeToolStripMenuItem
            // 
            this.seatTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSeatTypeToolStripMenuItem,
            this.updateSeatTypeToolStripMenuItem});
            this.seatTypeToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatTypeToolStripMenuItem.Name = "seatTypeToolStripMenuItem";
            this.seatTypeToolStripMenuItem.Size = new System.Drawing.Size(88, 26);
            this.seatTypeToolStripMenuItem.Text = "Seat Type";
            // 
            // addSeatTypeToolStripMenuItem
            // 
            this.addSeatTypeToolStripMenuItem.Name = "addSeatTypeToolStripMenuItem";
            this.addSeatTypeToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.addSeatTypeToolStripMenuItem.Text = "Add Seat Type";
            this.addSeatTypeToolStripMenuItem.Click += new System.EventHandler(this.addSeatTypeToolStripMenuItem_Click);
            // 
            // updateSeatTypeToolStripMenuItem
            // 
            this.updateSeatTypeToolStripMenuItem.Name = "updateSeatTypeToolStripMenuItem";
            this.updateSeatTypeToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.updateSeatTypeToolStripMenuItem.Text = "Update Seat Type";
            this.updateSeatTypeToolStripMenuItem.Click += new System.EventHandler(this.updateSeatTypeToolStripMenuItem_Click);
            // 
            // matchesToolStripMenuItem
            // 
            this.matchesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleMatchToolStripMenuItem,
            this.manageSalesToolStripMenuItem});
            this.matchesToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchesToolStripMenuItem.Name = "matchesToolStripMenuItem";
            this.matchesToolStripMenuItem.Size = new System.Drawing.Size(78, 26);
            this.matchesToolStripMenuItem.Text = "Matches";
            // 
            // scheduleMatchToolStripMenuItem
            // 
            this.scheduleMatchToolStripMenuItem.Name = "scheduleMatchToolStripMenuItem";
            this.scheduleMatchToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.scheduleMatchToolStripMenuItem.Text = "Schedule Match";
            this.scheduleMatchToolStripMenuItem.Click += new System.EventHandler(this.scheduleMatchToolStripMenuItem_Click);
            // 
            // manageSalesToolStripMenuItem
            // 
            this.manageSalesToolStripMenuItem.Name = "manageSalesToolStripMenuItem";
            this.manageSalesToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.manageSalesToolStripMenuItem.Text = "Manage Sales";
            this.manageSalesToolStripMenuItem.Click += new System.EventHandler(this.manageSalesToolStripMenuItem_Click);
            // 
            // ticketsToolStripMenuItem
            // 
            this.ticketsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processSalesToolStripMenuItem,
            this.returnTicketsToolStripMenuItem,
            this.checkAvailToolStripMenuItem});
            this.ticketsToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketsToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            this.ticketsToolStripMenuItem.Size = new System.Drawing.Size(68, 26);
            this.ticketsToolStripMenuItem.Text = "Tickets";
            // 
            // processSalesToolStripMenuItem
            // 
            this.processSalesToolStripMenuItem.Name = "processSalesToolStripMenuItem";
            this.processSalesToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.processSalesToolStripMenuItem.Text = "Process Sales";
            this.processSalesToolStripMenuItem.Click += new System.EventHandler(this.processSalesToolStripMenuItem_Click);
            // 
            // returnTicketsToolStripMenuItem
            // 
            this.returnTicketsToolStripMenuItem.Name = "returnTicketsToolStripMenuItem";
            this.returnTicketsToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.returnTicketsToolStripMenuItem.Text = "Return Tickets";
            this.returnTicketsToolStripMenuItem.Click += new System.EventHandler(this.returnTicketsToolStripMenuItem_Click);
            // 
            // checkAvailToolStripMenuItem
            // 
            this.checkAvailToolStripMenuItem.Name = "checkAvailToolStripMenuItem";
            this.checkAvailToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.checkAvailToolStripMenuItem.Text = "Check Availability";
            this.checkAvailToolStripMenuItem.Click += new System.EventHandler(this.checkAvailToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yearlyRevenueAnalysisToolStripMenuItem,
            this.seatsToolStripMenuItem});
            this.adminToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(69, 26);
            this.adminToolStripMenuItem.Text = " Admin";
            // 
            // yearlyRevenueAnalysisToolStripMenuItem
            // 
            this.yearlyRevenueAnalysisToolStripMenuItem.Name = "yearlyRevenueAnalysisToolStripMenuItem";
            this.yearlyRevenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.yearlyRevenueAnalysisToolStripMenuItem.Text = "Yearly Revenue Analysis";
            this.yearlyRevenueAnalysisToolStripMenuItem.Click += new System.EventHandler(this.yearlyRevenueAnalysisToolStripMenuItem_Click);
            // 
            // seatsToolStripMenuItem
            // 
            this.seatsToolStripMenuItem.Name = "seatsToolStripMenuItem";
            this.seatsToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.seatsToolStripMenuItem.Text = "Seats sold per Match";
            this.seatsToolStripMenuItem.Click += new System.EventHandler(this.seatsToolStripMenuItem_Click);
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seatTypeToolStripMenuItem,
            this.matchesToolStripMenuItem,
            this.ticketsToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuMainMenu.Size = new System.Drawing.Size(941, 30);
            this.mnuMainMenu.TabIndex = 1;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 521);
            this.Controls.Add(this.picMainMenu);
            this.Controls.Add(this.mnuMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMainMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Tickets Retail - [Main Menu]";
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenu)).EndInit();
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMainMenu;
        private System.Windows.Forms.ToolStripMenuItem seatTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem addSeatTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSeatTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleMatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnTicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkAvailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearlyRevenueAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seatsToolStripMenuItem;
    }
}


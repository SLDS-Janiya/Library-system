namespace library_Managmet_System
{
    partial class Mainmenu
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
            this.lblwelcom = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookT = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMemberT = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PIMReternbook = new System.Windows.Forms.ToolStripMenuItem();
            this.completBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sysremToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblwelcom
            // 
            this.lblwelcom.AutoSize = true;
            this.lblwelcom.BackColor = System.Drawing.Color.Transparent;
            this.lblwelcom.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcom.ForeColor = System.Drawing.Color.DeepPink;
            this.lblwelcom.Location = new System.Drawing.Point(16, 487);
            this.lblwelcom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblwelcom.Name = "lblwelcom";
            this.lblwelcom.Size = new System.Drawing.Size(0, 32);
            this.lblwelcom.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.IndianRed;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.memberToolStripMenuItem,
            this.issueBookToolStripMenuItem,
            this.PIMReternbook,
            this.completBookToolStripMenuItem,
            this.userToolStripMenuItem,
            this.sysremToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1201, 43);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookT,
            this.viewBookToolStripMenuItem});
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(92, 39);
            this.bookToolStripMenuItem.Text = "Book";
            this.bookToolStripMenuItem.Click += new System.EventHandler(this.bookToolStripMenuItem_Click);
            // 
            // addBookT
            // 
            this.addBookT.BackColor = System.Drawing.Color.SandyBrown;
            this.addBookT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addBookT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBookT.Name = "addBookT";
            this.addBookT.Size = new System.Drawing.Size(236, 40);
            this.addBookT.Text = "Add Book";
            this.addBookT.Click += new System.EventHandler(this.addBookT_Click);
            // 
            // viewBookToolStripMenuItem
            // 
            this.viewBookToolStripMenuItem.BackColor = System.Drawing.Color.SandyBrown;
            this.viewBookToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewBookToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.viewBookToolStripMenuItem.Name = "viewBookToolStripMenuItem";
            this.viewBookToolStripMenuItem.Size = new System.Drawing.Size(236, 40);
            this.viewBookToolStripMenuItem.Text = "View Book";
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.memberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMemberT,
            this.viewMemberToolStripMenuItem});
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(134, 39);
            this.memberToolStripMenuItem.Text = "Member";
            // 
            // addMemberT
            // 
            this.addMemberT.BackColor = System.Drawing.Color.DarkOrange;
            this.addMemberT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addMemberT.Name = "addMemberT";
            this.addMemberT.Size = new System.Drawing.Size(278, 40);
            this.addMemberT.Text = "Add Member";
            // 
            // viewMemberToolStripMenuItem
            // 
            this.viewMemberToolStripMenuItem.BackColor = System.Drawing.Color.DarkOrange;
            this.viewMemberToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewMemberToolStripMenuItem.Name = "viewMemberToolStripMenuItem";
            this.viewMemberToolStripMenuItem.Size = new System.Drawing.Size(278, 40);
            this.viewMemberToolStripMenuItem.Text = "View Member";
            // 
            // issueBookToolStripMenuItem
            // 
            this.issueBookToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.issueBookToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.issueBookToolStripMenuItem.Name = "issueBookToolStripMenuItem";
            this.issueBookToolStripMenuItem.Size = new System.Drawing.Size(166, 39);
            this.issueBookToolStripMenuItem.Text = "Issue Book";
            this.issueBookToolStripMenuItem.Click += new System.EventHandler(this.issueBookToolStripMenuItem_Click_1);
            // 
            // PIMReternbook
            // 
            this.PIMReternbook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PIMReternbook.Name = "PIMReternbook";
            this.PIMReternbook.Size = new System.Drawing.Size(186, 39);
            this.PIMReternbook.Text = "Retern Book";
            // 
            // completBookToolStripMenuItem
            // 
            this.completBookToolStripMenuItem.Checked = true;
            this.completBookToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.completBookToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.completBookToolStripMenuItem.Name = "completBookToolStripMenuItem";
            this.completBookToolStripMenuItem.Size = new System.Drawing.Size(211, 39);
            this.completBookToolStripMenuItem.Text = "Complet Book ";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userRegistrationToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(88, 39);
            this.userToolStripMenuItem.Text = "User";
            // 
            // userRegistrationToolStripMenuItem
            // 
            this.userRegistrationToolStripMenuItem.BackColor = System.Drawing.Color.LimeGreen;
            this.userRegistrationToolStripMenuItem.Name = "userRegistrationToolStripMenuItem";
            this.userRegistrationToolStripMenuItem.Size = new System.Drawing.Size(330, 40);
            this.userRegistrationToolStripMenuItem.Text = "User Registration";
            // 
            // sysremToolStripMenuItem
            // 
            this.sysremToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.sysremToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sysremToolStripMenuItem.Name = "sysremToolStripMenuItem";
            this.sysremToolStripMenuItem.Size = new System.Drawing.Size(121, 39);
            this.sysremToolStripMenuItem.Text = "System";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(224, 40);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Crimson;
            this.exitToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 40);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // Mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::library_Managmet_System.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1201, 565);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblwelcom);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mainmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.Mainmenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblwelcom;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookT;
        private System.Windows.Forms.ToolStripMenuItem viewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMemberT;
        private System.Windows.Forms.ToolStripMenuItem viewMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PIMReternbook;
        private System.Windows.Forms.ToolStripMenuItem completBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sysremToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}
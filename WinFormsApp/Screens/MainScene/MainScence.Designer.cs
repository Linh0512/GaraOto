namespace WinFormsApp
{
    partial class MainScence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScence));
            panel1 = new Panel();
            panel8 = new Panel();
            bnOption = new Button();
            panel7 = new Panel();
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            bnMainExit = new Button();
            panel6 = new Panel();
            bnStatistic = new Button();
            panel4 = new Panel();
            bnStaff = new Button();
            panel5 = new Panel();
            bnInventory = new Button();
            panel3 = new Panel();
            bnService = new Button();
            panel2 = new Panel();
            bnHome = new Button();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(bnMainExit);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(195, 801);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel8
            // 
            panel8.Controls.Add(bnOption);
            panel8.Location = new Point(4, 462);
            panel8.Name = "panel8";
            panel8.Size = new Size(189, 52);
            panel8.TabIndex = 7;
            // 
            // bnOption
            // 
            bnOption.Anchor = AnchorStyles.None;
            bnOption.Location = new Point(45, 20);
            bnOption.Name = "bnOption";
            bnOption.Size = new Size(94, 29);
            bnOption.TabIndex = 0;
            bnOption.Text = "Option";
            bnOption.UseVisualStyleBackColor = true;
            bnOption.Click += bnOption_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Azure;
            panel7.Controls.Add(menuStrip1);
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(237, 28);
            panel7.TabIndex = 6;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, profileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(237, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(67, 24);
            adminToolStripMenuItem.Text = "Admin";
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logOutToolStripMenuItem });
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(66, 24);
            profileToolStripMenuItem.Text = "Profile";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(145, 26);
            logOutToolStripMenuItem.Text = "Log Out";
            // 
            // bnMainExit
            // 
            bnMainExit.BackColor = Color.DeepSkyBlue;
            bnMainExit.Location = new Point(21, 627);
            bnMainExit.Name = "bnMainExit";
            bnMainExit.Size = new Size(112, 30);
            bnMainExit.TabIndex = 5;
            bnMainExit.Text = "Exit";
            bnMainExit.UseVisualStyleBackColor = false;
            bnMainExit.Click += bnMainExit_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(bnStatistic);
            panel6.Location = new Point(4, 404);
            panel6.Name = "panel6";
            panel6.Size = new Size(189, 52);
            panel6.TabIndex = 4;
            // 
            // bnStatistic
            // 
            bnStatistic.Anchor = AnchorStyles.None;
            bnStatistic.Location = new Point(45, 20);
            bnStatistic.Name = "bnStatistic";
            bnStatistic.Size = new Size(94, 29);
            bnStatistic.TabIndex = 0;
            bnStatistic.Text = "Statistic";
            bnStatistic.UseVisualStyleBackColor = true;
            bnStatistic.Click += bnStatistic_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(bnStaff);
            panel4.Location = new Point(4, 346);
            panel4.Name = "panel4";
            panel4.Size = new Size(189, 52);
            panel4.TabIndex = 3;
            // 
            // bnStaff
            // 
            bnStaff.Anchor = AnchorStyles.None;
            bnStaff.Location = new Point(45, 20);
            bnStaff.Name = "bnStaff";
            bnStaff.Size = new Size(94, 29);
            bnStaff.TabIndex = 0;
            bnStaff.Text = "Staff";
            bnStaff.UseVisualStyleBackColor = true;
            bnStaff.Click += bnStaff_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(bnInventory);
            panel5.Location = new Point(4, 288);
            panel5.Name = "panel5";
            panel5.Size = new Size(189, 52);
            panel5.TabIndex = 2;
            // 
            // bnInventory
            // 
            bnInventory.Anchor = AnchorStyles.None;
            bnInventory.Location = new Point(45, 20);
            bnInventory.Name = "bnInventory";
            bnInventory.Size = new Size(94, 29);
            bnInventory.TabIndex = 0;
            bnInventory.Text = "Inventory";
            bnInventory.UseVisualStyleBackColor = true;
            bnInventory.Click += bnInventory_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(bnService);
            panel3.Location = new Point(4, 230);
            panel3.Name = "panel3";
            panel3.Size = new Size(189, 52);
            panel3.TabIndex = 1;
            // 
            // bnService
            // 
            bnService.Anchor = AnchorStyles.None;
            bnService.Location = new Point(45, 20);
            bnService.Name = "bnService";
            bnService.Size = new Size(94, 29);
            bnService.TabIndex = 0;
            bnService.Text = "Service";
            bnService.UseVisualStyleBackColor = true;
            bnService.Click += bnService_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(bnHome);
            panel2.Location = new Point(4, 172);
            panel2.Name = "panel2";
            panel2.Size = new Size(189, 52);
            panel2.TabIndex = 0;
            // 
            // bnHome
            // 
            bnHome.Anchor = AnchorStyles.None;
            bnHome.Location = new Point(45, 20);
            bnHome.Name = "bnHome";
            bnHome.Size = new Size(94, 29);
            bnHome.TabIndex = 0;
            bnHome.Text = "Home";
            bnHome.UseVisualStyleBackColor = true;
            bnHome.Click += bnHome_Click;
            // 
            // MainScence
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1509, 801);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainScence";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AdmissionGaraOto";
            Load += MainScence_Load;
            panel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button bnService;
        private Button bnHome;
        private Panel panel4;
        private Button bnStaff;
        private Panel panel5;
        private Button bnInventory;
        private Panel panel6;
        private Button bnStatistic;
        private Button bnMainExit;
        private Panel panel7;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private Panel panel8;
        private Button bnOption;
    }
}
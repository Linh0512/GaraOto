namespace WinFormsApp.Screens.MainScene
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
            btnOption = new Button();
            bnStaff = new Button();
            bnInventory = new Button();
            bnService = new Button();
            bnHome = new Button();
            bnMainExit = new Button();
            mnStripStatistic = new MenuStrip();
            báoCáoToolStripMenuItem = new ToolStripMenuItem();
            bÁOCÁODOANHSỐToolStripMenuItem = new ToolStripMenuItem();
            bÁOCÁOTỒNKHOToolStripMenuItem = new ToolStripMenuItem();
            dateTimePicker1 = new DateTimePicker();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            mnStripStatistic.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(btnOption);
            panel1.Controls.Add(bnStaff);
            panel1.Controls.Add(bnInventory);
            panel1.Controls.Add(bnService);
            panel1.Controls.Add(bnHome);
            panel1.Controls.Add(bnMainExit);
            panel1.Controls.Add(mnStripStatistic);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 641);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnOption
            // 
            btnOption.BackColor = Color.OldLace;
            btnOption.Location = new Point(38, 446);
            btnOption.Name = "btnOption";
            btnOption.Size = new Size(105, 54);
            btnOption.TabIndex = 5;
            btnOption.Text = "CÀI ĐẶT";
            btnOption.UseVisualStyleBackColor = false;
            btnOption.Click += btnOption_Click;
            // 
            // bnStaff
            // 
            bnStaff.Anchor = AnchorStyles.None;
            bnStaff.BackColor = Color.OldLace;
            bnStaff.Location = new Point(38, 316);
            bnStaff.Margin = new Padding(2);
            bnStaff.Name = "bnStaff";
            bnStaff.Size = new Size(105, 55);
            bnStaff.TabIndex = 3;
            bnStaff.Text = "NHÂN VIÊN";
            bnStaff.UseVisualStyleBackColor = false;
            bnStaff.Click += bnStaff_Click;
            // 
            // bnInventory
            // 
            bnInventory.Anchor = AnchorStyles.None;
            bnInventory.BackColor = Color.OldLace;
            bnInventory.Location = new Point(38, 243);
            bnInventory.Margin = new Padding(2);
            bnInventory.Name = "bnInventory";
            bnInventory.Size = new Size(105, 54);
            bnInventory.TabIndex = 2;
            bnInventory.Text = "KHO HÀNG";
            bnInventory.UseVisualStyleBackColor = false;
            bnInventory.Click += bnInventory_Click;
            // 
            // bnService
            // 
            bnService.Anchor = AnchorStyles.None;
            bnService.BackColor = Color.OldLace;
            bnService.Location = new Point(38, 168);
            bnService.Margin = new Padding(2);
            bnService.Name = "bnService";
            bnService.Size = new Size(105, 55);
            bnService.TabIndex = 1;
            bnService.Text = "DỊCH VỤ";
            bnService.UseVisualStyleBackColor = false;
            bnService.Click += bnService_Click;
            // 
            // bnHome
            // 
            bnHome.Anchor = AnchorStyles.None;
            bnHome.BackColor = Color.OldLace;
            bnHome.Location = new Point(38, 104);
            bnHome.Margin = new Padding(2);
            bnHome.Name = "bnHome";
            bnHome.Size = new Size(105, 47);
            bnHome.TabIndex = 0;
            bnHome.Text = "TRANG CHỦ";
            bnHome.UseVisualStyleBackColor = false;
            bnHome.Click += bnHome_Click;
            // 
            // bnMainExit
            // 
            bnMainExit.BackColor = Color.DeepSkyBlue;
            bnMainExit.Location = new Point(38, 579);
            bnMainExit.Margin = new Padding(2);
            bnMainExit.Name = "bnMainExit";
            bnMainExit.Size = new Size(103, 51);
            bnMainExit.TabIndex = 6;
            bnMainExit.Text = "THOÁT";
            bnMainExit.UseVisualStyleBackColor = false;
            bnMainExit.Click += bnMainExit_Click;
            // 
            // mnStripStatistic
            // 
            mnStripStatistic.BackColor = Color.OldLace;
            mnStripStatistic.Dock = DockStyle.None;
            mnStripStatistic.ImageScalingSize = new Size(20, 20);
            mnStripStatistic.Items.AddRange(new ToolStripItem[] { báoCáoToolStripMenuItem });
            mnStripStatistic.Location = new Point(38, 393);
            mnStripStatistic.Name = "mnStripStatistic";
            mnStripStatistic.Size = new Size(103, 28);
            mnStripStatistic.TabIndex = 4;
            mnStripStatistic.Text = "Báo cáo";
            // 
            // báoCáoToolStripMenuItem
            // 
            báoCáoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bÁOCÁODOANHSỐToolStripMenuItem, bÁOCÁOTỒNKHOToolStripMenuItem });
            báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            báoCáoToolStripMenuItem.Size = new Size(95, 24);
            báoCáoToolStripMenuItem.Text = "THỐNG KÊ";
            // 
            // bÁOCÁODOANHSỐToolStripMenuItem
            // 
            bÁOCÁODOANHSỐToolStripMenuItem.Name = "bÁOCÁODOANHSỐToolStripMenuItem";
            bÁOCÁODOANHSỐToolStripMenuItem.Size = new Size(237, 26);
            bÁOCÁODOANHSỐToolStripMenuItem.Text = "BÁO CÁO DOANH SỐ";
            bÁOCÁODOANHSỐToolStripMenuItem.Click += bÁOCÁODOANHSỐToolStripMenuItem_Click;
            // 
            // bÁOCÁOTỒNKHOToolStripMenuItem
            // 
            bÁOCÁOTỒNKHOToolStripMenuItem.Name = "bÁOCÁOTỒNKHOToolStripMenuItem";
            bÁOCÁOTỒNKHOToolStripMenuItem.Size = new Size(237, 26);
            bÁOCÁOTỒNKHOToolStripMenuItem.Text = "BÁO CÁO TỒN KHO";
            bÁOCÁOTỒNKHOToolStripMenuItem.Click += bÁOCÁOTỒNKHOToolStripMenuItem_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(5, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(182, 27);
            dateTimePicker1.TabIndex = 9;
            dateTimePicker1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CadetBlue;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(190, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1017, 73);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.CadetBlue;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(354, 9);
            label1.Name = "label1";
            label1.Size = new Size(318, 56);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ GARA";
            // 
            // MainScence
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 641);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1225, 688);
            MinimumSize = new Size(1225, 688);
            Name = "MainScence";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PHẦN MỀM QUẢN LÝ GARAOTO";
            Load += MainScence_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            mnStripStatistic.ResumeLayout(false);
            mnStripStatistic.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Button bnService;
        private Button bnHome;
        private Button bnStaff;
        private Button bnInventory;
        private System.Windows.Forms.Button bnMainExit;
        private MenuStrip mnStripStatistic;
        private ToolStripMenuItem báoCáoToolStripMenuItem;
        private ToolStripMenuItem bÁOCÁODOANHSỐToolStripMenuItem;
        private ToolStripMenuItem bÁOCÁOTỒNKHOToolStripMenuItem;
        private Button btnOption;
        private DateTimePicker dateTimePicker1;
        private Panel panel2;
        private Label label1;
    }
}
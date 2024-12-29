namespace WinFormsApp.Screens.fInventory
{
    partial class history
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(history));
            btn_close = new Button();
            a = new Label();
            dgvHistory = new DataGridView();
            txt_code = new TextBox();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            btnRefresh = new Button();
            button4 = new Button();
            radiobtncode = new RadioButton();
            radiobtnNgayLap = new RadioButton();
            dtpFindDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_close
            // 
            btn_close.Anchor = AnchorStyles.None;
            btn_close.AutoSize = true;
            btn_close.BackColor = SystemColors.GrayText;
            btn_close.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_close.ForeColor = Color.White;
            btn_close.Location = new Point(1094, 811);
            btn_close.Margin = new Padding(2, 3, 2, 3);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(130, 47);
            btn_close.TabIndex = 0;
            btn_close.Text = "Đóng";
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // a
            // 
            a.AutoSize = true;
            a.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            a.ForeColor = SystemColors.ButtonHighlight;
            a.Location = new Point(70, 17);
            a.Margin = new Padding(2, 0, 2, 0);
            a.Name = "a";
            a.Size = new Size(988, 54);
            a.TabIndex = 1;
            a.Text = "DANH SÁCH PHIẾU NHẬP KHO VẬT TƯ PHỤ TÙNG";
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.Anchor = AnchorStyles.None;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.GrayText;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(0, 206);
            dgvHistory.Margin = new Padding(2, 3, 2, 3);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.RowHeadersWidth = 51;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.Size = new Size(1166, 555);
            dgvHistory.TabIndex = 2;
            dgvHistory.CellContentClick += dgvHistory_CellContentClick;
            // 
            // txt_code
            // 
            txt_code.Anchor = AnchorStyles.None;
            txt_code.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_code.Location = new Point(26, 81);
            txt_code.Margin = new Padding(2, 3, 2, 3);
            txt_code.Name = "txt_code";
            txt_code.PlaceholderText = "Mã phiếu nhập, nhân viên tạo phiếu nhập";
            txt_code.Size = new Size(742, 34);
            txt_code.TabIndex = 13;
            txt_code.TextChanged += txt_code_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GrayText;
            panel2.Controls.Add(a);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1166, 71);
            panel2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSize = true;
            button1.BackColor = SystemColors.GrayText;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(820, 75);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(130, 41);
            button1.TabIndex = 14;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.AutoSize = true;
            button2.BackColor = Color.Green;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1018, 74);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(137, 41);
            button2.TabIndex = 15;
            button2.Text = "Xuất";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.None;
            btnRefresh.AutoSize = true;
            btnRefresh.BackColor = SystemColors.Desktop;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(820, 129);
            btnRefresh.Margin = new Padding(2, 3, 2, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(130, 41);
            btnRefresh.TabIndex = 16;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.AutoSize = true;
            button4.BackColor = SystemColors.HotTrack;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(1018, 129);
            button4.Margin = new Padding(2, 3, 2, 3);
            button4.Name = "button4";
            button4.Size = new Size(137, 41);
            button4.TabIndex = 17;
            button4.Text = "Xem chi tiết";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // radiobtncode
            // 
            radiobtncode.AutoSize = true;
            radiobtncode.Checked = true;
            radiobtncode.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radiobtncode.Location = new Point(26, 138);
            radiobtncode.Margin = new Padding(2);
            radiobtncode.Name = "radiobtncode";
            radiobtncode.Size = new Size(333, 27);
            radiobtncode.TabIndex = 18;
            radiobtncode.TabStop = true;
            radiobtncode.Text = "Tìm theo mã phiếu nhập, nhà cung cấp";
            radiobtncode.UseVisualStyleBackColor = true;
            radiobtncode.CheckedChanged += radiobtncode_CheckedChanged;
            // 
            // radiobtnNgayLap
            // 
            radiobtnNgayLap.AutoSize = true;
            radiobtnNgayLap.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radiobtnNgayLap.Location = new Point(396, 138);
            radiobtnNgayLap.Margin = new Padding(2);
            radiobtnNgayLap.Name = "radiobtnNgayLap";
            radiobtnNgayLap.Size = new Size(217, 27);
            radiobtnNgayLap.TabIndex = 19;
            radiobtnNgayLap.Text = "Tìm theo ngày lập phiếu";
            radiobtnNgayLap.UseVisualStyleBackColor = true;
            // 
            // dtpFindDate
            // 
            dtpFindDate.Anchor = AnchorStyles.None;
            dtpFindDate.Format = DateTimePickerFormat.Short;
            dtpFindDate.Location = new Point(626, 137);
            dtpFindDate.Margin = new Padding(2, 3, 2, 3);
            dtpFindDate.Name = "dtpFindDate";
            dtpFindDate.Size = new Size(142, 27);
            dtpFindDate.TabIndex = 20;
            // 
            // history
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1166, 763);
            Controls.Add(dtpFindDate);
            Controls.Add(radiobtnNgayLap);
            Controls.Add(radiobtncode);
            Controls.Add(button4);
            Controls.Add(btnRefresh);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(txt_code);
            Controls.Add(dgvHistory);
            Controls.Add(btn_close);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1184, 810);
            MinimumSize = new Size(1184, 810);
            Name = "history";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DANH SÁCH PHIẾU NHẬP KHO VẬT TƯ PHỤ TÙNG";
            Load += History_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btn_close;
        private Label a;
        private DataGridView dgvHistory;
        private Panel panel2;
        private TextBox txt_code;
        private Button button1;
        private Button button2;
        private Button btnRefresh;
        private Button button4;
        private System.Windows.Forms.RadioButton radiobtncode;
        private RadioButton radiobtnNgayLap;
        private DateTimePicker dtpFindDate;
    }
}
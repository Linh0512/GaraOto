using System.ComponentModel;

namespace WinFormsApp.Screens.fReport;

partial class fBaoCaoDS
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(fBaoCaoDS));
        label1 = new Label();
        groupBox1 = new GroupBox();
        numericMonth = new NumericUpDown();
        btnShowBCDS = new Button();
        numericYear = new NumericUpDown();
        label3 = new Label();
        label2 = new Label();
        label4 = new Label();
        tb_TongDTHU = new TextBox();
        tableBCDS = new DataGridView();
        HieuXe = new DataGridViewTextBoxColumn();
        SoLuotSua = new DataGridViewTextBoxColumn();
        ThanhTien = new DataGridViewTextBoxColumn();
        TiLe = new DataGridViewTextBoxColumn();
        btnExit = new Button();
        groupBox2 = new GroupBox();
        MaVTPT = new DataGridViewColumn();
        TenVTPT = new DataGridViewColumn();
        TonDau = new DataGridViewColumn();
        PhatSinh = new DataGridViewColumn();
        SuDung = new DataGridViewColumn();
        TonCuoi = new DataGridViewColumn();
        groupBox1.SuspendLayout();
        ((ISupportInitialize)numericMonth).BeginInit();
        ((ISupportInitialize)numericYear).BeginInit();
        ((ISupportInitialize)tableBCDS).BeginInit();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.BackColor = SystemColors.MenuHighlight;
        label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        label1.ForeColor = SystemColors.Window;
        label1.Location = new Point(-2, 0);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(993, 58);
        label1.TabIndex = 4;
        label1.Text = "BÁO CÁO DOANH SỐ";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        label1.Click += label1_Click;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(numericMonth);
        groupBox1.Controls.Add(btnShowBCDS);
        groupBox1.Controls.Add(numericYear);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label2);
        groupBox1.Font = new Font("Segoe UI", 12F);
        groupBox1.Location = new Point(8, 60);
        groupBox1.Margin = new Padding(2);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(2);
        groupBox1.Size = new Size(892, 85);
        groupBox1.TabIndex = 5;
        groupBox1.TabStop = false;
        groupBox1.Text = "Báo cáo doanh số";
        groupBox1.Enter += groupBox1_Enter;
        // 
        // numericMonth
        // 
        numericMonth.Location = new Point(98, 36);
        numericMonth.Margin = new Padding(2);
        numericMonth.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
        numericMonth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numericMonth.Name = "numericMonth";
        numericMonth.Size = new Size(84, 34);
        numericMonth.TabIndex = 5;
        numericMonth.Value = new decimal(new int[] { 1, 0, 0, 0 });
        numericMonth.ValueChanged += numericMonth_ValueChanged;
        // 
        // btnShowBCDS
        // 
        btnShowBCDS.Location = new Point(707, 16);
        btnShowBCDS.Margin = new Padding(2);
        btnShowBCDS.Name = "btnShowBCDS";
        btnShowBCDS.Size = new Size(181, 65);
        btnShowBCDS.TabIndex = 4;
        btnShowBCDS.Text = "Hiện Báo Cáo";
        btnShowBCDS.UseVisualStyleBackColor = true;
        btnShowBCDS.Click += btnShowBCDS_Click;
        // 
        // numericYear
        // 
        numericYear.Location = new Point(284, 36);
        numericYear.Margin = new Padding(2);
        numericYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
        numericYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
        numericYear.Name = "numericYear";
        numericYear.Size = new Size(98, 34);
        numericYear.TabIndex = 3;
        numericYear.Value = new decimal(new int[] { 2024, 0, 0, 0 });
        numericYear.ValueChanged += numericYear_ValueChanged;
        // 
        // label3
        // 
        label3.Font = new Font("Segoe UI", 14F);
        label3.Location = new Point(215, 34);
        label3.Margin = new Padding(2, 0, 2, 0);
        label3.Name = "label3";
        label3.Size = new Size(66, 26);
        label3.TabIndex = 2;
        label3.Text = "Năm: ";
        label3.Click += label3_Click;
        // 
        // label2
        // 
        label2.Font = new Font("Segoe UI", 14F);
        label2.Location = new Point(16, 36);
        label2.Margin = new Padding(2, 0, 2, 0);
        label2.Name = "label2";
        label2.Size = new Size(78, 26);
        label2.TabIndex = 0;
        label2.Text = "Tháng:";
        label2.Click += label2_Click;
        // 
        // label4
        // 
        label4.Font = new Font("Segoe UI", 14F);
        label4.Location = new Point(228, 560);
        label4.Margin = new Padding(2, 0, 2, 0);
        label4.Name = "label4";
        label4.Size = new Size(162, 26);
        label4.TabIndex = 5;
        label4.Text = "Tổng Doanh Thu:";
        label4.Click += label4_Click;
        // 
        // tb_TongDTHU
        // 
        tb_TongDTHU.Location = new Point(411, 560);
        tb_TongDTHU.Margin = new Padding(2);
        tb_TongDTHU.Name = "tb_TongDTHU";
        tb_TongDTHU.Size = new Size(264, 27);
        tb_TongDTHU.TabIndex = 7;
        tb_TongDTHU.TextChanged += textBox1_TextChanged;
        // 
        // tableBCDS
        // 
        tableBCDS.AllowUserToAddRows = false;
        tableBCDS.AllowUserToDeleteRows = false;
        tableBCDS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        tableBCDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tableBCDS.Columns.AddRange(new DataGridViewColumn[] { HieuXe, SoLuotSua, ThanhTien, TiLe });
        tableBCDS.Location = new Point(4, 24);
        tableBCDS.Margin = new Padding(2);
        tableBCDS.Name = "tableBCDS";
        tableBCDS.ReadOnly = true;
        tableBCDS.RowHeadersWidth = 62;
        tableBCDS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        tableBCDS.Size = new Size(966, 378);
        tableBCDS.TabIndex = 1;
        tableBCDS.CellContentClick += tableBCDS_CellContentClick;
        // 
        // HieuXe
        // 
        HieuXe.HeaderText = "Hiệu Xe";
        HieuXe.MinimumWidth = 8;
        HieuXe.Name = "HieuXe";
        HieuXe.ReadOnly = true;
        // 
        // SoLuotSua
        // 
        SoLuotSua.HeaderText = "Số Lượt Sửa";
        SoLuotSua.MinimumWidth = 8;
        SoLuotSua.Name = "SoLuotSua";
        SoLuotSua.ReadOnly = true;
        // 
        // ThanhTien
        // 
        ThanhTien.HeaderText = "Thành Tiền";
        ThanhTien.MinimumWidth = 8;
        ThanhTien.Name = "ThanhTien";
        ThanhTien.ReadOnly = true;
        // 
        // TiLe
        // 
        TiLe.HeaderText = "Tỉ Lệ";
        TiLe.MinimumWidth = 8;
        TiLe.Name = "TiLe";
        TiLe.ReadOnly = true;
        // 
        // btnExit
        // 
        btnExit.Location = new Point(768, 560);
        btnExit.Margin = new Padding(2);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(87, 50);
        btnExit.TabIndex = 9;
        btnExit.Text = "Thoát";
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += btnExit_Click;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(tableBCDS);
        groupBox2.Font = new Font("Segoe UI", 12F);
        groupBox2.Location = new Point(8, 149);
        groupBox2.Margin = new Padding(2);
        groupBox2.Name = "groupBox2";
        groupBox2.Padding = new Padding(2);
        groupBox2.Size = new Size(974, 410);
        groupBox2.TabIndex = 10;
        groupBox2.TabStop = false;
        groupBox2.Text = "Chi tiết báo cáo";
        groupBox2.Enter += groupBox2_Enter;
        // 
        // MaVTPT
        // 
        MaVTPT.HeaderText = "Mã VTPT";
        MaVTPT.MinimumWidth = 8;
        MaVTPT.Name = "MaVTPT";
        MaVTPT.ReadOnly = true;
        MaVTPT.Width = 150;
        // 
        // TenVTPT
        // 
        TenVTPT.HeaderText = "Tên VTPT";
        TenVTPT.MinimumWidth = 8;
        TenVTPT.Name = "TenVTPT";
        TenVTPT.ReadOnly = true;
        TenVTPT.Width = 150;
        // 
        // TonDau
        // 
        TonDau.HeaderText = "Tồn Đầu";
        TonDau.MinimumWidth = 8;
        TonDau.Name = "TonDau";
        TonDau.ReadOnly = true;
        TonDau.Width = 150;
        // 
        // PhatSinh
        // 
        PhatSinh.HeaderText = "Phát Sinh";
        PhatSinh.MinimumWidth = 8;
        PhatSinh.Name = "PhatSinh";
        PhatSinh.ReadOnly = true;
        PhatSinh.Width = 150;
        // 
        // SuDung
        // 
        SuDung.HeaderText = "Sử Dụng";
        SuDung.MinimumWidth = 8;
        SuDung.Name = "SuDung";
        SuDung.ReadOnly = true;
        SuDung.Width = 150;
        // 
        // TonCuoi
        // 
        TonCuoi.HeaderText = "Tồn Cuối";
        TonCuoi.MinimumWidth = 8;
        TonCuoi.Name = "TonCuoi";
        TonCuoi.ReadOnly = true;
        TonCuoi.Width = 150;
        // 
        // fBaoCaoDS
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(990, 621);
        Controls.Add(groupBox2);
        Controls.Add(btnExit);
        Controls.Add(tb_TongDTHU);
        Controls.Add(label4);
        Controls.Add(groupBox1);
        Controls.Add(label1);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(2);
        MinimumSize = new Size(925, 605);
        Name = "fBaoCaoDS";
        StartPosition = FormStartPosition.CenterParent;
        Text = "BÁO CÁO DOANH SỐ";
        Load += fBaoCaoDS_Load;
        groupBox1.ResumeLayout(false);
        ((ISupportInitialize)numericMonth).EndInit();
        ((ISupportInitialize)numericYear).EndInit();
        ((ISupportInitialize)tableBCDS).EndInit();
        groupBox2.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.DataGridViewColumn TonDau;
    private System.Windows.Forms.DataGridViewColumn PhatSinh;
    private System.Windows.Forms.DataGridViewColumn SuDung;

    private System.Windows.Forms.DataGridViewColumn TonCuoi;

    private System.Windows.Forms.DataGridViewColumn MaVTPT;
    private System.Windows.Forms.DataGridViewColumn TenVTPT;

    private System.Windows.Forms.GroupBox groupBox2;

    private System.Windows.Forms.DataGridViewTextBoxColumn SoLuotSua;
    private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    private System.Windows.Forms.DataGridViewTextBoxColumn TiLe;

    private System.Windows.Forms.DataGridViewTextBoxColumn HieuXe;

    private System.Windows.Forms.Button btnExit;

    private System.Windows.Forms.DataGridView tableBCDS;

    private System.Windows.Forms.NumericUpDown numericMonth;

    private System.Windows.Forms.TextBox tb_TongDTHU;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Button btnShowBCDS;

    private System.Windows.Forms.NumericUpDown numericYear;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.Label label1;

    #endregion
}
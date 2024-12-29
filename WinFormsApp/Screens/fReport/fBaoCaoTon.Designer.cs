using System.ComponentModel;

namespace WinFormsApp.Screens.fReport;

partial class fBaoCaoTon
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(fBaoCaoTon));
        label1 = new Label();
        groupBox1 = new GroupBox();
        numericYear = new NumericUpDown();
        numericMonth = new NumericUpDown();
        label3 = new Label();
        label2 = new Label();
        btnShowBCTK = new Button();
        groupBox2 = new GroupBox();
        tableBCTK = new DataGridView();
        MaVTPT = new DataGridViewTextBoxColumn();
        TenVTPT = new DataGridViewTextBoxColumn();
        TonDau = new DataGridViewTextBoxColumn();
        SoLuongNhap = new DataGridViewTextBoxColumn();
        SoLuongSuDung = new DataGridViewTextBoxColumn();
        TonCuoi = new DataGridViewTextBoxColumn();
        btnExit = new Button();
        groupBox1.SuspendLayout();
        ((ISupportInitialize)numericYear).BeginInit();
        ((ISupportInitialize)numericMonth).BeginInit();
        groupBox2.SuspendLayout();
        ((ISupportInitialize)tableBCTK).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.BackColor = SystemColors.MenuHighlight;
        label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        label1.ForeColor = SystemColors.Window;
        label1.Location = new Point(-2, -2);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(1127, 77);
        label1.TabIndex = 0;
        label1.Text = "BÁO CÁO TỒN KHO";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(numericYear);
        groupBox1.Controls.Add(numericMonth);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(btnShowBCTK);
        groupBox1.Font = new Font("Segoe UI", 12F);
        groupBox1.Location = new Point(10, 77);
        groupBox1.Margin = new Padding(2);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(2);
        groupBox1.Size = new Size(1107, 119);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        groupBox1.Text = "Báo cáo tồn kho";
        groupBox1.Enter += groupBox1_Enter;
        // 
        // numericYear
        // 
        numericYear.Location = new Point(426, 49);
        numericYear.Margin = new Padding(2);
        numericYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
        numericYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
        numericYear.Name = "numericYear";
        numericYear.Size = new Size(142, 34);
        numericYear.TabIndex = 4;
        numericYear.Value = new decimal(new int[] { 2024, 0, 0, 0 });
        // 
        // numericMonth
        // 
        numericMonth.Location = new Point(140, 49);
        numericMonth.Margin = new Padding(2);
        numericMonth.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
        numericMonth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numericMonth.Name = "numericMonth";
        numericMonth.Size = new Size(125, 34);
        numericMonth.TabIndex = 3;
        numericMonth.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // label3
        // 
        label3.Location = new Point(341, 50);
        label3.Margin = new Padding(2, 0, 2, 0);
        label3.Name = "label3";
        label3.Size = new Size(80, 29);
        label3.TabIndex = 2;
        label3.Text = "Năm:";
        label3.Click += label3_Click;
        // 
        // label2
        // 
        label2.Location = new Point(55, 49);
        label2.Margin = new Padding(2, 0, 2, 0);
        label2.Name = "label2";
        label2.Size = new Size(80, 29);
        label2.TabIndex = 1;
        label2.Text = "Tháng:";
        // 
        // btnShowBCTK
        // 
        btnShowBCTK.Location = new Point(717, 25);
        btnShowBCTK.Margin = new Padding(2);
        btnShowBCTK.Name = "btnShowBCTK";
        btnShowBCTK.Size = new Size(222, 74);
        btnShowBCTK.TabIndex = 0;
        btnShowBCTK.Text = "Hiện báo cáo";
        btnShowBCTK.UseVisualStyleBackColor = true;
        btnShowBCTK.Click += btnShowBCTK_Click;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(tableBCTK);
        groupBox2.Font = new Font("Segoe UI", 12F);
        groupBox2.Location = new Point(10, 201);
        groupBox2.Margin = new Padding(2);
        groupBox2.Name = "groupBox2";
        groupBox2.Padding = new Padding(2);
        groupBox2.Size = new Size(1107, 398);
        groupBox2.TabIndex = 2;
        groupBox2.TabStop = false;
        groupBox2.Text = "Chi tiết báo cáo";
        // 
        // tableBCTK
        // 
        tableBCTK.AllowUserToAddRows = false;
        tableBCTK.AllowUserToDeleteRows = false;
        tableBCTK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        tableBCTK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tableBCTK.Columns.AddRange(new DataGridViewColumn[] { MaVTPT, TenVTPT, TonDau, SoLuongNhap, SoLuongSuDung, TonCuoi });
        tableBCTK.Location = new Point(5, 30);
        tableBCTK.Margin = new Padding(2);
        tableBCTK.Name = "tableBCTK";
        tableBCTK.RowHeadersWidth = 62;
        tableBCTK.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        tableBCTK.Size = new Size(1098, 363);
        tableBCTK.TabIndex = 1;
        // 
        // MaVTPT
        // 
        MaVTPT.HeaderText = "Mã VTPT";
        MaVTPT.MinimumWidth = 8;
        MaVTPT.Name = "MaVTPT";
        // 
        // TenVTPT
        // 
        TenVTPT.HeaderText = "Tên VTPT";
        TenVTPT.MinimumWidth = 8;
        TenVTPT.Name = "TenVTPT";
        // 
        // TonDau
        // 
        TonDau.HeaderText = "Tồn Đầu";
        TonDau.MinimumWidth = 8;
        TonDau.Name = "TonDau";
        // 
        // SoLuongNhap
        // 
        SoLuongNhap.HeaderText = "Số Lượng Nhập";
        SoLuongNhap.MinimumWidth = 8;
        SoLuongNhap.Name = "SoLuongNhap";
        // 
        // SoLuongSuDung
        // 
        SoLuongSuDung.HeaderText = "SoLuongSuDung";
        SoLuongSuDung.MinimumWidth = 8;
        SoLuongSuDung.Name = "SoLuongSuDung";
        // 
        // TonCuoi
        // 
        TonCuoi.HeaderText = "Tồn Cuối";
        TonCuoi.MinimumWidth = 8;
        TonCuoi.Name = "TonCuoi";
        // 
        // btnExit
        // 
        btnExit.BackColor = Color.Red;
        btnExit.Location = new Point(929, 598);
        btnExit.Margin = new Padding(2);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(101, 49);
        btnExit.TabIndex = 3;
        btnExit.Text = "Thoát";
        btnExit.UseVisualStyleBackColor = false;
        btnExit.Click += btnExit_Click_1;
        // 
        // fBaoCaoTon
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1126, 657);
        Controls.Add(btnExit);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Controls.Add(label1);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(2);
        MaximumSize = new Size(1144, 704);
        MinimumSize = new Size(1144, 704);
        Name = "fBaoCaoTon";
        StartPosition = FormStartPosition.CenterParent;
        Text = "BÁO CÁO TỒN KHO";
        groupBox1.ResumeLayout(false);
        ((ISupportInitialize)numericYear).EndInit();
        ((ISupportInitialize)numericMonth).EndInit();
        groupBox2.ResumeLayout(false);
        ((ISupportInitialize)tableBCTK).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridViewTextBoxColumn MaVTPT;
    private System.Windows.Forms.DataGridViewTextBoxColumn TenVTPT;
    private System.Windows.Forms.DataGridViewTextBoxColumn TonDau;
    private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNhap;
    private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongSuDung;
    private System.Windows.Forms.DataGridViewTextBoxColumn TonCuoi;

    private System.Windows.Forms.DataGridView tableBCTK;

    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Button btnShowBCTK;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.NumericUpDown numericMonth;
    private System.Windows.Forms.NumericUpDown numericYear;

    private System.Windows.Forms.GroupBox groupBox2;

    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.Label label1;

    #endregion
}
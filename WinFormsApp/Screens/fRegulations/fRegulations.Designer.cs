using System.ComponentModel;

namespace WinFormsApp.Screens;

partial class fRegulations
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(fRegulations));
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        cBChoPhep = new CheckBox();
        txtCarTodayLimit = new TextBox();
        btnUpdate = new Button();
        txtCarBrandLimit = new TextBox();
        txtTiLeLai = new TextBox();
        txtVTPTLimit = new TextBox();
        txtTienCongLimit = new TextBox();
        panel1 = new Panel();
        label6 = new Label();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(41, 116);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(234, 30);
        label1.TabIndex = 0;
        label1.Text = "Số xe tối đa nhận trong ngày";
        // 
        // label2
        // 
        label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(41, 190);
        label2.Margin = new Padding(2, 0, 2, 0);
        label2.Name = "label2";
        label2.Size = new Size(234, 30);
        label2.TabIndex = 1;
        label2.Text = "Số hiệu xe tối đa ";
        // 
        // label3
        // 
        label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label3.Location = new Point(41, 275);
        label3.Margin = new Padding(2, 0, 2, 0);
        label3.Name = "label3";
        label3.Size = new Size(234, 32);
        label3.TabIndex = 2;
        label3.Text = "Tỉ lệ lãi";
        // 
        // label4
        // 
        label4.Font = new Font("Segoe UI", 12F);
        label4.Location = new Point(40, 355);
        label4.Margin = new Padding(2, 0, 2, 0);
        label4.Name = "label4";
        label4.Size = new Size(235, 30);
        label4.TabIndex = 3;
        label4.Text = "Số VTPT tối đa";
        // 
        // label5
        // 
        label5.Font = new Font("Segoe UI", 12F);
        label5.Location = new Point(41, 434);
        label5.Margin = new Padding(2, 0, 2, 0);
        label5.Name = "label5";
        label5.Size = new Size(234, 30);
        label5.TabIndex = 4;
        label5.Text = "Số tiền công tối đa";
        // 
        // cBChoPhep
        // 
        cBChoPhep.Font = new Font("Segoe UI", 12F);
        cBChoPhep.Location = new Point(100, 488);
        cBChoPhep.Margin = new Padding(2);
        cBChoPhep.Name = "cBChoPhep";
        cBChoPhep.Size = new Size(261, 44);
        cBChoPhep.TabIndex = 5;
        cBChoPhep.Text = "Cho phép trả vượt số tiền nợ";
        cBChoPhep.TextAlign = ContentAlignment.MiddleCenter;
        cBChoPhep.UseVisualStyleBackColor = true;
        // 
        // txtCarTodayLimit
        // 
        txtCarTodayLimit.Location = new Point(279, 116);
        txtCarTodayLimit.Margin = new Padding(2);
        txtCarTodayLimit.Name = "txtCarTodayLimit";
        txtCarTodayLimit.Size = new Size(156, 30);
        txtCarTodayLimit.TabIndex = 6;
        // 
        // btnUpdate
        // 
        btnUpdate.BackColor = Color.BurlyWood;
        btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnUpdate.Location = new Point(153, 567);
        btnUpdate.Margin = new Padding(2);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(149, 54);
        btnUpdate.TabIndex = 11;
        btnUpdate.Text = "Cập nhập";
        btnUpdate.UseVisualStyleBackColor = false;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // txtCarBrandLimit
        // 
        txtCarBrandLimit.Location = new Point(279, 190);
        txtCarBrandLimit.Margin = new Padding(2);
        txtCarBrandLimit.Name = "txtCarBrandLimit";
        txtCarBrandLimit.Size = new Size(156, 30);
        txtCarBrandLimit.TabIndex = 12;
        // 
        // txtTiLeLai
        // 
        txtTiLeLai.Location = new Point(279, 277);
        txtTiLeLai.Margin = new Padding(2);
        txtTiLeLai.Name = "txtTiLeLai";
        txtTiLeLai.Size = new Size(156, 30);
        txtTiLeLai.TabIndex = 13;
        // 
        // txtVTPTLimit
        // 
        txtVTPTLimit.Location = new Point(279, 355);
        txtVTPTLimit.Margin = new Padding(2);
        txtVTPTLimit.Name = "txtVTPTLimit";
        txtVTPTLimit.Size = new Size(156, 30);
        txtVTPTLimit.TabIndex = 14;
        // 
        // txtTienCongLimit
        // 
        txtTienCongLimit.Location = new Point(279, 434);
        txtTienCongLimit.Margin = new Padding(2);
        txtTienCongLimit.Name = "txtTienCongLimit";
        txtTienCongLimit.Size = new Size(156, 30);
        txtTienCongLimit.TabIndex = 15;
        // 
        // panel1
        // 
        panel1.BackColor = Color.CadetBlue;
        panel1.Controls.Add(label6);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(478, 90);
        panel1.TabIndex = 16;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label6.Location = new Point(48, 21);
        label6.Name = "label6";
        label6.Size = new Size(387, 50);
        label6.TabIndex = 0;
        label6.Text = "THAY ĐỔI QUY ĐỊNH";
        // 
        // fRegulations
        // 
        AutoScaleDimensions = new SizeF(9F, 23F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(478, 645);
        Controls.Add(panel1);
        Controls.Add(txtTienCongLimit);
        Controls.Add(txtVTPTLimit);
        Controls.Add(txtTiLeLai);
        Controls.Add(txtCarBrandLimit);
        Controls.Add(btnUpdate);
        Controls.Add(txtCarTodayLimit);
        Controls.Add(cBChoPhep);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(2);
        MaximumSize = new Size(496, 692);
        MinimumSize = new Size(496, 692);
        Name = "fRegulations";
        StartPosition = FormStartPosition.CenterParent;
        Text = "THAY ĐỔI QUI ĐỊNH";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox txtTiLeLai;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.TextBox txtCarBrandLimit;
    private System.Windows.Forms.TextBox txtCarTodayLimit;
    private System.Windows.Forms.TextBox txtVTPTLimit;
    private System.Windows.Forms.TextBox txtTienCongLimit;
    private System.Windows.Forms.CheckBox cBChoPhep;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label1;

    #endregion

    private Panel panel1;
    private Label label6;
}
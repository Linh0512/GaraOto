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
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        cBChoPhep = new System.Windows.Forms.CheckBox();
        txtCarTodayLimit = new System.Windows.Forms.TextBox();
        btnUpdate = new System.Windows.Forms.Button();
        txtCarBrandLimit = new System.Windows.Forms.TextBox();
        txtTiLeLai = new System.Windows.Forms.TextBox();
        txtVTPTLimit = new System.Windows.Forms.TextBox();
        txtTienCongLimit = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(124, 47);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(269, 23);
        label1.TabIndex = 0;
        label1.Text = "Số xe tối đa nhận trong ngày";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(165, 160);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(186, 23);
        label2.TabIndex = 1;
        label2.Text = "Số hiệu xe tối đa ";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(194, 275);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(107, 23);
        label3.TabIndex = 2;
        label3.Text = "Tỉ lệ lãi";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(169, 382);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(162, 21);
        label4.TabIndex = 3;
        label4.Text = "Số VTPT tối đa";
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(169, 482);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(162, 23);
        label5.TabIndex = 4;
        label5.Text = "Số tiền công tối đa";
        // 
        // cBChoPhep
        // 
        cBChoPhep.Location = new System.Drawing.Point(114, 579);
        cBChoPhep.Name = "cBChoPhep";
        cBChoPhep.Size = new System.Drawing.Size(290, 47);
        cBChoPhep.TabIndex = 5;
        cBChoPhep.Text = "Cho phép trả vượt số tiền nợ";
        cBChoPhep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        cBChoPhep.UseVisualStyleBackColor = true;
        // 
        // txtCarTodayLimit
        // 
        txtCarTodayLimit.Location = new System.Drawing.Point(157, 94);
        txtCarTodayLimit.Name = "txtCarTodayLimit";
        txtCarTodayLimit.Size = new System.Drawing.Size(198, 31);
        txtCarTodayLimit.TabIndex = 6;
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new System.Drawing.Point(169, 645);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new System.Drawing.Size(136, 36);
        btnUpdate.TabIndex = 11;
        btnUpdate.Text = "Cập nhập";
        btnUpdate.UseVisualStyleBackColor = true;
        // 
        // txtCarBrandLimit
        // 
        txtCarBrandLimit.Location = new System.Drawing.Point(157, 204);
        txtCarBrandLimit.Name = "txtCarBrandLimit";
        txtCarBrandLimit.Size = new System.Drawing.Size(198, 31);
        txtCarBrandLimit.TabIndex = 12;
        // 
        // txtTiLeLai
        // 
        txtTiLeLai.Location = new System.Drawing.Point(153, 326);
        txtTiLeLai.Name = "txtTiLeLai";
        txtTiLeLai.Size = new System.Drawing.Size(198, 31);
        txtTiLeLai.TabIndex = 13;
        // 
        // txtVTPTLimit
        // 
        txtVTPTLimit.Location = new System.Drawing.Point(157, 430);
        txtVTPTLimit.Name = "txtVTPTLimit";
        txtVTPTLimit.Size = new System.Drawing.Size(198, 31);
        txtVTPTLimit.TabIndex = 14;
        // 
        // txtTienCongLimit
        // 
        txtTienCongLimit.Location = new System.Drawing.Point(157, 525);
        txtTienCongLimit.Name = "txtTienCongLimit";
        txtTienCongLimit.Size = new System.Drawing.Size(198, 31);
        txtTienCongLimit.TabIndex = 15;
        // 
        // fRegulations
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(548, 706);
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
        Text = "fRegulations";
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
}
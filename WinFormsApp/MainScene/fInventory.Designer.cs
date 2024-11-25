using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    partial class fInventory :Form
    {
        private System.ComponentModel.IContainer components = null;

        // Define controls
        private TextBox txbName;
        private TextBox txbPrice;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnClose;
        private Label lblName;
        private Label lblPrice;

        // Clean up any resources being used.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Initialize the form and its components
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Text = "Quản lý phụ tùng";
            this.ClientSize = new System.Drawing.Size(400, 300);

            // Initialize controls
            this.lblName = new Label();
            this.lblName.Text = "Tên phụ tùng:";
            this.lblName.Location = new System.Drawing.Point(20, 20);
            this.lblName.AutoSize = true;

            this.txbName = new TextBox();
            this.txbName.Location = new System.Drawing.Point(120, 20);
            this.txbName.Width = 200;

            this.lblPrice = new Label();
            this.lblPrice.Text = "Giá phụ tùng:";
            this.lblPrice.Location = new System.Drawing.Point(20, 60);
            this.lblPrice.AutoSize = true;

            this.txbPrice = new TextBox();
            this.txbPrice.Location = new System.Drawing.Point(120, 60);
            this.txbPrice.Width = 200;

            this.btnAdd = new Button();
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Location = new System.Drawing.Point(20, 120);
            this.btnAdd.Click += new EventHandler(this.BtnAdd_Click);

            this.btnEdit = new Button();
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Location = new System.Drawing.Point(120, 120);
            this.btnEdit.Click += new EventHandler(this.BtnEdit_Click);

            this.btnClose = new Button();
            this.btnClose.Text = "Đóng";
            this.btnClose.Location = new System.Drawing.Point(220, 120);
            this.btnClose.Click += new EventHandler(this.BtnClose_Click);

            // Add controls to the form
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClose);
        }

        // Event Handlers
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Thêm phụ tùng: {txbName.Text} - Giá: {txbPrice.Text}", "Thông báo");
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Sửa thông tin phụ tùng: {txbName.Text} - Giá: {txbPrice.Text}", "Thông báo");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


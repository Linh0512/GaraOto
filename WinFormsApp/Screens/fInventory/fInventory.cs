﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.DAO;
using WinFormsApp.Screens.fInventory;

namespace WinFormsApp
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            LoadPhuTung();
        }


        public void LoadPhuTung()
        {

            string query = "SELECT p.TenVTPT as 'Phụ Tùng', c.GiaNhap as 'Gía Nhập', p.SoLuongTon as 'Số lượng', p.DonGia as 'Đơn giá'  FROM PHUTUNG as p LEFT JOIN CT_PNKVTPT as c ON p.MaVTPT = c.MaVTPT";
            DataProvider dataProvider = new DataProvider();
            dgvPhuTung.DataSource = dataProvider.ExecuteQuery(query);
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            fPayment fPayment = new fPayment();
            fPayment.ShowDialog();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add add = new add(this);
            add.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            invoice invoice = new invoice();
            invoice.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            history history = new history();
            history.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fPayment payment = new fPayment();
            payment.ShowDialog();
        }

        private void timKiem()
        {
            try
            {
                string term = txtCode.Text.Trim();

                if (string.IsNullOrEmpty(term))
                {
                    LoadPhuTung();
                    return;
                }

                DataTable result = PhuTungDAO.Instance.GetPhuTungByName(term);

                if (result.Rows.Count > 0)
                {
                    dgvPhuTung.DataSource = result;
                }
                else
                {
                    LoadPhuTung();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timKiem();
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            timKiem();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (dgvPhuTung.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn vật tư phụ tùng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dgvPhuTung.SelectedRows)
            {
                try
                {
                    if (row.Cells[2].Value != null && int.TryParse(row.Cells[2].Value.ToString(), out int columnValue))
                    {
                        if (columnValue > 0)
                        {
                            MessageBox.Show("Không thể xóa hàng này vì giá trị số lượng tồn lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            continue;
                        }
                    }

                    DialogResult result = MessageBox.Show("Bạn có đồng ý muốn xóa phụ tùng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (row.Cells[0].Value == null)
                        {
                            MessageBox.Show("Tên phụ tùng không hợp lệ. Không thể xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue;
                        }

                        string tenPhuTung = row.Cells[0].Value.ToString();
                        dgvPhuTung.Rows.Remove(row);
                        PhuTungDAO.Instance.DeletePhuTungByName(tenPhuTung);
                        MessageBox.Show($"Xóa thành công phụ tùng: {tenPhuTung}", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa phụ tùng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

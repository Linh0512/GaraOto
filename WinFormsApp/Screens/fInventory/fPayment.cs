using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using WinFormsApp.DAO;
using WinFormsApp.Model;
using WinFormsApp.Models;
using WinFormsApp.Screens.fInventory;
using WinFormsApp.Screens.Service.Payment;

namespace WinFormsApp.Screens.fInventory
{
    public partial class fPayment : Form
    {
        public fPayment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            dtpNgayNhap.Enabled = false;
            txbIdImport.Text = PhieuNhapKhoVTPTDAO.Instance.LoadIdImport();
            UpdateTongTien();
        }

        public void UpdateTongTien()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvNhapHang.Rows)
            {
                if (row.Cells["tong_tien"].Value != null)
                {
                    if (decimal.TryParse(row.Cells["tong_tien"].Value.ToString(), out decimal rowTotal))
                    {
                        total += rowTotal;
                    }
                }
            }

            txtTongTien.Text = total.ToString("N0");
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MuaPhuTung muaPhuTung = new MuaPhuTung("Add", this);
            muaPhuTung.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dgvNhapHang.SelectedRows.Count > 0)
            {
                MuaPhuTung muaPhuTung = new MuaPhuTung("Update", this);
                muaPhuTung.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvNhapHang.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa hàng được chọn không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvNhapHang.SelectedRows)
                    {
                        dgvNhapHang.Rows.Remove(row);
                        UpdateTongTien();
                    }

                    MessageBox.Show("Hàng đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //private void btnThanhToan_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // Lấy mã nhà cung cấp từ cột tương ứng của dòng đầu tiên
        //        string maNCC = dgvNhapHang.Rows[0].Cells[2].Value.ToString(); // Giả sử cột 2 chứa mã NCC

        //        // Tạo đối tượng phiếu nhập kho
        //        PhieuNhapKhoVTPT phieuNhapKho = new PhieuNhapKhoVTPT
        //        {
        //            ngayNhap = DateTime.Now,
        //            maNKVTPT = maNCC
        //        };

        //        List<CT_PNKVTPT> ctPnks = new List<CT_PNKVTPT>();

        //        foreach (DataGridViewRow row in dgvNhapHang.Rows)
        //        {
        //            if (!row.IsNewRow) 
        //            {
        //                var ctPnk = new CT_PNKVTPT
        //                {
        //                    phieuNhapKhoVTPT = new PhieuNhapKhoVTPT { maNKVTPT = maNCC }, 
        //                    phuTung = new PhuTung
        //                    {
        //                        MaVTPT = PhieuNhapKhoVTPTDAO.Instance.GetMaVTPTByTenVTPT(row.Cells[1].Value.ToString()), 
        //                        TenVTPT = row.Cells[1].Value.ToString() 
        //                    },
        //                    SoLuong = int.Parse(row.Cells[3].Value.ToString()),
        //                    GiaNhap = decimal.Parse(row.Cells[2].Value.ToString()) 
        //                };

        //                ctPnks.Add(ctPnk);
        //            }
        //        }

        //        PhieuNhapKhoVTPTDAO.Instance.addCT_PNKVTPTAndUpdatePhuTung(ctPnks);

        //        MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        dgvNhapHang.Rows.Clear(); 
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                // Thêm phiếu nhập kho vào database
                PhieuNhapKhoVTPTDAO.Instance.AddPhieuNhapKho(new PhieuNhapKhoVTPT()
                {
                    maNKVTPT = this.txbIdImport.Text,
                    ngayNhap = DateTime.Now
                });

                // Lấy danh sách chi tiết phiếu nhập kho
                List<CT_PNKVTPT> ctPnks = new List<CT_PNKVTPT>();
                foreach (DataGridViewRow row in dgvNhapHang.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var ctPnk = new CT_PNKVTPT
                        {
                            phuTung = new PhuTung
                            {
                                MaVTPT = PhieuNhapKhoVTPTDAO.Instance.GetMaVTPTByTenVTPT(row.Cells[1].Value.ToString()),
                                TenVTPT = row.Cells[1].Value.ToString()
                            },
                            phieuNhapKhoVTPT = new PhieuNhapKhoVTPT { maNKVTPT = this.txbIdImport.Text },
                            SoLuong = int.Parse(row.Cells[3].Value.ToString()),
                            GiaNhap = decimal.Parse(row.Cells[2].Value.ToString())
                        };
                        ctPnks.Add(ctPnk);
                    }
                }

                // Thêm chi tiết phiếu nhập kho và cập nhật số lượng tồn
                PhieuNhapKhoVTPTDAO.Instance.addCT_PNKVTPTAndUpdatePhuTung(ctPnks);

                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xóa các dòng trên DataGridView sau khi lưu
                dgvNhapHang.Rows.Clear();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

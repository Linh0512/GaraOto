using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using WinFormsApp.MainScene;
using WinFormsApp.MainScene.fStaff;
=======
using WinFormsApp.MainScene;
using WinFormsApp.MainScene.fStaff;
>>>>>>> 28dec8202fa6123765a03f9f60166575f74d2159
using WinFormsApp.DAO;
using ClosedXML.Excel;

namespace WinFormsApp
{
    public partial class fStaff : Form
    {
        public fStaff()
        {
            InitializeComponent();
            LoadStaff();
        }
        void LoadStaff()
        {
            dgvNhanVien.DataSource = NHANVIENDAO.Instane.HienThi();
        }
        private void fStaff_Load(object sender, EventArgs e)
        {

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fThemNhanVien fThemNhanVien = new fThemNhanVien();
            fThemNhanVien.ShowDialog();
            LoadStaff();
        }

        private void btnInDanhSach_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.Rows.Count == 0)
                MessageBox.Show("Không có thông tin để xuất!");
            else
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (XLWorkbook workbook = new XLWorkbook())
                            {
                                workbook.Worksheets.Add(dgvNhanVien.DataSource as DataTable, "NhanVien");

                                workbook.SaveAs(saveFileDialog.FileName);


                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Xuất file không thành công!");
                        }
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {

            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvNhanVien.SelectedRows[0];
                string tenDangNhap = row.Cells["TenDangNhap"].Value.ToString();
                string matKhau = row.Cells["MatKhau"].Value.ToString();
                string hoVaTen = row.Cells["TenNV"].Value.ToString();
                string sdt = row.Cells["DienThoai"].Value.ToString();
                string email = row.Cells["Email"].Value.ToString();
                string diaChi = row.Cells["DiaChi"].Value.ToString();
                string chucVu = row.Cells["ChucVu"].Value.ToString();
                fSuaThongTin form = new fSuaThongTin(tenDangNhap, matKhau, hoVaTen, sdt, email, diaChi, chucVu);
                form.ShowDialog();
                LoadStaff();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }

        private void btnTiemKIem_Click(object sender, EventArgs e)
        {
            string TuKhoa = txtTiemKiem.Text;
            dgvNhanVien.DataSource = NHANVIENDAO.Instane.TiemKiem(TuKhoa);

        }        
        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
             
                string tenDangNhap = dgvNhanVien.SelectedRows[0].Cells["TenDangNhap"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa nhân viên có Tên Đăng Nhập là '{tenDangNhap}' không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        NHANVIENDAO.Instane.Xoa(tenDangNhap);
                        LoadStaff();
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}

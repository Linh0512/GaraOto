using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.MainScene;
using WinFormsApp.MainScene.fStaff;

namespace WinFormsApp
{
    public partial class fStaff : Form
    {
        public fStaff()
        {
            InitializeComponent();
        }

        private void fStaff_Load(object sender, EventArgs e)
        {

        }

            // Cấu hình hiển thị cột
            dgvNhanVien.Columns["Email"].Visible = false;
            dgvNhanVien.Columns["MatKhau"].Visible = false;
            dgvNhanVien.Columns["TenDangNhap"].Visible = false;
            dgvNhanVien.Columns["DienThoai"].Visible = false;
            dgvNhanVien.Columns["DiaChi"].Visible = false;
            dgvNhanVien.Columns["TenNV"].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns["ChucVu"].HeaderText = "Chức Vụ";
            dgvNhanVien.Columns["TenNV"].ReadOnly = true;
            dgvNhanVien.Columns["ChucVu"].ReadOnly = true;

            NHANVIENDAO.Instane.LoadComboBoxData(cbbChucVu);

            // Cấu hình các TextBox và nút
            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;
            txtHovaTen.Enabled = false;
            txtSDT.Enabled = false;
            txtTenDangNhap.Enabled = false;
            cbbChucVu.Enabled = false;
            btnXacNhan.Hide();
            btnHuy.Hide();
            btnSuaThongTin.Show();
            btnDatMatKhau.Show();
            btnXoa.Show();
            btnDatMatKhau.Show();
            btnThem.Show();
            lblThongTinChiTiet.Text = "Thông tin chi tiết";
            lblThongTinChiTiet.BackColor = SystemColors.ActiveCaption;
            dgvNhanVien.Enabled = true;

            /*txtDiaChi.Clear();
            txtHovaTen.Clear();
            txtEmail.Clear();
            txtTenDangNhap.Clear();
            txtSDT.Clear();
            txtTiemKiem.Clear();*/

            // Ẩn cột bên trái cùng
            dgvNhanVien.RowHeadersVisible = false;
            dgvNhanVien.AllowUserToAddRows = false;           
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // **Chọn dòng cụ thể dựa trên tên đăng nhập**
            if (!string.IsNullOrEmpty(tenDangNhap))
            {
                SelectRowByTenDangNhap(tenDangNhap);
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        }

        void UpdateDetailFields(int rowIndex)
        {
            if (dgvNhanVien.Rows.Count > rowIndex)
            {
                txtHovaTen.Text = dgvNhanVien.Rows[rowIndex].Cells["TenNV"].Value?.ToString();
                txtDiaChi.Text = dgvNhanVien.Rows[rowIndex].Cells["DiaChi"].Value?.ToString();
                txtEmail.Text = dgvNhanVien.Rows[rowIndex].Cells["Email"].Value?.ToString();
                txtSDT.Text = dgvNhanVien.Rows[rowIndex].Cells["DienThoai"].Value?.ToString();
                txtTenDangNhap.Text = dgvNhanVien.Rows[rowIndex].Cells["TenDangNhap"].Value?.ToString();
                cbbChucVu.Text = dgvNhanVien.Rows[rowIndex].Cells["ChucVu"].Value?.ToString();
            }
        }


        private void fStaff_Load(object sender, EventArgs e)
        {

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            fThemNhanVien fThemNhanVien = new fThemNhanVien();
            fThemNhanVien.ShowDialog();
        }

       

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvNhanVien.SelectedRows[0];

                // Hiển thị thông tin đầy đủ vào các TextBox
                txtTenDangNhap.Text = selectedRow.Cells["TenDangNhap"].Value?.ToString();
                txtHovaTen.Text = selectedRow.Cells["TenNV"].Value?.ToString();
                txtSDT.Text = selectedRow.Cells["DienThoai"].Value?.ToString();
                txtDiaChi.Text = selectedRow.Cells["DiaChi"].Value?.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value?.ToString();
                cbbChucVu.Text = selectedRow.Cells["ChucVu"].Value?.ToString();

            }
        }
        //Sữa
        private void btnSuaNV_Click(object sender, EventArgs e)
        {

            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                NhanVien nv = new NhanVien();
                DataGridViewRow row = dgvNhanVien.SelectedRows[0];
                nv.TenDangNhap = row.Cells["TenDangNhap"].Value.ToString();
                txtDiaChi.Enabled = true;
                txtEmail.Enabled = true;
                txtHovaTen.Enabled = true;
                txtSDT.Enabled = true;
                cbbChucVu.Enabled = true;

                btnSuaThongTin.Hide();
                btnXoa.Hide();
                btnDatMatKhau.Hide();
                btnXacNhan.Show();
                btnHuy.Show();
                btnThem.Hide();
                btnTiemKIem.Enabled = false;
                btnTaiLai.Enabled = false;  
                txtTiemKiem.Enabled = false;
                lblThongTinChiTiet.Text = "Sữa thông tin ";
                lblThongTinChiTiet.BackColor = System.Drawing.Color.Red;
                dgvNhanVien.Enabled = false;

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.TenDangNhap = txtTenDangNhap.Text;
            nv.TenNV = txtHovaTen.Text;
            nv.DienThoai = txtSDT.Text;
            nv.Email = txtEmail.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.ChucVu = cbbChucVu.Text;
            if (String.IsNullOrEmpty(txtTenDangNhap.Text) || String.IsNullOrEmpty(txtHovaTen.Text)
                || String.IsNullOrEmpty(txtDiaChi.Text) || String.IsNullOrEmpty(txtSDT.Text) || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(cbbChucVu.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            else
            {
                if (NHANVIENDAO.Instane.Sua(nv))
                {
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo");

                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo");

                }
                LoadStaff(nv.TenDangNhap);             
                
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {

        }
        // Tiem Kiem
        private void btnTiemKIem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTiemKiem.Text))
            {
                // Hiển thị thông báo nếu trống
                MessageBox.Show("Bạn phải nhập thông tin tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Thoát mà không thực hiện tìm kiếm
            }
            txtTiemKiem.Enabled = false; 
            btnTaiLai.Show();
            string TuKhoa = txtTiemKiem.Text;
            dgvNhanVien.DataSource = NHANVIENDAO.Instane.TiemKiem(TuKhoa);
            dgvNhanVien.Columns["Email"].Visible = false;
            dgvNhanVien.Columns["MatKhau"].Visible = false;
            dgvNhanVien.Columns["TenDangNhap"].Visible = false;
            dgvNhanVien.Columns["DienThoai"].Visible = false;
            dgvNhanVien.Columns["DiaChi"].Visible = false;
            dgvNhanVien.Columns["TenNV"].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns["ChucVu"].HeaderText = "Chức Vụ";
        }
        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {

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
            fSuaThongTin fSuaThongTin = new fSuaThongTin();
            fSuaThongTin.ShowDialog();
        }
    }
}

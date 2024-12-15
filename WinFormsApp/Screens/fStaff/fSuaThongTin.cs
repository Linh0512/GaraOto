using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.DAO;
using WinFormsApp.Models;

namespace WinFormsApp.MainScene.fStaff
{
    public partial class fSuaThongTin : Form
    {
        public fSuaThongTin(string tenDangNhap, string matKhau, string hoVaTen, string sdt, string email, string diaChi, string chucVu)
        {
            InitializeComponent();
            btnXacNhanSua.Hide();
            txtTenDangNhap.Text = tenDangNhap;
            txtMatKhau.Text = matKhau;
            txtHoVaTen.Text = hoVaTen;
            txtSDT.Text = sdt;
            txtEmail.Text = email;
            txtDiaChi.Text = diaChi;
            cbbChucVu.Text = chucVu;



        }


        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            txtTenDangNhap.ReadOnly = true;
            txtMatKhau.ReadOnly = false;
            txtHoVaTen.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            NHANVIENDAO.Instane.LoadComboBoxData(cbbChucVu);
            btnSuaThongTin.Hide();
            btnXacNhanSua.Show();


        }

        private void lblTenDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        NhanVien nv = new NhanVien();  
        private void btnXacNhanSua_Click(object sender, EventArgs e)
        {
            nv.TenDangNhap = txtTenDangNhap.Text;
            nv.MatKhau = txtMatKhau.Text;
            nv.TenNV = txtHoVaTen.Text;
            nv.DienThoai = txtSDT.Text;
            nv.Email = txtEmail.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.ChucVu = cbbChucVu.Text;
            if (NHANVIENDAO.Instane.Sua(nv))
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo");
                this.Close();
              
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Thông báo");
            }    
        }
    }
}

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

namespace WinFormsApp
{
    public partial class fSuaNV : Form
    {
        public fSuaNV(NhanVien nv)
        {
            InitializeComponent();
            NHANVIENDAO.Instane.LoadComboBoxData(cbbChucVu);
            txtTenDangNhap.Text = nv.TenDangNhap;
            txtHoVaTen.Text = nv.TenNV;
            txtSDT.Text = nv.DienThoai;
            txtDiaChi.Text = nv.DiaChi;
            txtEmail.Text = nv.Email;
            cbbChucVu.Text = nv.ChucVu;
            txtTenDangNhap.Enabled = false;


        }



        private void fSuaNV_Load(object sender, EventArgs e)
        {

        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            NhanVien nv1 = new NhanVien();
            nv1.TenDangNhap = txtTenDangNhap.Text;
            nv1.TenNV = txtHoVaTen.Text;
            nv1.DienThoai = txtSDT.Text;
            nv1.Email = txtEmail.Text;
            nv1.DiaChi = txtDiaChi.Text;
            nv1.ChucVu = cbbChucVu.Text;
            if (String.IsNullOrEmpty(txtTenDangNhap.Text) || String.IsNullOrEmpty(txtHoVaTen.Text)
                || String.IsNullOrEmpty(txtDiaChi.Text) || String.IsNullOrEmpty(txtSDT.Text) || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(cbbChucVu.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            else
            {
                if (NHANVIENDAO.Instane.Sua(nv1))
                {
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo");
                    this.Close();

                }


            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

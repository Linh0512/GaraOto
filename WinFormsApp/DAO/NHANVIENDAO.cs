using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WinFormsApp.DAO
{
    internal class NHANVIENDAO
    {       
        private static NHANVIENDAO instane;
        private NHANVIENDAO() 
        {
        }
        public static NHANVIENDAO Instane
        {
            get 
            {
                if (instane == null)
                    instane = new NHANVIENDAO();
                return instane;
            }
            set { instane = value; }
        }

        public DataTable HienThi()
        {
            string query = "SELECT * FROM NHANVIEN";            
            return DataProviderLocal.Instance.ExecuteQuery(query);

        }

        public bool Them (string tdn , string mk , string ten , string diachi , string dth , string email , string cv)
        {
            string sql = "INSERT INTO NHANVIEN (TenDangNhap, MatKhau, TenNV, DienThoai, Email, DiaChi, ChucVu) " +
                "VALUES( @tdn , @mk , @ten , @dth , @email , @dc , @cv )";
            try
            {
                DataProviderLocal.Instance.ExecuteQuery(sql, new object[] {tdn , mk,ten, diachi , dth , email , cv });
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;

        }


        public void LoadComboBoxData(ComboBox comboBox)
        {
            string sql = "SELECT ChucVu FROM CHUCVU";
            DataTable dt = DataProviderLocal.Instance.ExecuteQuery(sql);
            comboBox.DataSource = dt;             // Gán DataTable làm nguồn dữ liệu
            comboBox.DisplayMember = "ChucVu";    // Cột hiển thị trong ComboBox
            comboBox.ValueMember = "ChucVu";      // Cột lưu giá trị của mục
        }

        public void Xoa(string tdn)
        {
            string query = $"DELETE FROM NHANVIEN WHERE TenDangNhap = @TenDangNhap";
            DataProviderLocal.Instance.ExecuteQuery(query, new object[] { tdn });
        }
        public DataTable TiemKiem(string TuKhoa)
        {
            string query = $"select * from NhanVien Where TenDangNhap Like N'%{TuKhoa}%' " +
                $"OR TenNV Like N'%{TuKhoa}%' " +
                $"OR DienThoai Like N'%{TuKhoa}%' " +
                $"OR Email Like N'%{TuKhoa}%'" +
                $"OR DiaChi Like N'%{TuKhoa}%'" +
                $"OR ChucVu Like N'%{TuKhoa}%'";
            return DataProviderLocal.Instance.ExecuteQuery(query);
        }

        public bool Sua (string tdn, string mk, string ten, string diachi, string dth, string email, string cv)
        {
            
            string query = "UPDATE NHANVIEN SET MatKhau = @mk , TenNV = @ten , DienThoai = @dth , Email = @email , DiaChi = @diaChi , ChucVu = @cv " +
                " WHERE TenDangNhap = @tdn ";
            try
            {
                DataProviderLocal.Instance.ExecuteQuery(query, new object[] { mk, ten, diachi, dth, email, cv, tdn });
            }
            catch (Exception ex) { return false; }
            return true;
        }







    }
}

using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Model;


namespace WinFormsApp.DAO
{
    internal class ServiceDAO
    {
        public static ServiceDAO Instance = new ServiceDAO();
        public void AddCar(Car car)
        {
            string query = "INSERT INTO dbo.XE (BienSo, TenChuXe, HieuXe, DienThoai, DiaChi, NgayTiepNhan, TienNo) " +
                           "VALUES (@BienSo, @TenChuXe, @HieuXe, @DienThoai, @DiaChi, @NgayTiepNhan, @TienNo)";
            using (SqlConnection connection = DataProvider.Instance.getConnect())
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open(); 
                    command.Parameters.AddWithValue("@Bienso", car.Bienso);
                    command.Parameters.AddWithValue("@Hieuxe", car.Hieuxe);
                    command.Parameters.AddWithValue("@TenChuXe", car.TenChuXe);
                    command.Parameters.AddWithValue("@DiaChi", car.DiaChi);
                    command.Parameters.AddWithValue("@DienThoai", car.DienThoai);
                    command.Parameters.AddWithValue("@NgayTiepNhan", car.NgayTiepNhan);
                    command.Parameters.AddWithValue("@TienNo", car.TienNo);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Lỗi kết nối: " + ex.Message, ex);
                }
            }
        }

        public void DelCar(string plateLicense)
        {
            string query = "DELETE FROM dbo.XE WHERE BienSo = @bienso";

            using (SqlConnection connection = DataProvider.Instance.getConnect())
            {                    
                try
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    cmd.Parameters.AddWithValue("@bienso", plateLicense);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa xe thất bại, xe được tham chiếu bởi bảng khác");
                }
            }
            
        }
    }
}

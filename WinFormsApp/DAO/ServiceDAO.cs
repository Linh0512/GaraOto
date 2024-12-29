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
        public static ServiceDAO instance = new ServiceDAO();

        public void LoadData(string query, DataGridView dtgv)
        {
            //string query = "SELECT * FROM dbo.XE";
            DataProvider dataProvider = new DataProvider();
            dtgv.DataSource = dataProvider.ExecuteQuery(query);
        }

        public SqlDataReader LoadDataByLicensePlate(string bienso)
        {
            SqlConnection con = DataProvider.instance.getConnect();
            con.Open();
            string sql = "SELECT BienSo AS 'Biển số', TenChuXe 'Tên chủ xe', HieuXe 'Hiệu xe', DiaChi 'Địa chỉ',  +" +
                "DienThoai 'Số điện thoại', Email 'Email', TienNo 'Tiền nợ', NgayTiepNhan AS 'Ngày tiếp nhận' FROM XE WHERE BienSo = @bienso";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@bienso", bienso);
            SqlDataReader dt = cmd.ExecuteReader();
            return dt;
        }

        public string LoadIdReceipt()
        {
            SqlConnection con = DataProvider.instance.getConnect();
            using (con)
            {
                con.Open();
                string sql = "SELECT COUNT(*) + 1 AS SO FROM PHIEUTHUTIEN";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                string l = "";
                if (dr.Read())
                    l = dr["SO"].ToString();
                con.Close();
                return "SC" + l;
            }
        }

        public bool UpdateDebt(string bienso, double tn)
        {
            string sql = "UPDATE XE SET TienNo = @tn WHERE BienSo = @bienso";
            SqlConnection con = DataProvider.instance.getConnect();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@bienso", bienso);

                cmd.Parameters.AddWithValue("@tn", tn);

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public void AddCar(Car car)
        {
            string query = "INSERT INTO dbo.XE (BienSo, TenChuXe, HieuXe, DienThoai, DiaChi, NgayTiepNhan, TienNo, Email) " +
                           "VALUES (@BienSo, @TenChuXe, @HieuXe, @DienThoai, @DiaChi, @NgayTiepNhan, @TienNo, @Email)";
            using (SqlConnection connection = DataProvider.instance.getConnect())
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
                    command.Parameters.AddWithValue("@Email", car.Email);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Lỗi kết nối: " + ex.Message, ex);
                }
            }
        }

        public void DelCar(string licensePlate)
        {
            string query = "DELETE FROM dbo.XE WHERE BienSo = @bienso";

            using (SqlConnection connection = DataProvider.instance.getConnect())
            {                    
                try
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    cmd.Parameters.AddWithValue("@bienso", licensePlate);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa xe thất bại, xe được tham chiếu bởi bảng khác");
                }
            }
        }

        public DataTable FindCar(Dictionary<string, string> conditions, bool searchByDate = false)
        {
            // Khởi tạo câu truy vấn cơ bản
            string query = "SELECT BienSo AS 'Biển số', TenChuXe 'Tên chủ xe', HieuXe 'Hiệu xe', DiaChi 'Địa chỉ'," +
                "DienThoai 'Số điện thoại', Email 'Email', TienNo 'Tiền nợ', NgayTiepNhan AS 'Ngày tiếp nhận' FROM dbo.XE";

            // Nếu có điều kiện, xây dựng thêm WHERE
            if (conditions.Count > 0)
            {
                List<string> filters = new List<string>();
                foreach (var condition in conditions)
                {
                    // Bỏ qua điều kiện ngày nếu không tìm theo ngày
                    if (condition.Key == "NgayTiepNhan" && !searchByDate)
                        continue;

                    if (condition.Key == "NgayTiepNhan" && searchByDate)
                    {
                        filters.Add($"CONVERT(DATE, {condition.Key}) = '{condition.Value}'");
                    }
                    else if (!string.IsNullOrEmpty(condition.Value)) // Chỉ thêm điều kiện nếu có giá trị
                    {
                        filters.Add($"{condition.Key} LIKE N'%{condition.Value}%'");
                    }
                }

                if (filters.Count > 0)
                {
                    query += " WHERE " + string.Join(" AND ", filters);
                }
            }

            // Thực thi câu truy vấn
            return DataProvider.instance.ExecuteQuery(query);
        }



        public AutoCompleteStringCollection LoadAutoCompleteData(string query, string columnName)
        {
            // Tạo AutoCompleteCustomSource cho Tên vật tư
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();

            using (SqlConnection conn = DataProvider.instance.getConnect())
            {
                conn.Open();

                // Lấy danh sách tên vật tư
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    source.Add(reader[columnName].ToString());
                }
                reader.Close();
                conn.Close();
            }
            return source;
        }

        public void UpdateInforCar(Car car)
        {
            string query = "UPDATE XE SET TenChuXe = @ten, HieuXe = @hieuxe, DiaChi = @diachi, DienThoai = @dienthoai, Email = @email WHERE BienSo = @bienso";

            using (SqlConnection connection = DataProvider.instance.getConnect())
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    command.Parameters.AddWithValue("@bienso", car.Bienso);
                    command.Parameters.AddWithValue("@hieuxe", car.Hieuxe);
                    command.Parameters.AddWithValue("@ten", car.TenChuXe);
                    command.Parameters.AddWithValue("@diaChi", car.DiaChi);
                    command.Parameters.AddWithValue("@dienThoai", car.DienThoai);
                    command.Parameters.AddWithValue("@email", car.Email);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        public object LoadDataByName(string query, string parameterName, string parameterValue)
        {
            try
            {
                if (!string.IsNullOrEmpty(parameterValue))
                {
                    using (SqlConnection conn = DataProvider.instance.getConnect())
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue(parameterName, parameterValue);

                        object result = cmd.ExecuteScalar();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public DataTable GetCarBrands()
        {
            string query = "SELECT DISTINCT HieuXe FROM dbo.HIEUXE ORDER BY HieuXe";
            return DataProvider.instance.ExecuteQuery(query);
        }

    }
}

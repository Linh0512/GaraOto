using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using WinFormsApp.Models;

namespace WinFormsApp.DAO
{
    internal class ReceiptDAO
    {
        SqlDataAdapter da;
        public static ReceiptDAO instance = new ReceiptDAO();

        public DataTable SearchByLicensePlate(string s)
        {
            SqlConnection con = DataProvider.instance.getConnect();
            con.Open();
            string sql = "SELECT * FROM PHIEUTHUTIEN WHERE BienSo = @bienso";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@bienso", s);
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //public DataTable SearchByDate(int ngay, int thang, int nam)
        //{
        //    SqlConnection con = DataProvider.instance.getConnect();
        //    con.Open();
        //    string sql = "SELECT * FROM PHIEUTHUTIEN WHERE DAY(NgayThuTien) = @ngay AND MONTH(NgayThuTien) = @thang AND YEAR(NgayThuTien) = @nam";
        //    SqlCommand cmd = new SqlCommand(sql, con);
        //    cmd.Parameters.AddWithValue("@ngay", ngay);
        //    cmd.Parameters.AddWithValue("@thang", thang);
        //    cmd.Parameters.AddWithValue("@nam", nam);
        //    DataTable dt = new DataTable();
        //    da = new SqlDataAdapter(cmd);
        //    da.Fill(dt);
        //    return dt;
        //}

        public DataTable SearchByDate(string query, string parameterName, string parameterValue)
        {
            try
            {
                using (SqlConnection conn = DataProvider.instance.getConnect())
                {
                    conn.Open();

                    // Điều chỉnh truy vấn để sử dụng CONVERT
                    string adjustedQuery = query.Replace(parameterName, $"CONVERT(DATE, NgayThuTien) = @date");

                    SqlCommand cmd = new SqlCommand(adjustedQuery, conn);
                    cmd.Parameters.AddWithValue("@date", parameterValue);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    return table;
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        public string LoadIdPTT()
        {
            SqlConnection con = DataProvider.instance.getConnect();
            con.Open();
            string sql = "SELECT COUNT(*) + 1 AS SO FROM PHIEUTHUTIEN";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            string l = "";
            if (dr.Read())
                l = dr["SO"].ToString();
            return "TT" + l;
        }
        public bool Add(PhieuThuTien phieuThuTien)
        {
            string sql = "INSERT INTO PHIEUTHUTIEN (MaPTT, BienSo, NgayThuTien, SoTienThu) VALUES (@maptt, @bienso, GETDATE(), @sotienthu)";
            SqlConnection con = DataProvider.instance.getConnect();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);

                con.Open();
                cmd.Parameters.AddWithValue("@maptt", phieuThuTien.MaPTT);
                cmd.Parameters.AddWithValue("@bienso", phieuThuTien.BienSo);
                cmd.Parameters.AddWithValue("@sotienthu", phieuThuTien.SoTienThu);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}

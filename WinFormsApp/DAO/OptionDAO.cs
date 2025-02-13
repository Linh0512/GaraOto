﻿using Microsoft.Data.SqlClient;
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
    internal class OptionDAO
    {
        public static OptionDAO Instance = new OptionDAO();

        public void LoadData(string query, DataGridView dgv)
        {
            DataProvider dataProvider = new DataProvider();
            dgv.DataSource = dataProvider.ExecuteQuery(query);
        }

        public void AddWage(Wage wage)
        {
            string query = "INSERT INTO dbo.TIENCONG (MaTienCong, NoiDung, TienCong) " +
                           "VALUES (@MaTienCong, @NoiDung, @TienCong)";
            using (SqlConnection connection = DataProvider.instance.getConnect())
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    command.Parameters.AddWithValue("@MaTienCong", wage.MaTienCong);
                    command.Parameters.AddWithValue("@NoiDung", wage.NoiDung);
                    command.Parameters.AddWithValue("@TienCong", wage.TienCong);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Lỗi kết nối: " + ex.Message, ex);
                }
            }
        }

        public void AddBrand(Brand brand)
        {
            string query = "INSERT INTO dbo.HIEUXE (HieuXe) " +
                           "VALUES (@HieuXe)";
            using (SqlConnection connection = DataProvider.instance.getConnect())
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    command.Parameters.AddWithValue("@HieuXe", brand.HieuXe);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Lỗi kết nối: " + ex.Message, ex);
                }
            }
        }

        public DataTable FindBrand(Dictionary<string, string> conditions)
        {
            string query = "SELECT * FROM dbo.HIEUXE";

            if (conditions.Count > 0)
            {
                query += " WHERE ";
                List<string> filters = new List<string>();
                foreach (var condition in conditions)
                {
                    filters.Add($"{condition.Key} LIKE @{condition.Key}");
                }
                query += string.Join(" AND ", filters);
            }

            using (SqlConnection connection = DataProvider.instance.getConnect())
            {
                SqlCommand command = new SqlCommand(query, connection);
                foreach (var condition in conditions)
                {
                    command.Parameters.AddWithValue($"@{condition.Key}", $"%{condition.Value}%");
                }

                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                return data;
            }
        }

        public DataTable FindWage(Dictionary<string, string> conditions)
        {
            string query = "SELECT * FROM dbo.TIENCONG";

            if (conditions.Count > 0)
            {
                query += " WHERE ";
                List<string> filters = new List<string>();
                foreach (var condition in conditions)
                {
                    filters.Add($"{condition.Key} LIKE @{condition.Key}");
                }
                query += string.Join(" AND ", filters);
            }

            using (SqlConnection connection = DataProvider.instance.getConnect())
            {
                SqlCommand command = new SqlCommand(query, connection);
                foreach (var condition in conditions)
                {
                    command.Parameters.AddWithValue($"@{condition.Key}", $"%{condition.Value}%");
                }

                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                return data;
            }
        }

        public void UpdateWage(Wage wage)
        {
            string query = "UPDATE TIENCONG SET NoiDung = @noidung, TienCong = @tiencong WHERE MaTienCong = @matiencong";

            using (SqlConnection connection = DataProvider.instance.getConnect())
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    command.Parameters.AddWithValue("@matiencong", wage.MaTienCong);
                    command.Parameters.AddWithValue("@noidung", wage.NoiDung);
                    command.Parameters.AddWithValue("@tiencong", wage.TienCong);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        public void UpdateBrand(string oldHieuXe, string newHieuXe)
        {
            string query = "UPDATE HIEUXE SET HieuXe = @newHieuXe WHERE HieuXe = @oldHieuXe;";

            using (SqlConnection connection = DataProvider.instance.getConnect())
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    command.Parameters.AddWithValue("@newHieuXe", newHieuXe);
                    command.Parameters.AddWithValue("@oldHieuXe", oldHieuXe);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        public void DelWage(string wageID)
        {
            string query1 = "DELETE FROM CT_PSC WHERE MaTienCong = @matiencong";
            string query2 = "DELETE FROM TIENCONG WHERE MaTienCong = @matiencong";

            using (SqlConnection connection = DataProvider.instance.getConnect())
            {
                try
                {
                    SqlCommand cmd1 = new SqlCommand(query1, connection);
                    SqlCommand cmd2 = new SqlCommand(query2, connection);

                    connection.Open();

                    cmd1.Parameters.AddWithValue("@matiencong", wageID);
                    cmd1.ExecuteNonQuery();

                    cmd2.Parameters.AddWithValue("@matiencong", wageID);
                    cmd2.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa tiền công thất bại: " + ex.Message);
                }
            }
        }


        public void DelBrand(string brandName)
        {
            string query = "DELETE FROM dbo.HIEUXE WHERE HieuXe = @hieuxe";

            using (SqlConnection connection = DataProvider.instance.getConnect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    cmd.Parameters.AddWithValue("@hieuxe", brandName);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa hãng xe thất bại, có thể được tham chiếu bởi bảng khác");
                }
            }
        }

        public void UpdateCarLimit(int carLimit, bool allowOverDebt)
        {
            string query = "UPDATE QUYDINH SET SoXeSuaChuaToiDa = @CarLimit, ChoPhepTraVuotTienNo = @AllowOverDebt";

            using (SqlConnection connection = DataProvider.instance.getConnect())
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    command.Parameters.AddWithValue("@CarLimit", carLimit);
                    command.Parameters.AddWithValue("@AllowOverDebt", allowOverDebt);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Lỗi: " + ex.Message, ex);
                }
            }
        }

        public (int CarLimit, bool AllowOverDebt) GetCarLimit()
        {
            string query = "SELECT SoXeSuaChuaToiDa, ChoPhepTraVuotTienNo FROM QUYDINH";
            using (SqlConnection connection = DataProvider.instance.getConnect())
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        int carLimit = reader.GetInt32(0);
                        bool allowOverDebt = reader.GetBoolean(1);
                        return (carLimit, allowOverDebt);
                    }
                    else
                    {
                        throw new InvalidOperationException("Không tìm thấy dữ liệu trong bảng QUYDINH.");
                    }
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Lỗi: " + ex.Message, ex);
                }
            }
        }


    }
}

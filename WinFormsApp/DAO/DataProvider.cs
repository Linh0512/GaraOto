using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace WinFormsApp.DAO
{
    internal class DataProvider
    {
        private readonly string connectionSTR;
        public static DataProvider Instance { get; private set; } = new DataProvider();

        public DataProvider()
        {
            try
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();

                connectionSTR = configuration.GetConnectionString("DefaultConnection")
                                ?? throw new InvalidOperationException(
                                    "Connection string not found.");


                Console.WriteLine("Connected to AWS database."); // Log để kiểm tra kết nối
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Lỗi khởi tạo DataProvider: " + ex.Message, ex);
            }
        }

        public DataTable ExecuteQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                return data;
            }
        }
    }
}
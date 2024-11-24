using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.EnvironmentVariables;

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
                    .AddEnvironmentVariables()
                    .Build();

                string dbServer = Environment.GetEnvironmentVariable("DB_SERVER") ?? "localhost";

                string dbName = Environment.GetEnvironmentVariable("DB_NAME") ?? "QUANLIGARA";

                string connectionTemplate = configuration.GetConnectionString("DefaultConnection")
                                            ?? throw new InvalidOperationException(
                                                "Bị lỗi không tìm thấy connection string trong appsettings.json");

                connectionSTR = connectionTemplate
                    .Replace("${DB_SERVER}", dbServer)
                    .Replace("${DB_NAME}", dbName);

                Console.WriteLine($"Connection String: {connectionSTR}"); // Dùng để kiểm tra connection string
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
                connection.Close();
                return data;
            }
        }
    }
}
using System;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using Microsoft.Data.SqlClient;
namespace WinFormsApp.DAO
{
    internal class DataProvider
    {
        public static DataProvider instance { get; private set; } = new DataProvider();

        public DataTable ExecuteQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(DataConnection.instance.connectionSTR))
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
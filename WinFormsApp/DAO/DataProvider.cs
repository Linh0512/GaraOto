using System;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using Microsoft.Data.SqlClient;
namespace WinFormsApp.DAO
{
    internal class DataProvider
    {
        private readonly string connectionSTR = "Data Source=DESKTOP-MBLAQQO;Initial Catalog=QUANLIGARA;Integrated Security=True;Trust Server Certificate=True";
        public static DataProvider Instance { get; private set; }

        public DataTable ExecuteQuery(String query)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
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

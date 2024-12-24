using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.DAO
{
    public class DataProviderLocal

    {


        public static DataProviderLocal instance = new DataProviderLocal();
        
        public DataTable ExecuteQuery (string query , object[] parameter = null)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = DataProvider.instance.getConnect()) 
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if(parameter != null)
                {
                    string[] ListPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in ListPara)
                    {
                        if(item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                connection.Close();
            }
            return dataTable;
        }
    }
}

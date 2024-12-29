using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace WinFormsApp.DAO
{
    internal class WageDAO
    {
        public static WageDAO instance = new WageDAO();
        public string LoadIdWage()
        {
            SqlConnection con = DataProvider.instance.getConnect();
            using (con)
            {
                con.Open();
                string sql = "SELECT COUNT(*) + 1 AS SO FROM TIENCONG";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                string l = "";
                if (dr.Read())
                    l = dr["SO"].ToString();
                con.Close();
                return "TC" + l;
            }
        }
    }
}

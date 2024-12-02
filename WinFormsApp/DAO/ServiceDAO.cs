using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.DAO
{
    internal class ServiceDAO
    {
        public static ServiceDAO instance;

        public DataTable FindBaseName(string baseName)
        {
            string query = "SELECT * FROM dbo.XE WHERE HieuXe = N'" + baseName + "'";
            return DataProvider.instance.ExecuteQuery(query);
        }
    }
}

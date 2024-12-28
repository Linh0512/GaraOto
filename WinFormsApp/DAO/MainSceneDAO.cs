using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp.DAO
{
    public class MainSceneDAO
    {
        private static MainSceneDAO instance;
        public static MainSceneDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new MainSceneDAO();
                return instance;
            }
            private set => instance = value;
        }

        private MainSceneDAO() { }

        public DataTable GetTodayReceivedCars()
        {
            try
            {
                string query = @"SELECT *
                               FROM XE 
                               WHERE CAST(NgayTiepNhan AS DATE) = CAST(GETDATE() AS DATE)";
                
                return DataProvider.instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách xe: {ex.Message}");
            }
        }

        public DataTable SearchCars(string searchValue, string searchType)
        {
            try
            {
                string query = @"SELECT BienSo, TenChuXe, HieuXe, DienThoai, TienNo 
                                FROM XE 
                                WHERE  CAST(NgayTiepNhan AS DATE) = CAST(GETDATE() AS DATE) AND ";

                // Thêm điều kiện tìm kiếm dựa trên loại tìm kiếm
                switch (searchType)
                {
                    case "BienSo":
                        query += "BienSo LIKE N'%" + searchValue + "%'";
                        break;
                    case "TenChuXe":
                        query += "dbo.fuConvertToUnsign1(TenChuXe) LIKE dbo.fuConvertToUnsign1(N'%" + searchValue + "%')";
                        break;
                    case "HieuXe":
                        query += "dbo.fuConvertToUnsign1(HieuXe) LIKE dbo.fuConvertToUnsign1(N'%" + searchValue + "%')";
                        break;
                    default:
                        query += "BienSo LIKE N'%" + searchValue + "%'";
                        break;
                }

                return DataProvider.instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tìm kiếm xe: {ex.Message}");
            }
        }
    }
}
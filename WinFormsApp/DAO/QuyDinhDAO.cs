using System.Data;
using WinFormsApp.Models;
using WinFormsApp.Utils;

namespace WinFormsApp.DAO
{
    public class QuyDinhDAO
    {
        private static QuyDinhDAO _instance;

        public static QuyDinhDAO Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new QuyDinhDAO();
                return _instance;
            }
        }

        private QuyDinhDAO()
        {
        }

        public QuyDinh GetQuyDinh()
        {
            string query = "SELECT * FROM QUYDINH";
            DataTable data = DataProvider.instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                return new QuyDinh
                {
                    SoXeSuaChuaToiDa = Convert.ToInt32(data.Rows[0]["SoXeSuaChuaToiDa"]),
                    TiLeLai = Convert.ToSingle(data.Rows[0]["TiLeLai"]),
                    SoHieuXeToiDa = Convert.ToInt32(data.Rows[0]["SoHieuXeToiDa"]),
                    VTPTToiDA = Convert.ToInt32(data.Rows[0]["VTPTToiDA"]),
                    LoaiTienCongToiDa = Convert.ToInt32(data.Rows[0]["LoaiTienCongToiDa"]),
                    ChoPhepTraVuotTienNo = Convert.ToInt32(data.Rows[0]["ChoPhepTraVuotTienNO"])
                };
            }

            // Trả về giá trị mặc định nếu không có dữ liệu
            return new QuyDinh
            {
                SoXeSuaChuaToiDa = 30, // Giá trị mặc định
                TiLeLai = 1.05f, // Giá trị mặc định
                SoHieuXeToiDa = 10,
                VTPTToiDA = 200,
                LoaiTienCongToiDa = 100,
                ChoPhepTraVuotTienNo = 0
            };
        }

        public void UpdateQuyDinh(QuyDinh quyDinh)
        {
            string query = $"UPDATE QUYDINH SET SoXeSuaChuaToiDa = {quyDinh.SoXeSuaChuaToiDa}, " +
                           $"TiLeLai = {quyDinh.TiLeLai}, " +
                           $"SoHieuXeToiDa = {quyDinh.SoHieuXeToiDa}, " +
                           $"VTPTToiDA = {quyDinh.VTPTToiDA}, " +
                           $"LoaiTienCongToiDa = {quyDinh.LoaiTienCongToiDa}, " +
                            $"ChoPhepTraVuotTienNo = {quyDinh.ChoPhepTraVuotTienNo}"; 

            DataProvider.instance.ExecuteQuery(query);
            QuyDinhManager.Instance.Refresh();
        }

    }
}
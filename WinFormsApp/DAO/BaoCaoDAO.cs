using System;
using System.Collections.Generic;
using System.Data;
using WinFormsApp.Models;

namespace WinFormsApp.DAO
{
    public class BaoCaoDAO
    {
        private static BaoCaoDAO instance;

        public static BaoCaoDAO Instance
        {
            get
            {
                if (instance == null) instance = new BaoCaoDAO();
                return instance;
            }
            private set => instance = value;
        }

        private BaoCaoDAO()
        {
        }

        public void ExportButtonClick(DataGridView dgv, string defaultFileName, string worksheetName)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog()
            { Filter = "Excel Workbook|*.xlsx", FileName = defaultFileName })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportDataGridViewToExcel(dgv, worksheetName, saveFileDialog.FileName);
                }
            }
        }

        public void ExportDataGridViewToExcel(DataGridView dgv, string worksheetName, string fileName)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!");
                return;
            }

            try
            {
                var excel = new Microsoft.Office.Interop.Excel.Application();
                var workbook = excel.Workbooks.Add(Type.Missing);
                var worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;

                worksheet.Name = worksheetName;

                // Add column headers
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
                }

                // Add data rows
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value?.ToString() ?? "";
                    }
                }

                workbook.SaveAs(fileName);
                workbook.Close();
                excel.Quit();

                // Release COM objects to prevent memory leaks
                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);

                MessageBox.Show("Xuất dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        public List<BaoCaoDoanhSo> GetBaoCaoDoanhSo(int thang, int nam)
        {
            string query = $@"
        WITH TongDoanhThu AS (
            SELECT SUM(ct.ThanhTien) as TongTien
            FROM PHIEUSUACHUA psc
            JOIN CT_PSC ct ON psc.MaPSC = ct.MaPSC
            WHERE MONTH(psc.NgaySuaChua) = {thang} 
            AND YEAR(psc.NgaySuaChua) = {nam}
        )
        SELECT 
            x.HieuXe,
            COUNT(DISTINCT psc.MaPSC) as SoLuotSua,
            SUM(ct.ThanhTien) as ThanhTien,
            CAST(
                SUM(ct.ThanhTien) * 100.0 / NULLIF((SELECT TongTien FROM TongDoanhThu), 0)
                AS float
            ) as TiLe
        FROM XE x
        JOIN PHIEUSUACHUA psc ON x.BienSo = psc.BienSo
        JOIN CT_PSC ct ON psc.MaPSC = ct.MaPSC
        WHERE MONTH(psc.NgaySuaChua) = {thang} 
        AND YEAR(psc.NgaySuaChua) = {nam}
        GROUP BY x.HieuXe";

            DataTable data = DataProvider.instance.ExecuteQuery(query);
            List<BaoCaoDoanhSo> result = new List<BaoCaoDoanhSo>();

            foreach (DataRow row in data.Rows)
            {
                BaoCaoDoanhSo baoCao = new BaoCaoDoanhSo
                {
                    HieuXe = row["HieuXe"].ToString(),
                    SoLuotSua = Convert.ToInt32(row["SoLuotSua"]),
                    ThanhTien = Convert.ToDecimal(row["ThanhTien"]),
                    TiLe = Convert.ToDouble(row["TiLe"])
                };
                result.Add(baoCao);
            }

            return result;
        }

        public decimal GetTongDoanhThu(int thang, int nam)
        {
            string query = $@"
                SELECT ISNULL(SUM(ct.ThanhTien), 0) as TongDoanhThu
                FROM PHIEUSUACHUA psc
                JOIN CT_PSC ct ON psc.MaPSC = ct.MaPSC
                WHERE MONTH(psc.NgaySuaChua) = {thang} AND YEAR(psc.NgaySuaChua) = {nam}";

            DataTable result = DataProvider.instance.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                return Convert.ToDecimal(result.Rows[0]["TongDoanhThu"]);
            }

            return 0;
        }

        public List<BaoCaoTon> GetBaoCaoTon(int thang, int nam)
        {
            string query = $@"
        WITH TonDauKy AS (
            SELECT 
                pt.MaVTPT,
                pt.TenVTPT,
                CASE 
                    WHEN EXISTS (
                        SELECT 1 
                        FROM CT_PNKVTPT ct 
                        JOIN PHIEUNHAPKHOVTPT p ON ct.MaNKVTPT = p.MaNKVTPT
                        WHERE ct.MaVTPT = pt.MaVTPT 
                        AND (
                            (MONTH(p.NgayNhap) < {thang} AND YEAR(p.NgayNhap) = {nam})
                            OR YEAR(p.NgayNhap) < {nam}
                        )
                    ) THEN
                        (
                            SELECT ISNULL(
                                (
                                    SELECT SUM(ct.SoLuong)
                                    FROM CT_PNKVTPT ct 
                                    JOIN PHIEUNHAPKHOVTPT p ON ct.MaNKVTPT = p.MaNKVTPT
                                    WHERE ct.MaVTPT = pt.MaVTPT 
                                    AND (
                                        (MONTH(p.NgayNhap) < {thang} AND YEAR(p.NgayNhap) = {nam})
                                        OR YEAR(p.NgayNhap) < {nam}
                                    )
                                ) -
                                ISNULL(
                                    (
                                        SELECT SUM(ct.SoLuong)
                                        FROM CT_PSC ct 
                                        JOIN PHIEUSUACHUA p ON ct.MaPSC = p.MaPSC
                                        WHERE ct.MaVTPT = pt.MaVTPT 
                                        AND (
                                            (MONTH(p.NgaySuaChua) < {thang} AND YEAR(p.NgaySuaChua) = {nam})
                                            OR YEAR(p.NgaySuaChua) < {nam}
                                        )
                                    ), 0
                                ), 0
                            )
                        )
                    ELSE 0
                END as TonDau
            FROM PHUTUNG pt
        ),
        NhapTrongKy AS (
            SELECT 
                ct.MaVTPT,
                SUM(ct.SoLuong) as SoLuongNhap
            FROM CT_PNKVTPT ct
            JOIN PHIEUNHAPKHOVTPT p ON ct.MaNKVTPT = p.MaNKVTPT
            WHERE MONTH(p.NgayNhap) = {thang} 
            AND YEAR(p.NgayNhap) = {nam}
            GROUP BY ct.MaVTPT
        ),
        XuatTrongKy AS (
            SELECT 
                ct.MaVTPT,
                SUM(ct.SoLuong) as SoLuongXuat
            FROM CT_PSC ct
            JOIN PHIEUSUACHUA p ON ct.MaPSC = p.MaPSC
            WHERE MONTH(p.NgaySuaChua) = {thang}
            AND YEAR(p.NgaySuaChua) = {nam}
            GROUP BY ct.MaVTPT
        )
        SELECT 
            t.MaVTPT,
            t.TenVTPT,
            t.TonDau,
            ISNULL(n.SoLuongNhap, 0) as SoLuongNhap,
            ISNULL(x.SoLuongXuat, 0) as SoLuongSuDung,
            t.TonDau + ISNULL(n.SoLuongNhap, 0) - ISNULL(x.SoLuongXuat, 0) as TonCuoi
        FROM TonDauKy t
        LEFT JOIN NhapTrongKy n ON t.MaVTPT = n.MaVTPT
        LEFT JOIN XuatTrongKy x ON t.MaVTPT = x.MaVTPT
        ORDER BY t.MaVTPT";

            try
            {
                DataTable data = DataProvider.instance.ExecuteQuery(query);
                List<BaoCaoTon> result = new List<BaoCaoTon>();

                foreach (DataRow row in data.Rows)
                {
                    BaoCaoTon baoCao = new BaoCaoTon
                    {
                        MaVTPT = row["MaVTPT"].ToString(),
                        TenVTPT = row["TenVTPT"].ToString(),
                        TonDau = Convert.ToInt32(row["TonDau"]),
                        SoLuongNhap = Convert.ToInt32(row["SoLuongNhap"]),
                        SoLuongSuDung = Convert.ToInt32(row["SoLuongSuDung"]),
                        TonCuoi = Convert.ToInt32(row["TonCuoi"])
                    };
                    result.Add(baoCao);
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetBaoCaoTon: {ex.Message}");
                Console.WriteLine($"Stack trace: {ex.StackTrace}");
                throw;
            }
        }

        private int GetTonDauThang(string maVTPT, int thang, int nam)
        {
            if (thang == 1)
            {
                thang = 12;
                nam--;
            }
            else
            {
                thang--;
            }

            string query = $@"
        SELECT ISNULL((
            SELECT pt.SoLuongTon - 
            ISNULL((
                SELECT SUM(ct.SoLuong)
                FROM CT_PSC ct 
                JOIN PHIEUSUACHUA p ON ct.MaPSC = p.MaPSC
                WHERE ct.MaVTPT = pt.MaVTPT 
                AND MONTH(p.NgaySuaChua) = {thang}
                AND YEAR(p.NgaySuaChua) = {nam}
            ), 0)
            FROM PHUTUNG pt
            WHERE pt.MaVTPT = '{maVTPT}'
        ), 0) as TonDau";

            DataTable result = DataProvider.instance.ExecuteQuery(query);
            if (result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0]["TonDau"]);
            }

            return 0;
        }
    }
}
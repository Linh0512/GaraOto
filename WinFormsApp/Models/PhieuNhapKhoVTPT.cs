using System.Data.SqlTypes;
using WinFormsApp.Model;

namespace WinFormsApp.Models
{
    public class PhieuNhapKhoVTPT
    {
        public string maNKVTPT { get; set; }
        public DateTime ngayNhap { get; set; }

        public SqlMoney tongTienNhap { get; set; }

        public string tenDangNhap { get; set; }

        public PhieuNhapKhoVTPT() { }

        //public PhieuNhapKhoVTPT(DateTime ngayNhap, Supplier supplier)
        //{
        //    ngayNhap = ngayNhap;
        //    supplier = supplier;
        //}
    }
}
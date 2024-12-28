using System.Data;
using System.Data.SqlClient;
using WinFormsApp.Models;

namespace WinFormsApp.DAO;

public class LoginDAO
{
    private static LoginDAO _instance;
    public static LoginDAO Instance
    {
        get
        {
            if (_instance == null)
                _instance = new LoginDAO();
            return _instance;
        }
    }

    private LoginDAO() { }

    public bool Login(string username, string password)
    {
        try
        {
            string query = $"SELECT * FROM NHANVIEN WHERE TenDangNhap = '{username}' AND MatKhau = '{password}'";
            
            DataTable result = DataProvider.instance.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                NhanVien user = new NhanVien
                {
                    TenDangNhap = result.Rows[0]["TenDangNhap"].ToString(),
                    TenNV = result.Rows[0]["TenNV"].ToString(),
                    ChucVu = result.Rows[0]["ChucVu"].ToString(),
                    DienThoai = result.Rows[0]["SDT"].ToString(),
                    Email = result.Rows[0]["Email"].ToString(),
                    DiaChi = result.Rows[0]["DiaChi"].ToString()
                };

                SessionManager.Instance.StartSession(user);
                return true;
            }
            return false;
        }
        catch (Exception ex)
        {
            throw new Exception("Lỗi đăng nhập: " + ex.Message);
        }
    }

    public void Logout()
    {
        SessionManager.Instance.EndSession();
    }
}
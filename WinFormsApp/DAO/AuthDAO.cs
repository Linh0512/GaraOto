using System.Data;
using System.Data.SqlClient;
using WinFormsApp.Models;

namespace WinFormsApp.DAO;

public class AuthDAO
{
    private static AuthDAO _instance;
    public static AuthDAO Instance
    {
        get
        {
            if (_instance == null)
                _instance = new AuthDAO();
            return _instance;
        }
    }

    private AuthDAO() { }

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

    public bool ChangePassword(string username, string oldPassword, string newPassword)
    {
        try
        {
            string checkQuery = $"SELECT * FROM NHANVIEN WHERE TenDangNhap = '{username}' AND MatKhau = '{oldPassword}'";

            if (DataProvider.instance.ExecuteQuery(checkQuery).Rows.Count == 0)
            {
                throw new Exception("Sai mật khẩu không chính xác!");
            }

            string updateQuery = $"UPDATE NHANVIEN SET MatKhau = '{newPassword}' WHERE TenDangNhap = '{username}'";

            int result = DataProvider.instance.ExecuteNonQuery(updateQuery);
            
            Console.WriteLine(result);
            return result > 0;
        }
        catch (Exception ex)
        {
            throw new Exception("Lỗi đổi mật khẩu: " + ex.Message);
        }
    }
} 
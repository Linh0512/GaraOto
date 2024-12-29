using WinFormsApp.Models;

public class SessionManager
{
    private static SessionManager _instance;
    private NhanVien _currentUser;

    public static SessionManager Instance 
    {
        get
        {
            if (_instance == null)
                _instance = new SessionManager();
            return _instance;
        }
    }

    private SessionManager() { }

    public NhanVien CurrentUser
    {
        get { return _currentUser; }
    }

    public void StartSession(NhanVien user)
    {
        _currentUser = user;
    }

    public void EndSession()
    {
        _currentUser = null;
    }

    public bool IsAdmin()
    {
        return _currentUser?.ChucVu == "Quản lý";
    }
    
    public bool isStaff()
    {
        return _currentUser?.ChucVu == "Nhân viên";
    }

    public bool IsLoggedIn()
    {
        return _currentUser != null;
    }
} 
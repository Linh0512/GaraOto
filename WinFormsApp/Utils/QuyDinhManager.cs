using WinFormsApp.Models;
using WinFormsApp.DAO;

namespace WinFormsApp.Utils
{
    public class QuyDinhManager
    {
        private static QuyDinhManager _instance;
        private QuyDinh _currentQuyDinh;

        public static QuyDinhManager Instance 
        {
            get
            {
                if (_instance == null)
                    _instance = new QuyDinhManager();
                return _instance;
            }
        }

        private QuyDinhManager() 
        {
            // Load quy định khi khởi tạo
            LoadQuyDinh();
        }

        private void LoadQuyDinh()
        {
            // Lấy quy định từ database
            _currentQuyDinh = QuyDinhDAO.Instance.GetQuyDinh();
        }

        public QuyDinh CurrentQuyDinh
        {
            get { return _currentQuyDinh; }
        }

        public bool canReceiveCar()
        {
            Console.WriteLine(MainSceneDAO.Instance.getTodayReceivedCarsCount());
            Console.WriteLine(_currentQuyDinh.SoXeSuaChuaToiDa);
            return MainSceneDAO.Instance.getTodayReceivedCarsCount() < _currentQuyDinh.SoXeSuaChuaToiDa;
        }

        public bool canAddBrand()
        {
            return MainSceneDAO.Instance.getCurrentBrandCount() < _currentQuyDinh.SoHieuXeToiDa;
        }

        public bool canAddVTPT()
        {
            return MainSceneDAO.Instance.getCurrentVTPTCount() < _currentQuyDinh.VTPTToiDA;
        }

        public bool canAddTienCong()
        {
            return MainSceneDAO.Instance.getCurrentTienCongCount() < _currentQuyDinh.LoaiTienCongToiDa;
        }

        public int canAllowOverduePayment()
        {
            return _currentQuyDinh.ChoPhepTraVuotTienNo;
        }
        

        public void Refresh()
        {
            LoadQuyDinh();
        }
    }
}
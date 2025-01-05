using WinFormsApp.Models;
using WinFormsApp.DAO;
using WinFormsApp.Utils;

namespace WinFormsApp.Screens;

public partial class fRegulations : Form
{
    public fRegulations()
    {
        InitializeComponent();
        LoadQuyDinh();

        // Chỉ cho phép nhập số
        btnUpdate.Text = "Cập nhật"; 
        txtCarTodayLimit.KeyPress += NumberOnly_KeyPress;
        txtCarBrandLimit.KeyPress += NumberOnly_KeyPress; // Số hiệu xe
        txtTiLeLai.KeyPress += NumberAndDot_KeyPress; // Cho phép số thập phân
        txtVTPTLimit.KeyPress += NumberOnly_KeyPress;
        txtTienCongLimit.KeyPress += NumberOnly_KeyPress;
    }

    private void LoadQuyDinh()
    {
        QuyDinh currentQuyDinh = QuyDinhManager.Instance.CurrentQuyDinh;

        txtCarTodayLimit.Text = currentQuyDinh.SoXeSuaChuaToiDa.ToString();
        txtCarBrandLimit.Text = currentQuyDinh.SoHieuXeToiDa.ToString();
        txtTiLeLai.Text = currentQuyDinh.TiLeLai.ToString();
        txtVTPTLimit.Text = currentQuyDinh.VTPTToiDA.ToString();
        txtTienCongLimit.Text = currentQuyDinh.LoaiTienCongToiDa.ToString();
        cBChoPhep.Checked = currentQuyDinh.ChoPhepTraVuotTienNo == 1;
    }

    private void NumberOnly_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void NumberAndDot_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
        {
            e.Handled = true;
        }

        // Chỉ cho phép một dấu thập phân
        if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
        {
            e.Handled = true;
        }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            QuyDinh quyDinh = new QuyDinh
            {
                SoXeSuaChuaToiDa = int.Parse(txtCarTodayLimit.Text),
                SoHieuXeToiDa = int.Parse(txtCarBrandLimit.Text),
                TiLeLai = float.Parse(txtTiLeLai.Text),
                VTPTToiDA = int.Parse(txtVTPTLimit.Text),
                LoaiTienCongToiDa = int.Parse(txtTienCongLimit.Text),
                ChoPhepTraVuotTienNo = cBChoPhep.Checked ? 1 : 0
            };

            // Kiểm tra các giá trị hợp lệ
            if (quyDinh.SoXeSuaChuaToiDa <= 0 || quyDinh.SoHieuXeToiDa <= 0 ||
                quyDinh.TiLeLai <= 0 || quyDinh.VTPTToiDA <= 0 || quyDinh.LoaiTienCongToiDa <= 0)
            {
                MessageBox.Show("Vui lòng nhập các giá trị lớn hơn 0", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            QuyDinhDAO.Instance.UpdateQuyDinh(quyDinh);
            DataUpdateEvent.NotifyPermissionChanged(); // Thông báo các form khác về thay đổi
            MessageBox.Show("Cập nhật quy định thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi khi cập nhật quy định: {ex.Message}", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
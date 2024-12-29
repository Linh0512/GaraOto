using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Screens.Service;
using WinFormsApp.Screens.Service.InforCar;
using Microsoft.Data.SqlClient;
using WinFormsApp.DAO;
using WinFormsApp.Models;
using DocumentFormat.OpenXml.Packaging;
using WinFormsApp.Utils;

namespace WinFormsApp.Screens.Service.Payment
{
    public partial class fPayment : Form
    {
        public fPayment()
        {
            InitializeComponent();
        }

        private void fPaying_Load(object sender, EventArgs e)
        {
            this.txbIdReceipt.Text = ServiceDAO.instance.LoadIdReceipt();
        }

        private void txtAmoutPaying_TextChanged(object sender, EventArgs e)
        {
            this.CalulateTheRest();
        }

        private void CalulateTheRest()
        {
            try
            {
                double debt = Convert.ToDouble(txbDebt.Text);
                double paying = Convert.ToDouble(txtAmoutPaying.Text);
                double theRest = debt - paying;
                txbTheRest.Text = theRest.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPaying_Click(object sender, EventArgs e)
        {
            double debt = Convert.ToDouble(txbDebt.Text);
            if (string.IsNullOrWhiteSpace(this.txtAmoutPaying.Text))
            {
                MessageBox.Show("Vui lòng nhập số tiền thanh toán");
                return;
            }

            if (!double.TryParse(txtAmoutPaying.Text, out double amountPaying))
            {
                MessageBox.Show("Số tiền thanh toán không hợp lệ");
                return;
            }

            if (amountPaying > debt)
            {
                if (QuyDinhManager.Instance.canAllowOverduePayment() == 0)
                {
                    MessageBox.Show("Số tiền thanh toán không được lớn hơn số tiền nợ");
                    return;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Số tiền thanh toán lớn hơn số tiền nợ. Bạn có chắc chắn muốn thanh toán?", "Thanh toán nợ", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        // Thanh toán nợ

                        try
                        {
                            SqlDataReader dr1 = ServiceDAO.instance.LoadDataByLicensePlate(lbPlateLicense.Text);
                            if (dr1.Read())
                            {
                                double newDebt = debt - amountPaying;
                                ServiceDAO.instance.UpdateDebt(lbPlateLicense.Text, newDebt);
                            }

                            ReceiptDAO.instance.Add(new PhieuThuTien()
                            {
                                MaPTT = txbIdReceipt.Text,
                                BienSo = lbPlateLicense.Text,
                                //NgayThuTien = this.dtpDatePay.Value,
                                SoTienThu = Convert.ToDecimal(amountPaying)
                            });

                            MessageBox.Show("Thanh toán thành công!");
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Thanh toán thất bại: {ex.Message}");
                            return;
                        }
                    }
                }
            }
            else
            {
                try
                {
                    SqlDataReader dr1 = ServiceDAO.instance.LoadDataByLicensePlate(lbPlateLicense.Text);
                    if (dr1.Read())
                    {
                        double newDebt = debt - amountPaying;
                        ServiceDAO.instance.UpdateDebt(lbPlateLicense.Text, newDebt);
                    }

                    ReceiptDAO.instance.Add(new PhieuThuTien()
                    {
                        MaPTT = txbIdReceipt.Text,
                        BienSo = lbPlateLicense.Text,
                        //NgayThuTien = this.dtpDatePay.Value,
                        SoTienThu = Convert.ToDecimal(amountPaying)
                    });

                    MessageBox.Show("Thanh toán thành công!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Thanh toán thất bại: {ex.Message}");
                    return;
                }
            }
        }
    }
}

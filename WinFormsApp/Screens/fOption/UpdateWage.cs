using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.DAO;
using WinFormsApp.Model;

namespace WinFormsApp.Screens.Option
{
    public partial class UpdateWage : Form
    {
        private string WageID;
        private string WageType;
        private string WageAmount;
        public UpdateWage(string wageID, string wageType, string wageAmount)
        {
            InitializeComponent();
            WageID = wageID;
            WageType = wageType;
            WageAmount = wageAmount;

            txtWageType.Text = WageType;
            txtValue.Text = WageAmount;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtWageType.Text) || String.IsNullOrEmpty(txtValue.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            OptionDAO.Instance.UpdateWage(new Wage()
            {
                MaTienCong = WageID,
                NoiDung = txtWageType.Text,
                TienCong = txtValue.Text
            });

            MessageBox.Show("Cập nhật thông tin thành công!");
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

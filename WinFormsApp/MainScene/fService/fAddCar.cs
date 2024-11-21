using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.MainScene
{
    public partial class fAddCar : Form
    {
        public fAddCar()
        {
            InitializeComponent();
        }

        private void fAddCar_Load(object sender, EventArgs e)
        {
            this.SetPlaceHolder(txbNameCarOwner, "Tên chủ xe");
            this.SetPlaceHolder(txbLicensePlate, "Biển số xe");
            this.SetPlaceHolder(txbAddress, "Địa chỉ");
            this.SetPlaceHolder(txbPhoneNumber, "Số điện thoại");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SetPlaceHolder(TextBox text, String placeHolder)
        {
            text.Text = placeHolder;
            text.ForeColor = Color.Gray;

            text.Enter += (sender, e) =>
            {
                if (text.Text == placeHolder)
                {
                    text.Text = "";
                    text.ForeColor = Color.Black;
                }
            };

            text.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(text.Text))
                {
                    text.Text = placeHolder;
                    text.ForeColor = Color.Gray;
                }
            };
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

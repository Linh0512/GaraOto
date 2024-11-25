using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.MainScene.fInventory
{
    public partial class fPayment : Form
    {
        public fPayment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            txt_author.Text = "Admin";
            AddRowToDataGridView();
        }

        private void AddRowToDataGridView()
        {
            // Example data
            string stt = "1";
            string vatTu = "Ắc quy Đồng Nai N100";
            decimal giaNhap = 2000000;
            int soLuong = 1;
            decimal donGia = giaNhap * soLuong;

            // Add the row to the DataGridView
            dataGridView1.Rows.Add(stt, vatTu, giaNhap.ToString("N0"), soLuong, donGia.ToString("N0"));
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Screens.Service.InforCar;

namespace WinFormsApp.Screens.Service.Paying
{
    public partial class fPaying : Form
    {
        public fPaying(DataGridView table)
        {
            InitializeComponent();
            CopyDataFromDataGridView(table);
        }

        private void fPaying_Load(object sender, EventArgs e)
        {
            this.lbTotalAmout.Text = CalculateTotalAmount().ToString();
        }

        private double CalculateTotalAmount()
        {
            double totalAmount = 0;
            try
            {
                foreach (DataGridViewRow row in dtgvPayment.Rows)
                {
                    totalAmount += Convert.ToDouble(row.Cells["cellTotalMoney"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            return totalAmount;
        }

        private void CopyDataFromDataGridView(DataGridView source)
        {
            // Xóa dữ liệu cũ (nếu có) trong dtgvPayment
            dtgvPayment.Rows.Clear();
            dtgvPayment.Columns.Clear();

            // Sao chép cột
            foreach (DataGridViewColumn col in source.Columns)
            {
                DataGridViewColumn newCol = (DataGridViewColumn)col.Clone();
                newCol.Name = col.Name; // Giữ nguyên Name của cột
                dtgvPayment.Columns.Add(newCol);
            }


            // Sao chép dòng
            foreach (DataGridViewRow row in source.Rows)
            {
                if (!row.IsNewRow) // Bỏ qua dòng trống cuối cùng
                {
                    DataGridViewRow newRow = (DataGridViewRow)row.Clone();
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        newRow.Cells[i].Value = row.Cells[i].Value;
                    }
                    dtgvPayment.Rows.Add(newRow);
                }
            }
        }

    }
}

using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WinFormsApp.Screens.Service.ListRepair_Detail
{
    public partial class fListRepair_Detail : Form
    {
        public fListRepair_Detail(string idRepair, string licensePlate, string dateFix, string totalAmout)
        {
            InitializeComponent();
            this.txbIdRepair.Text = idRepair;
            this.txbLicensePlate.Text = licensePlate;
            this.dtpDateFix.Text = dateFix;
            this.txbTotalAmount.Text = totalAmout;
        }

        private void fListRepair_Load(object sender, EventArgs e)
        {
            this.LoadDataRepair_Detail();
        }

        private void LoadDataRepair_Detail()
        {
            string idRepair = this.txbIdRepair.Text;
            this.dtgvRepairList_Detail.DataSource = RepairDAO.instance.LoadListRepair_Detail(idRepair);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (this.dtgvRepairList_Detail.Rows.Count == 0)
                MessageBox.Show("Không có thông tin để xuất!");
            else
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (XLWorkbook workbook = new XLWorkbook())
                            {
                                workbook.Worksheets.Add(this.dtgvRepairList_Detail.DataSource as DataTable, "CT_PSC");

                                workbook.SaveAs(saveFileDialog.FileName);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Xuất file không thành công!");
                        }
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

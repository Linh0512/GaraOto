﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class fService : Form
    {
        public fService()
        {
            InitializeComponent();
        }

        private void Service_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void cbbLicensePlate_Click(object sender, EventArgs e)
        {
            if (cbbLicensePlate.Text == "Biển Số")
            {
                cbbLicensePlate.Text = "";
            }
        }

        private void cbbHieuXe_Click(object sender, EventArgs e)
        {
            if (cbbHieuXe.Text == "Hiệu xe")
            {
                cbbHieuXe.Text = "";
            }
        }

        private void cbbTienNo_Click(object sender, EventArgs e)
        {
            if (cbbTienNo.Text == "Tiền nợ")
            {
                cbbTienNo.Text = "";
            }
        }

        private void cbbChuXe_Click(object sender, EventArgs e)
        {
            if (cbbChuXe.Text == "Chủ xe")
            {
                cbbChuXe.Text = "";
            }
        }

        private void cbbHieuXe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bnThemXe_Click(object sender, EventArgs e)
        {

        }

        private void dgvService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

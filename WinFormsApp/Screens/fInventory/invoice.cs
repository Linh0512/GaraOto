﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.Screens.fInventory
{
    public partial class invoice : Form
    {
        public invoice()
        {
            InitializeComponent();
            cbb_inventory.SelectedIndex = 0;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

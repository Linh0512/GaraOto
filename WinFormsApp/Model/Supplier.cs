﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Model
{
    internal class Supplier
    {
        public static Supplier Instance = new Supplier();
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
    }
}

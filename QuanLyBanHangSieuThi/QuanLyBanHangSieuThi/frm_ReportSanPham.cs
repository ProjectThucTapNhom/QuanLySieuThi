﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangSieuThi
{
    public partial class frm_ReportSanPham : Form
    {
        public frm_ReportSanPham()
        {
            InitializeComponent();
        }

        private void frm_ReportSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLBANHANGDataSet.vw_DanhSachSanPham' table. You can move, or remove it, as needed.
            this.vw_DanhSachSanPhamTableAdapter.Fill(this.QLBANHANGDataSet.vw_DanhSachSanPham);

            this.reportViewer1.RefreshReport();

        }
    }
}

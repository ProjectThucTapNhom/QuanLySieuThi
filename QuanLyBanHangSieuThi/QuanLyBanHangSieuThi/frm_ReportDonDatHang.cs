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
    public partial class frm_ReportDonDatHang : Form
    {
        public frm_ReportDonDatHang()
        {
            InitializeComponent();
        }

        private void frm_DonDatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLBANHANGDataSet.vw_DanhSachDonDatHang' table. You can move, or remove it, as needed.
            this.vw_DanhSachDonDatHangTableAdapter.Fill(this.QLBANHANGDataSet.vw_DanhSachDonDatHang);

            this.reportViewer2.RefreshReport();
        }
    }
}

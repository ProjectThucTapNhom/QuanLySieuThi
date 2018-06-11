using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using DTO;

namespace QuanLyBanHangSieuThi
{
    public partial class frm_ReportPhieuXuat : Form
    {
        public frm_ReportPhieuXuat()
        {
            InitializeComponent();
        }

        private void SetParameters(int mapx)
        {
            ReportParameter rp = new ReportParameter("MaPx");
            rp.Values.Add(mapx.ToString());

            reportViewer1.LocalReport.SetParameters(rp);

        }

        private void frm_ReportPhieuXuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLBANHANGDataSet.vw_PhieuXuatKhachHang' table. You can move, or remove it, as needed.
            this.vw_PhieuXuatKhachHangTableAdapter.Fill(this.QLBANHANGDataSet.vw_PhieuXuatKhachHang);

            int mapx = PhieuXuatHang.MaPxKh;
            SetParameters(mapx);

            this.reportViewer1.RefreshReport();
        }
    }
}

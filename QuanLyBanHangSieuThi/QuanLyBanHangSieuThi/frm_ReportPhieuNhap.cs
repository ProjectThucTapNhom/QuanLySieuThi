using System;
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
    public partial class frm_ReportPhieuNhap : Form
    {
        public frm_ReportPhieuNhap()
        {
            InitializeComponent();
        }

        private void frm_ReportPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLBANHANGDataSet.vw_DanhSachPhieuNhap' table. You can move, or remove it, as needed.
            this.vw_DanhSachPhieuNhapTableAdapter.Fill(this.QLBANHANGDataSet.vw_DanhSachPhieuNhap);

            this.reportViewer1.RefreshReport();
        }
    }
}

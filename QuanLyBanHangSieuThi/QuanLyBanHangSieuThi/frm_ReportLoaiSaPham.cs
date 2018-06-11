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
    public partial class frm_ReportLoaiSaPham : Form
    {
        public frm_ReportLoaiSaPham()
        {
            InitializeComponent();
        }

        private void frm_ReportLoaiSaPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLBANHANGDataSet.vw_DanhSachLoaiSanPham' table. You can move, or remove it, as needed.
            this.vw_DanhSachLoaiSanPhamTableAdapter.Fill(this.QLBANHANGDataSet.vw_DanhSachLoaiSanPham);

            this.reportViewer1.RefreshReport();
        }
    }
}

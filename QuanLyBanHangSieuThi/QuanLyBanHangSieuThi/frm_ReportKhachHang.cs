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
    public partial class frm_ReportKhachHang : Form
    {
        public frm_ReportKhachHang()
        {
            InitializeComponent();
        }

        private void frm_ReportKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLBANHANGDataSet.vw_DanhSachKhachHang' table. You can move, or remove it, as needed.
            this.vw_DanhSachKhachHangTableAdapter.Fill(this.QLBANHANGDataSet.vw_DanhSachKhachHang);

            this.reportViewer1.RefreshReport();
        }
    }
}

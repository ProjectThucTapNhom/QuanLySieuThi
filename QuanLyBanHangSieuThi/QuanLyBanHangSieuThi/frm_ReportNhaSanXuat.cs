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
    public partial class frm_ReportNhaSanXuat : Form
    {
        public frm_ReportNhaSanXuat()
        {
            InitializeComponent();
        }

        private void frm_ReportNhaSanXuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLBANHANGDataSet.vw_DanhSachNhaSanXuat' table. You can move, or remove it, as needed.
            this.vw_DanhSachNhaSanXuatTableAdapter.Fill(this.QLBANHANGDataSet.vw_DanhSachNhaSanXuat);

            this.reportViewer1.RefreshReport();
        }
    }
}

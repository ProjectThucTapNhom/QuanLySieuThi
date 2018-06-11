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
    public partial class frm_ReportNhaCungCap : Form
    {
        public frm_ReportNhaCungCap()
        {
            InitializeComponent();
        }

        private void frm_ReportNhaCungCap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLBANHANGDataSet.vw_DanhSachNhaCungCap' table. You can move, or remove it, as needed.
            this.vw_DanhSachNhaCungCapTableAdapter.Fill(this.QLBANHANGDataSet.vw_DanhSachNhaCungCap);

            this.reportViewer1.RefreshReport();
        }
    }
}

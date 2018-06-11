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
    public partial class frm_ReportNhanVien : Form
    {
        public frm_ReportNhanVien()
        {
            InitializeComponent();
        }

        private void frm_ReportNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLBANHANGDataSet.vw_DanhSachNhanVien' table. You can move, or remove it, as needed.
            this.vw_DanhSachNhanVienTableAdapter.Fill(this.QLBANHANGDataSet.vw_DanhSachNhanVien);

            this.reportViewer1.RefreshReport();
        }
    }
}

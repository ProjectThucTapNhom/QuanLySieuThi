using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using QuanLyBanHangSieuThi.UcControl;

namespace QuanLyBanHangSieuThi
{
    public partial class frm_Main : Form
    {
        public frm_Main(string fullname, string namepermission)
        {
            InitializeComponent();
            lbFullName.Text = fullname;
            lbNamePermission.Text = namepermission;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            panel_Slide.Height = btnNhanVien.Height;
            panel_Slide.Top = btnNhanVien.Top;

            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_NhanVien());
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            panel_Slide.Height = btnNhaCungCap.Height;
            panel_Slide.Top = btnNhaCungCap.Top;

            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_NhaCungCap());
        }

        private void btnNhaSanXuat_Click(object sender, EventArgs e)
        {
            panel_Slide.Height = btnNhaSanXuat.Height;
            panel_Slide.Top = btnNhaSanXuat.Top;

            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_NhaSanXuat());
        }

        private void btnLoaiSanPham_Click(object sender, EventArgs e)
        {
            panel_Slide.Height = btnLoaiSanPham.Height;
            panel_Slide.Top = btnLoaiSanPham.Top;

            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_LoaiSanPham());
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            panel_Slide.Height = btnSanPham.Height;
            panel_Slide.Top = btnSanPham.Top;

            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_SanPham());
        }

        private void btnDonDatHang_Click(object sender, EventArgs e)
        {
            panel_Slide.Height = btnDonDatHang.Height;
            panel_Slide.Top = btnDonDatHang.Top;

            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_DonDatHang());
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            panel_Slide.Height = btnPhieuNhap.Height;
            panel_Slide.Top = btnPhieuNhap.Top;

            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_PhieuNhap());
        }

        private void btnPhieuXuat_Click(object sender, EventArgs e)
        {
            panel_Slide.Height = btnPhieuXuat.Height;
            panel_Slide.Top = btnPhieuXuat.Top;

            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_PhieuXuat());
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            đăngNhậpToolStripMenuItem.Visible = false;
            if(UserInfo.permission == "NVBH")
            {
                phânQuyềnToolStripMenuItem.Visible = false;
                toolStripSeparator1.Visible = false;
                saoLưuToolStripMenuItem.Visible = false;
                thốngKêToolStripMenuItem.Visible = false;
                danhMụcToolStripMenuItem.Visible = false;
                btnNhanVien.Visible = false;
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn bạn có muốn thoát?", "Xác Nhận Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            frm_Login login = new frm_Login();
            login.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_ThongKeDonHang());
        }

        private void thốngKêPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_ThongKePhieuNhap());
        }

        private void thốngKêHóaĐơnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_ThongKePhieuXuat());
        }

        private void thốngKêTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_ThongKeTonKho());
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Backup frmBackup = new frm_Backup();
            frmBackup.ShowDialog();
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Restore frmRestore = new frm_Restore();
            frmRestore.ShowDialog();
        }

        private void phânQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_PhanQuyen frmPhanQuyen = new frm_PhanQuyen();
            frmPhanQuyen.ShowDialog();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            panel_Slide.Height = btnPhieuNhap.Height;
            panel_Slide.Top = btnPhieuNhap.Bottom;

            frm_KhachHang kh = new frm_KhachHang();
            kh.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_NhanVien());
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_NhaCungCap());
        }

        private void nhàSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_NhaSanXuat());
        }

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_LoaiSanPham());
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_DonDatHang());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_DonDatHang());
        }

        private void phiếuNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_PhieuNhap());
        }

        private void hóaĐơnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_PhieuXuat());
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

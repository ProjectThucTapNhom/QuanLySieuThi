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

namespace QuanLyBanHangSieuThi
{
    public partial class frm_Backup : Form
    {

        SaoLuu sl = new SaoLuu();
        SaoLuuBLL slbll = new SaoLuuBLL();

        public frm_Backup()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = dlg.SelectedPath;
                    btnOk.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi backup! " + ex.Message);
            }
        }

        private void frm_Backup_Load(object sender, EventArgs e)
        {
            btnOk.Enabled = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                sl.Path = txtPath.Text;
                bool result = slbll.BackUpDataBase(sl);

                if (result)
                {
                    MessageBox.Show("Tạo bản sao thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi backup! " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

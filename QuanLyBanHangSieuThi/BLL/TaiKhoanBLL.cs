using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanAccess taiKhoanAccess = new TaiKhoanAccess();
        public List<TaiKhoan> ShowTaiKhoan()
        {
            return taiKhoanAccess.HienThiDanhSachTaiKhoan();
        }


        // Phan quyen
        public bool PermissionForEmployee(TaiKhoan tk)
        {
            return taiKhoanAccess.PhanQuyenNhanVien(tk);
        }

        // Hien Thi Ma Quyen Han Len Combox 
        public DataTable LoadComboBoxMAQH()
        {
            return taiKhoanAccess.HienThiMaQuyenHanLenComboBox();
        }


        // Loc Tai Khoan Nhan Vien Theo Ma Quyen Han
        public List<TaiKhoan> FilterEmployeeFlowIdPermission(TaiKhoan tk)
        {
            return taiKhoanAccess.LocThongTinNhaVienTheoMaQh(tk);
        }

        // Update Tai Khoan
        public bool UpdateTaiKhoan(TaiKhoan tk)
        {
            return taiKhoanAccess.UpdateTaiKhoan(tk);
        }
    }
}

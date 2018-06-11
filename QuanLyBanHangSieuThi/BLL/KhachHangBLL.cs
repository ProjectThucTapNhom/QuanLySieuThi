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
    public class KhachHangBLL
    {
        KhachHangAccess khachHangAccess = new KhachHangAccess();

        // Hien Thi Danh Sach Khach Hang
        public DataTable HienThiDanhSachKhach()
        {
            return khachHangAccess.GetAllCustomer();
        }


        // Hien Thi Khach Hang
        public List<KhachHang> ShowAllListKhachHang()
        {
            return khachHangAccess.GetAllListCustomer();
        }

        // Them Khach Hang
        public bool InsertKhachHang(KhachHang kh)
        {
            return khachHangAccess.ThemKhachHang(kh);
        }

        // Sua Khach Hang
        public bool UpdateKhachHang(KhachHang kh)
        {
            return khachHangAccess.EditKhachHang(kh);
        }

        // Xoa Khang Hang
        public bool DeleteKhachHang(KhachHang kh)
        {
            return khachHangAccess.DeleteKhachHang(kh);
        }

        // Hien Thi Report Khach Hang
        public DataTable HienThiReportKhachHang()
        {
            return khachHangAccess.HienThiReportKhachHang();
        }

        // Loc Danh Sach Khang Hang
        public List<KhachHang> LocDanhSachKhachHang(KhachHang nv)
        {
            return khachHangAccess.LocDanhSachKhachHang(nv);
        }

        // Tim Kiem Khach Hang
        public List<KhachHang> TimKiemKhachHang(KhachHang kh)
        {
            return khachHangAccess.TimKiemKhachHang(kh);
        }
    }
}

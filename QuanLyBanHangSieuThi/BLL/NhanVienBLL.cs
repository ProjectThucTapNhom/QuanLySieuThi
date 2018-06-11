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
    public class NhanVienBLL
    {
        NhanVienAccess nhanVienAccess = new NhanVienAccess();

        // HIen thi danh sach Nhan Vien
        public DataTable GetAllEmployee(NhanVien nv)
        {
            return nhanVienAccess.GetAllEmployee(nv);
        }

        public List<NhanVien> GetAllLISTEmployee()
        {
            return nhanVienAccess.GetAllLISTEmployee();
        }

        // Them Nhan Vien
        public bool InserNhanVien(NhanVien nv)
        {
            return nhanVienAccess.ThemNhanVien(nv);
        }

        // Sua Nhan Vien
        public bool UpdateNhanVien(NhanVien nv)
        {
            return nhanVienAccess.EditNhanVien(nv);
        }

        //Delete Nhan Vien
        public bool DeleteNhanVien(NhanVien nv)
        {
            return nhanVienAccess.DeleteNhanVien(nv);
        }

        // Tim Kiem Nhan Vien
        public DataTable SearchNhanVien(NhanVien nv)
        {
            return nhanVienAccess.SearchNhanVien(nv);
        }

        // Hien Thi Report NhanVien
        public DataTable HienThiReportNhanVien()
        {
            return nhanVienAccess.HienThiDanhSachReport();
        }

        public List<NhanVien> LocDSNhanVien(NhanVien nv)
        {
            return nhanVienAccess.LocDSNhanVien(nv);
        }

        // Tim Kiem Nhan Vien
        public List<NhanVien> TimKiemNhanVien(NhanVien nv)
        {
            return nhanVienAccess.TimKiemNhanVien(nv);
        }
    }
}

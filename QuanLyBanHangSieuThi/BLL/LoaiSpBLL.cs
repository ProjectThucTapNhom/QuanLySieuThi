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
    public class LoaiSpBLL
    {
        LoaiSpAccess loaiSanPhamAccess = new LoaiSpAccess();
        public DataTable ShowAllLoaiSanPham()
        {
            return loaiSanPhamAccess.HienThiDanhSachLoaiSanPham();
        }

        public List<LoaiSp> GetAllListLoaiSp()
        {
            return loaiSanPhamAccess.GetAllListLoaiSp();
        }

        public bool InserLoaiSanPham(LoaiSp lsp)
        {
            return loaiSanPhamAccess.ThemLoaiSanPham(lsp);
        }

        public bool EditLoaiSanPham(LoaiSp lsp)
        {
            return loaiSanPhamAccess.SuaLoaiSanPham(lsp);
        }

        public bool DeleteLoaiSanPham(LoaiSp lsp)
        {
            return loaiSanPhamAccess.DeleteLoaiSanPham(lsp);
        }

        // Hien Thi Report Nha San Xuat
        public DataTable HienThiReportLoaiSanPham()
        {
            return loaiSanPhamAccess.HienThiReportLoaiSanPham();
        }

        // Tim Kiem Loai San Pham
        public List<LoaiSp> TimKiemLoaiSanPham(LoaiSp lsp)
        {
            return loaiSanPhamAccess.TimKiemLoaiSanPham(lsp);
        }

        // Load Danh Sach Loai San Pham
        public List<LoaiSp> LocDanhSachLoaiSanPham(LoaiSp lsp)
        {
            return loaiSanPhamAccess.LoadDanhSachLoaiSanPham(lsp);
        }
    }
}

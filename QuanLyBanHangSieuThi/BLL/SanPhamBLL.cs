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
    public class SanPhamBLL
    {
        SanPhamAccess sanPhamAccess = new SanPhamAccess();

        // Hiển Thị Sản Phẩm
        public DataTable ShowAllSanPham()
        {
            return sanPhamAccess.HienThiDanhSachSanPham();
        }

        public List<SanPham> GetAllListSanPham()
        {
            return sanPhamAccess.GetAllListSanPham();
        }

        // Hiển Thị Chi Tiết Sản Phẩm
        public DataTable ShowAllCTSP()
        {
            return sanPhamAccess.HienThiDanhSachChiTietSanPham();
        }

        // Hiển Thị Mã Nhà Sản Xuất
        public DataTable ShowAllMaSx()
        {
            return sanPhamAccess.HienThiMaNhaSanXuat();
        }

        // Hiển Thị Mã Loại Sản Phẩm
        public DataTable ShowAllMaLoaiSp()
        {
            return sanPhamAccess.HienThiMaLoaiSP();
        }

        // Hiển Thị Mã Sản Phẩm
        public DataTable ShowAllMaSp()
        {
            return sanPhamAccess.HienThiMaSpSearch();
        }

        // Hiển Thị Tên Nhà Sản Xuất
        public DataTable ShowAllTenNhaSx()
        {
            return sanPhamAccess.HienThiTenNhaSanXuat();
        }

        // Hiển Thị Tên Loại Sản Phẩm
        public DataTable ShowAllTenLoaiSp()
        {
            return sanPhamAccess.HienThiTenLoaiSanPham();
        }

        // Search Sản Phẩm Theo Mã Sản Phẩm 1
        public DataTable SearchIdProduct1(SanPham sp)
        {
            return sanPhamAccess.TimKiemSanPham1(sp);
        }

        // Search Sản Phẩm Theo Mã Sản Phẩm 2
        public DataTable SearchIdProduct2(SanPham sp)
        {
            return sanPhamAccess.TimKiemSanPham2(sp);
        }

        // Search San Pham 
        public List<SanPham> SearchProduct(SanPham sp)
        {
            return sanPhamAccess.TimKiemSanPhamTheoMa(sp);
        }

        // Hiển Thị Tên Nhà Sản Xuất Theo Mã Nhà Sản Xuất
        public DataTable ShowNameNhaSxFlow(SanPham sp)
        {
            return sanPhamAccess.LayThongTinhTenNhaSxTheoMa(sp);
        }

        // Hiển Thị Mã Sản Xuất Theo Tên Sản Xuất
        public DataTable ShowIdNhaSxFlow(SanPham sp)
        {
            return sanPhamAccess.LayThongTinMaSxTheoTenNhaSx(sp);
        }

        // Hiển Thị Mã Loại Theo Tên Loại Sản Phẩm
        public DataTable ShowIdLoaiSanPhamFlow(SanPham sp)
        {
            return sanPhamAccess.LayThongTinMaLoaiTheoTenLoaiSanPham(sp);
        }

        // Hiển Thị Tên Loại Sản Phẩm Theo Mã Loại Sản Phẩm
        public DataTable ShowNameLoaiSpFlow(SanPham sp)
        {
            return sanPhamAccess.LayThongTinTenLoaiSpTheoMa(sp);
        }

        // Thêm Sản Phẩm
        public bool InserSanPham(SanPham sp)
        {
            return sanPhamAccess.ThemSanPham(sp);
        }

        // Sửa Sản Phẩm
        public bool EditSanPham(SanPham sp)
        {
            return sanPhamAccess.EditSanPham(sp);
        }

        // Xóa Sản Phẩm
        public bool DeleteSanPham(SanPham sp)
        {
            return sanPhamAccess.DeleteSanPham(sp);
        }

        // Tim Kiem San Pham
        public List<SanPham> TimKiemSanPham(SanPham sp)
        {
            return sanPhamAccess.TimKiemSanPham(sp);
        }

        // Loc San Pham
        public List<SanPham> LocDanhSachSanPham(SanPham sp)
        {
            return sanPhamAccess.LocDanhSachSanhPham(sp);
        }
    }
}

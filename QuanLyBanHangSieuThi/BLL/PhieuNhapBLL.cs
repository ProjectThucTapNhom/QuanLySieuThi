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
    public class PhieuNhapBLL
    {
        PhieuNhapAccess phieuNhapAccess = new PhieuNhapAccess();

        // Hiển thị Phiếu Nhập
        public DataTable ShowDataPhieuNhap()
        {
            return phieuNhapAccess.HienThiDanhSachPhieuNhap();
        }

        public List<PhieuNhapHang> GetAllListPhieuNhap()
        {
            return phieuNhapAccess.GetAllListPhieuNhap();
        }

        // Hiển thị Chi Tiết Phiếu Nhập
        public DataTable ShowDataCTPN()
        {
            return phieuNhapAccess.HienThiDanhSachCTPN();
        }


        // Thêm Phiếu Nhập
        public bool InsertPhieuNhap(PhieuNhapHang pn)
        {
            return phieuNhapAccess.ThemPhieuNhap(pn);
        }

        // Sửa Phiếu Nhập
        public bool EditPhieuNhap(PhieuNhapHang pn)
        {
            return phieuNhapAccess.EditPhieuNhap(pn);
        }


        // Xóa Phiếu Nhập
        public bool DeletePhieuNhap(PhieuNhapHang pn)
        {
            return phieuNhapAccess.DeletePhieuNhap(pn);
        }

        // Hiển Thị Mã Nhà Cung Cấp
        public DataTable LoadComboxBoxMaDh()
        {
            return phieuNhapAccess.HienThiMaDonDatHang();
        }

        // Hiển thị Tên Sản Phẩm Theo Mã Sản Phẩm
        public DataTable HienThiTenSpTheoMaSp(PhieuNhapHang pn)
        {
            return phieuNhapAccess.HienThiTenSanPhamTheoMaSanPham(pn);
        }

        // Hiển Thị Tên Nhà Cung Cấp
        public DataTable LoadComboxTenNhaCungCap()
        {
            return phieuNhapAccess.HienThiTenNhaCungCap();
        }

        // Hiển Thị Mã Sản Phẩm
        public DataTable LoadComboBoxMaSanPham()
        {
            return phieuNhapAccess.HienThiMaSanPham();
        }

        // Hiển Thị Tên Nhà Cung Cấp Theo Mã Nhà Cung
        //public DataTable ShowTenNhaCungCapFlowMaCungCap(PhieuNhapHang pn)
        //{
        //    return phieuNhapAccess.HienThiTenNhaCungCapTheoMaCungCap(pn);
        //}

        // Hien Thi Thong Tin Don Hang Cho Phieu Nhap
        public DataTable HienThiThongTinDonHangChoPhieuNhap(PhieuNhapHang pn)
        {
            return phieuNhapAccess.HienThiThongTinDonHangChoPhieuNhap(pn);
        }

        // Hien Thi SLDH
        public DataTable HienThiSlDhTheoMaDhMaSp(PhieuNhapHang pn)
        {
            return phieuNhapAccess.HienThiSlDhTheoMaDhMaSp(pn);
        }

        // Hiển Thị Giá Thành
        public DataTable HienThiGiaThanhMaSp(PhieuNhapHang pn)
        {
            return phieuNhapAccess.HienThiGiaThanhMaSp(pn);
        }

        // Tim Kiem Phieu Nhap Hang
        public List<PhieuNhapHang> TimKiemPhieuNhap(PhieuNhapHang pn)
        {
            return phieuNhapAccess.TimKiemPhieuNhap(pn);
        }

        // Loc Danh Sach Phieu Nhap Hang
        public List<PhieuNhapHang> LocDanhSachPhieuNhap(PhieuNhapHang pn)
        {
            return phieuNhapAccess.LocDanhSachPhieuNhap(pn);
        }

        // Hiển Thị Thông Chi Cho Phiếu Nhập
        public List<PhieuNhapHang> HienThiThongTinChoPhieuNhap(PhieuNhapHang pn)
        {
            return phieuNhapAccess.HienThiThongTinChoPhieuNhap(pn);
        }
    }
}

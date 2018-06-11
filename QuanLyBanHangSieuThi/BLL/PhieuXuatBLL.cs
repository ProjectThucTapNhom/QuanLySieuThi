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
    public class PhieuXuatBLL
    {
        PhieuXuatAccess phieuXuatAccess = new PhieuXuatAccess();

        // Hiển thị danh sách PHIẾU XUẤT HÀNG
        #region Hiển thị danh sách PHIẾU XUẤT HÀNG
        public DataTable ShowListPhieuXuat()
        {
            return phieuXuatAccess.HienThiPhieuXuat();
        }
        #endregion

        // Hiển thi danh sách PHIEUXUATHANG
        #region Hiển thi danh sách PHIEUXUATHANG
        public List<PhieuXuatHang> GetAllListPhieuXuat()
        {
            return phieuXuatAccess.GetAllListPhieuNhap();
        }
        #endregion

        // Hiển thi danh sách CHI TIẾT PHIẾU XUẤT HÀNG
        #region Hiển thi danh sách CHI TIẾT PHIẾU XUẤT HÀNG
        public DataTable ShowListCTPX()
        {
            return phieuXuatAccess.HienThiCTPX();
        }
        #endregion



        // Hiển thị Mã Khách Hàng
        #region Hiển thị Mã Khách Hàng
        public DataTable ShowMaKhachHang()
        {
            return phieuXuatAccess.HienThiMaKhachHang();
        }
        #endregion



        // Hiển thị Tên Khách Hàng
        #region Hiển thị Tên Khách Hàng
        public DataTable ShowTenKhachHang()
        {
            return phieuXuatAccess.HienThiTenKhachHang();
        }
        #endregion


        // Hiển thị Tên Khách Hàng Theo Mã Khách Hàng
        #region Hiển thị Tên Khách Hàng Theo Mã Khách Hàng
        public DataTable ShowTenKhTheoMaKn(PhieuXuatHang px)
        {
            return phieuXuatAccess.HienThiTenKhTheoMaKh(px);
        }
        #endregion

        // HienThiTenSpTheoMaSp
        #region HienThiTenSpTheoMaSp
        public DataTable HienThiTenSpTheoMaSp(PhieuXuatHang px)
        {
            return phieuXuatAccess.HienThiTenSpTheoMaSp(px);
        }
        #endregion

        // Hiển thị Mã Sản Phẩm
        #region Hiển thị Mã Sản Phẩm
        public DataTable ShowMaSanPham()
        {
            return phieuXuatAccess.HienThiMaSanPham();
        }
        #endregion


        // Hiển thị Mã Đơn Hàng
        #region Hiển thị Mã Đơn Hàng
        public DataTable ShowMaDonHang()
        {
            return phieuXuatAccess.HienThiMaDonHang();
        }
        #endregion


        // Hiển thị Số Lượng Đặt Hàng
        #region Hiển thị Số Lượng Đặt Hàng
        public DataTable ShowSoLuongDatHang()
        {
            return phieuXuatAccess.HienThiSoLuongXuấtHang();
        }
        #endregion


        // Hiển thị Số Lượng Xuất Hàng Theo Mã Đơn hàng
        #region Hiển thị Số Lượng Xuất Hàng Theo Mã Đơn hàng
        public DataTable ShowSlxTheoMaDh(PhieuXuatHang px)
        {
            return phieuXuatAccess.HienThiSlxTheoMaDh(px);
        }
        #endregion


        // Hiển thị Mã Sản Phẩm Theo Đơn Đặt Hàng
        #region Hiển thị Mã Sản Phẩm Theo Đơn Đặt Hàng
        public DataTable ShowMaSpTheoMaDh(PhieuXuatHang px)
        {
            return phieuXuatAccess.HienThiMaSpTheoMaDh(px);
        }
        #endregion

        // Thêm PHIẾU XUẤT HÀNG
        #region Thêm PHIẾU XUẤT HÀNG
        public bool InsertPhieuXuatHang(PhieuXuatHang px)
        {
            return phieuXuatAccess.ThemPhieuXuatHang(px);
        }
        #endregion

        // Hiển Thi Thông Tin Phiếu Xuất Theo Mã Đơn Hàng
        #region
        public List<PhieuXuatHang> HienThiThongTinPhieuXuatTheoMaDh(PhieuXuatHang px)
        {
            return phieuXuatAccess.HienThiThongTinPhieuXuatTheoMaDh(px);
        }
        #endregion

        // Edit Phieu Xuat hang
        #region Edit Phieu Xuat
        public bool EditPhieuXuat(PhieuXuatHang px)
        {
            return phieuXuatAccess.EditPhieuXuat(px);
        }
        #endregion

        // Delete Phieu Xuat Hang
        #region Delte Phieu Xuat
        public bool DeletePhieuXuat(PhieuXuatHang px)
        {
            return phieuXuatAccess.DeletePhieuXuat(px);
        }
        #endregion

        // Select Gia Thanh San Pham
        public DataTable SelectGiaThanhSanPham(PhieuXuatHang px)
        {
            return phieuXuatAccess.SelectGiaThanhSanPham(px);
        }

        // Loc Tien Thua
        public DataTable LocTienThua(PhieuXuatHang px)
        {
            return phieuXuatAccess.LocTienThua(px);
        }

        // Tim Kiem Phieu Xuat 
        public List<PhieuXuatHang> TimKiemPhieuXuatHang(PhieuXuatHang px)
        {
            return phieuXuatAccess.TimKiemPhieuXuatHang(px);
        }

        // Loc Danh Sach Phieu Xuat
        public List<PhieuXuatHang> LocDanhSachPhieuXuatHang(PhieuXuatHang px)
        {
            return phieuXuatAccess.LocDanhSachPhieuXuatHang(px);
        }

        public DataTable TongSoLuongTonTheoMaSp(PhieuXuatHang px)
        {
            return phieuXuatAccess.TongSoLuongTonTheoMaSp(px);
        }
    }
}

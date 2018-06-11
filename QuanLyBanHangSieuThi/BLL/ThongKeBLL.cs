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
    public class ThongKeBLL
    {
        ThongKeAccess thongKeAccess = new ThongKeAccess();

        public List<ThongKe> ThongKeDonDatHangTheoNgayThang(ThongKe tk)
        {
            return thongKeAccess.ThongKeDonDatHangTheoNgayThang(tk);
        }

        public List<ThongKe> ThongKeDonDatHang()
        {
            return thongKeAccess.ThongKeDonDatHang();
        }

        public DataTable TongSldh()
        {
            return thongKeAccess.TongSldh();
        }

        public DataTable TonSldhTheoMaSp(ThongKe tk)
        {
            return thongKeAccess.TonSldhTheoMaSp(tk);
        }

        public List<ThongKe> ThongKeTonKho()
        {
            return thongKeAccess.ThongKeTonKho();
        }

        public List<ThongKe> ThongKeTonKhoTheoNgayThang(ThongKe tk)
        {
            return thongKeAccess.ThongKeTonKhoTheoNgayThang(tk);
        }

        public List<ThongKe> HienThiTenLoaiSanPham()
        {
            return thongKeAccess.HienThiTenLoaiSanPham();
        }

        public List<ThongKe> HienThiTenNhaSanXuat()
        {
            return thongKeAccess.HienThiTenNhaSanXuat();
        }

        public List<ThongKe> ThongKeDonDatHangTheoLoaiSp(ThongKe tk)
        {
            return thongKeAccess.ThongKeDonDatHangTheoLoaiSp(tk);
        }

        public List<ThongKe> ThongKeDonDatHangTheoNhaSx(ThongKe tk)
        {
            return thongKeAccess.ThongKeDonDatHangTheoNhaSx(tk);
        }

        public List<ThongKe> ThongKePhieuNhap()
        {
            return thongKeAccess.ThongKePhieuNhap();
        }

        public List<ThongKe> ThongKePhieuNhapTheoNgayThang(ThongKe tk)
        {
            return thongKeAccess.ThongKePhieuNhapTheoNgayThang(tk);
        }

        public List<ThongKe> ThongKePhieuXuat()
        {
            return thongKeAccess.ThongKePhieuXuat();
        }

        public List<ThongKe> ThongKePhieuXuatTheoNgayThang(ThongKe tk)
        {
            return thongKeAccess.ThongKePhieuXuatTheoNgayThang(tk);
        }

        public List<ThongKe> HienThiTenNhaCungCap()
        {
            return thongKeAccess.HienThiTenNhaCungCap();
        }

        public List<ThongKe> ThongKePhieuNhapTheoNhaCungCap(ThongKe tk)
        {
            return thongKeAccess.ThongKePhieuNhapTheoNhaCungCap(tk);
        }

        public List<ThongKe> ThongKePhieuNhapLoaiSp(ThongKe tk)
        {
            return thongKeAccess.ThongKePhieuNhapLoaiSp(tk);
        }

        public List<ThongKe> ThongKePHieuXuatTHeoSanPham(ThongKe tk)
        {
            return thongKeAccess.ThongKePHieuXuatTHeoSanPham(tk);
        }

        public List<ThongKe> ThongKePHieuXuatTHeoLoaiSp(ThongKe tk)
        {
            return thongKeAccess.ThongKePHieuXuatTHeoLoaiSp(tk);
        }

        public bool UpdateTongSldTonKho(ThongKe tk)
        {
            return thongKeAccess.UpdateTongSldTonKho(tk);
        }

        public List<ThongKe> ThongKeTonKhoTHeoLoaiSp(ThongKe tk)
        {
            return thongKeAccess.ThongKeTonKhoTHeoLoaiSp(tk);
        }

        public List<ThongKe> ThongKeTonKhoTHeoNhaSx(ThongKe tk)
        {
            return thongKeAccess.ThongKeTonKhoTHeoNhaSx(tk);
        }

        public List<ThongKe> TinhTongSoLuongTonKhoTheoNhaSx(ThongKe tk)
        {
            return thongKeAccess.TinhTongSoLuongTonKhoTheoNhaSx(tk);
        }

        public List<ThongKe> TinhTongSoLuongTonKhoTheoLoaiSp(ThongKe tk)
        {
            return thongKeAccess.TinhTongSoLuongTonKhoTheoLoaiSp(tk);
        }

        public DataTable TongSldhTheoLoaiSp(ThongKe tk)
        {
            return thongKeAccess.TongSldhTheoLoaiSp(tk);
        }

        public DataTable TongSldhTheoNhaSx(ThongKe tk)
        {
            return thongKeAccess.TongSldhTheoNhaSx(tk);
        }

        public DataTable TongSldhTheoNgayDh(ThongKe tk)
        {
            return thongKeAccess.TongSldhTheoNgayDh(tk);
        }

        public List<ThongKe> TongSoLuongNhapTheoNgayNhap(ThongKe tk)
        {
            return thongKeAccess.TongSoLuongNhapTheoNgayNhap(tk);
        }

        public List<ThongKe> TongSoLuongConNhapTheoNgayNhap(ThongKe tk)
        {
            return thongKeAccess.TongSoLuongConNhapTheoNgayNhap(tk);
        }

        public List<ThongKe> TinhThanhTienPhieuNhapTheoNgayNhap(ThongKe tk)
        {
            return thongKeAccess.TinhThanhTienPhieuNhapTheoNgayNhap(tk);
        }

        public List<ThongKe> TongSoLuongNhapTheoLoaiSp(ThongKe tk)
        {
            return thongKeAccess.TongSoLuongNhapTheoLoaiSp(tk);
        }

        public List<ThongKe> TongSoLuongConNhapTheoLoaiSp(ThongKe tk)
        {
            return thongKeAccess.TongSoLuongConNhapTheoLoaiSp(tk);
        }

        public List<ThongKe> TinhThanhTienPhieuNhapTheoLoaiSp(ThongKe tk)
        {
            return thongKeAccess.TinhThanhTienPhieuNhapTheoLoaiSp(tk);
        }

        public List<ThongKe> TongSoLuongNhapTheoNhaCc(ThongKe tk)
        {
            return thongKeAccess.TongSoLuongNhapTheoNhaCungCap(tk);
        }

        public List<ThongKe> TongSoLuongConNhapTheoNhaCc(ThongKe tk)
        {
            return thongKeAccess.TongSoLuongConNhapTheoNhaCungCap(tk);
        }

        public List<ThongKe> TinhThanhTienPhieuNhapTheoNhaCc(ThongKe tk)
        {
            return thongKeAccess.TinhThanhTienPhieuNhapTheoNhaCc(tk);
        }

        public List<ThongKe> TinhTongSoLuongTonKhoTheoNgayThang(ThongKe tk)
        {
            return thongKeAccess.TinhTongSoLuongTonKhoTheoNgayThang(tk);
        }

        public List<ThongKe> TinhTongSlpxTheoLoaiSanPham(ThongKe tk)
        {
            return thongKeAccess.TinhTongSlpxTheoLoaiSanPham(tk);
        }

        public List<ThongKe> TinhTongThanhTienTheoLoaiSanPham(ThongKe tk)
        {
            return thongKeAccess.TinhTongThanhTienTheoLoaiSanPham(tk);
        }

        public List<ThongKe> TinhTongSlpxTheoNhaSanXuat(ThongKe tk)
        {
            return thongKeAccess.TinhTongSlpxTheoNhaSanXuat(tk);
        }

        public List<ThongKe> TinhTongThanhTienTheoNhaSanXuat(ThongKe tk)
        {
            return thongKeAccess.TinhTongThanhTienTheoNhaSanXuat(tk);
        }

        public List<ThongKe> TinhTongSlpxTheoNgayXuat(ThongKe tk)
        {
            return thongKeAccess.TinhTongSlpxTheoNgayXuat(tk);
        }

        public List<ThongKe> TinhTongThanhTienTheoNgayXuat(ThongKe tk)
        {
            return thongKeAccess.TinhTongThanhTienTheoNgayXuat(tk);
        }

        public List<ThongKe> ThongKePHieuXuatTHeoNhaSx(ThongKe tk)
        {
            return thongKeAccess.ThongKePHieuXuatTHeoNhaSx(tk);
        }

        public DataTable TongSoLuongTonTheoMaSp(ThongKe tk)
        {
            return thongKeAccess.TongSoLuongTonTheoMaSp(tk);
        }
    }
}

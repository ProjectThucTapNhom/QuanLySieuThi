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
    public class DonDatHangBLL
    {
        DonDatHangAccess donDatHangAccess = new DonDatHangAccess();

        // Hiển thị danh sách Đơn Đặt Hàng
        public DataTable ShowDataDonDatHang()
        {
            return donDatHangAccess.HienThiDanhSachDonHang();
        }

        public List<DonDatHang> GetAllDataDonDh()
        {
            return donDatHangAccess.GetAllListDonDatHang();
        }

        // Hiển thị danh sách Chi Tiết Đơn Hàng
        public DataTable ShowDataCTDH()
        {
            return donDatHangAccess.HienThiDanhSachCTDH();
        }

        // Thêm Đơn Đặt Hàng
        public bool InsertDonDatHang(DonDatHang dh)
        {
            return donDatHangAccess.ThemDonHang(dh);
        }

        // Sửa Đơn Đặt Hàng
        public bool EditDonDatHang(DonDatHang dh)
        {
            return donDatHangAccess.EditDonDathang(dh);
        }

        // Xóa Đơn Đặt Hàng
        public bool DeleteDonDatHang(DonDatHang dh)
        {
            return donDatHangAccess.DeleteDonDatHang(dh);
        }

        // Hiển Thị Mã Nhà Cung Cấp
        public DataTable LoadComboBoxMacc()
        {
            return donDatHangAccess.LoadDataComboBoxMaCC();
        }

        // Hiển Thị Tên Nhà Cung Cấp
        public DataTable LoadTenNhaCC()
        {
            return donDatHangAccess.HienThiTenNhaCC();
        }


        // Hiển Thị Mã Loại Sản Phẩm
        public DataTable ShowAllMaLoaiSp()
        {
            return donDatHangAccess.HienThiMaLoaiSP();
        }


        // Hiển Thị Mã Sản Phẩm
        public DataTable ShowDataMaSp()
        {
            return donDatHangAccess.HienThiMaSp();
        }

        // Hien Thi Ten San Pham Theo Ma San Pham
        public DataTable HienThiTenSpTheoMaSp(DonDatHang dh)
        {
            return donDatHangAccess.HienThiTenSpTheoMaSp(dh);
        }

        // Hiển Thị Tên Nhà Cung Theo Mã Cung Câp
        public DataTable ShowTenCCFlowMaCC(DonDatHang dh)
        {
            return donDatHangAccess.HienThiTenNhaCCTheoMacc(dh);
        }

        // Hiển Thi Tên Nhân Viên Theo Mã Nhân Viên
        public DataTable HienThiTenNhanVienTheoMaNv(DonDatHang dh)
        {
            return donDatHangAccess.HienThiTenNhanVienTheoMaNv(dh);
        }
        // Tìm Kiếm Đơn Đặt Hàng
        public List<DonDatHang> TimKiemDonDatHang(DonDatHang dh)
        {
            return donDatHangAccess.TimKiemDonDatHang(dh);
        }

        // Loc Đơn Đặt Hàng
        public List<DonDatHang> LocDanhSanhSachDonDatHang(DonDatHang dh)
        {
            return donDatHangAccess.LocDanhSachDonHang(dh);
        }
    }
}

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
    public class NhaCungCapBLL
    {
        NhaCungCapAccess nhaCungCapAccess = new NhaCungCapAccess();
        public DataTable ShowAllNhaCC()
        {
            return nhaCungCapAccess.HienThiNhaCungCap();
        }

        public List<NhaCungCap> GetAllListNhaCungCap()
        {
            return nhaCungCapAccess.GetAllListNhaCungCap();
        }

        public bool InsertNhaCungCap(NhaCungCap ncc)
        {
            return nhaCungCapAccess.ThemNhaCungCap(ncc);
        }

        public bool EditNhaCungCap(NhaCungCap ncc)
        {
            return nhaCungCapAccess.SuNhaCungCap(ncc);
        }

        public bool DeleteNhaCungCap(NhaCungCap ncc)
        {
            return nhaCungCapAccess.DeleteNhaCungCap(ncc);
        }

        public DataTable HienThiReporthaCungCap()
        {
            return nhaCungCapAccess.HienThiNhaCungCap();
        }

        public List<NhaCungCap> TimKiemNhaCungCap(NhaCungCap ncc)
        {
            return nhaCungCapAccess.TimKiemNhaCungCap(ncc);
        }

        public List<NhaCungCap> LocDanhSachNhaCungCap(NhaCungCap ncc)
        {
            return nhaCungCapAccess.LocDanhSachNhaCungCap(ncc);
        }
    }
}

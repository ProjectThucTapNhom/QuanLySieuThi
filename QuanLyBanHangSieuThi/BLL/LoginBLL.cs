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
    public class LoginBLL
    {
        LoginAccess loginAccess = new LoginAccess();
        public bool KiemTraDangNhap(Login login)
        {
            return loginAccess.KiemTraDangNhap(login);
        }
    }
}

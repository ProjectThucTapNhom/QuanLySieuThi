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
    public class SaoLuuBLL
    {
        SaoLuuAccess saoluuAccess = new SaoLuuAccess();
        public bool BackUpDataBase(SaoLuu sl)
        {
            return saoluuAccess.BackupDataBase(sl);
        }

        public bool RestoreDataBase(SaoLuu sl)
        {
            return saoluuAccess.RestoreDataBase(sl);
        }
    }
}

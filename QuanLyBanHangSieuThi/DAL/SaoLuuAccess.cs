using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class SaoLuuAccess:DataConnect
    {
        public bool BackupDataBase(SaoLuu sl)
        {

            try
            {
                OpenConnection();
                bool isCheck = false;
                string DataBase = conn.Database.ToString();
                //string q = "BACKUP DATABASE [" + DataBase + "] TO DISK='" + sl.Path + "\\" + "Database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
                //string sql = "BACKUP DATABASE ["+ DataBase + "] TO DISK='" + sl.Path + "\\" + "Database" + "-" + DateTime.Now.ToString("dd-MM-yyyy--HH-mm-ss") + ".bak'";

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "BACKUP DATABASE [" + DataBase + "] TO DISK='" + sl.Path + "\\" + "Database" + "-" + DateTime.Now.ToString("dd-MM-yyyy--HH-mm-ss") + ".bak'";

                sqlCommand.Connection = conn;

                int result = sqlCommand.ExecuteNonQuery();

                if (result != 0)
                {
                    isCheck = true;
                }

                return isCheck;
            }
            catch
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool RestoreDataBase(SaoLuu sl)
        {
            try
            {
                bool isCheck = false;
                OpenConnection();
                string DataBase = conn.Database.ToString();

                //SqlCommand sqlCommand = new SqlCommand();
                //sqlCommand.CommandType = CommandType.Text;
                //sqlCommand.CommandText = "USE master RESTORE DATABASE QLBANHANG FROM DISK='" + patch + "'";
                //sqlCommand.Connection = conn;

                string sql1 = string.Format("ALTER DATABASE [" + DataBase + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                int result_1 = cmd1.ExecuteNonQuery();

                string sql2 = string.Format("USE MASTER RESTORE DATABASE [" + DataBase + "] FROM DISK='" + sl.Path + "' WITH REPLACE;");
                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                int result_2 = cmd2.ExecuteNonQuery();

                string sql3 = string.Format("ALTER DATABASE [" + DataBase + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(sql3, conn);
                int result_3 = cmd3.ExecuteNonQuery();
                // s.Speak("Database Restored successfully");


                if (result_1 != 0 && result_2 != 0 && result_3 != 0)
                {
                    isCheck = true;
                }

                return isCheck;
            }
            catch
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }

        }
    }
}

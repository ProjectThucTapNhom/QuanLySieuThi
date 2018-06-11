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
    public class NhaSanXuatAccess:DataConnect
    {
        public DataTable HienThiDanhSachNhaSanXuat()
        {
            try
            {
                OpenConnection();
                SqlDataAdapter reader = new SqlDataAdapter("SELECT *FROM dbo.NHASX", conn);

                DataTable dt = new DataTable();
                reader.Fill(dt);

                return (dt);
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

        public List<NhaSx> GetAllListNhaSx()
        {
            try
            {
                OpenConnection();
                List<NhaSx> nsxlist = new List<NhaSx>();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT *FROM dbo.NHASX";
                sqlCommand.Connection = conn;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    NhaSx nsx = new NhaSx();
                    nsx.MaSx = int.Parse(dt.Rows[i][0].ToString());
                    nsx.TenSx = dt.Rows[i][1].ToString();
                    nsx.QuocGia = dt.Rows[i][2].ToString();

                    nsxlist.Add(nsx);
                }
                sqlReader.Close();
                return nsxlist;
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

        //NhaSx nsx = new NhaSx();
        public bool ThemNhaSanXuat(NhaSx nsx)
        {
            try
            {
                bool nhasxCheck = false;

                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_Insert_NHASX";
                command.Connection = conn;

                command.Parameters.Add("@TENSX", SqlDbType.NVarChar).Value = nsx.TenSx;
                command.Parameters.Add("@QUOCGIA", SqlDbType.NVarChar).Value = nsx.QuocGia;

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    nhasxCheck = true;
                }

                return nhasxCheck;
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


        // Sua Nha San Xuat
        public bool SuaNhaNhaSanXuat(NhaSx nsx)
        {
            try
            {
                bool nhasxCheck = false;

                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_UPDATE_NHASX";
                command.Connection = conn;

                command.Parameters.Add("@TENSX", SqlDbType.NVarChar).Value = nsx.TenSx;
                command.Parameters.Add("@QUOCGIA", SqlDbType.NVarChar).Value = nsx.QuocGia;
                command.Parameters.Add("MASX", SqlDbType.Int).Value = nsx.MaSx;

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    nhasxCheck = true;
                }

                return nhasxCheck;
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

        // Delete Nha San Xuat
        public bool DeleteNhaSanXuat(NhaSx nsx)
        {
            bool isCheck = false;
            try
            {
                OpenConnection();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_DELETE_NHASX";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@MASX", SqlDbType.Int).Value = nsx.MaSx;

                int result = sqlCommand.ExecuteNonQuery();

                if (result > 0)
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

        // Hien Thi Report Nha San Xuat
        public DataTable HienThiReportNhaSanXuat()
        {
            try
            {
                OpenConnection();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT *FROM NHASX", conn);

                DataTable dt = new DataTable();

                sqlDataAdapter.Fill(dt);

                return dt;
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


        // Tim Kiem Nha San Xuat
        public List<NhaSx> TimKiemNhaSx(NhaSx nsx)
        {
            try
            {
                OpenConnection();
                List<NhaSx> nsxlist = new List<NhaSx>();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_TimKiemNhaSanXuat";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@Search", SqlDbType.NVarChar).Value = nsx.Search;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    NhaSx nsxs = new NhaSx();
                    nsxs.MaSx = int.Parse(dt.Rows[i][0].ToString());
                    nsxs.TenSx = dt.Rows[i][1].ToString();
                    nsxs.QuocGia = dt.Rows[i][2].ToString();

                    nsxlist.Add(nsxs);
                }

                sqlReader.Close();
                return nsxlist;
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


        // Loc Nha San Xuat
        public List<NhaSx> LocDanhSachNhaSx(NhaSx nsx)
        {
            try
            {
                OpenConnection();
                List<NhaSx> nsxlist = new List<NhaSx>();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;

                SqlDataReader sqlReader = null;
                DataTable dt = new DataTable();

                if (nsx.Search == "Mã Sản Xuất")
                {
                    sqlCommand.CommandText = "SELECT MASX FROM dbo.NHASX";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();

                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        NhaSx nsxs = new NhaSx();
                        nsxs.MaSx = int.Parse(dt.Rows[i][0].ToString());

                        nsxlist.Add(nsxs);
                    }

                }
                else if (nsx.Search == "Tên Sản Xuất")
                {
                    sqlCommand.CommandText = "SELECT TENSX FROM dbo.NHASX";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();

                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        NhaSx nsxs = new NhaSx();
                        nsxs.TenSx = dt.Rows[i][0].ToString();

                        nsxlist.Add(nsxs);
                    }

                }
                else if (nsx.Search == "Quốc Gia")
                {
                    sqlCommand.CommandText = "SELECT DISTINCT(QUOCGIA) FROM dbo.NHASX";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();
                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        NhaSx nsxs = new NhaSx();
                        nsxs.QuocGia = dt.Rows[i][0].ToString();

                        nsxlist.Add(nsxs);
                    }
                }

                sqlReader.Close();
                return nsxlist;

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

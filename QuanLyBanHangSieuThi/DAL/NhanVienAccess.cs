using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class NhanVienAccess:DataConnect
    {
        public bool ThemNhanVien(NhanVien nv)
        {
            OpenConnection();

            bool checkInsert = false;

            // lưu ảnh xuống Database
            //FileStream stream = new FileStream(nv.imagesLocation, FileMode.Open, FileAccess.Read);
            //BinaryReader binaryReader = new BinaryReader(stream);
            //nv.Images = binaryReader.ReadBytes((int)stream.Length);

            // gọi câu truy vấn thêm Nhân Viên
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_Insert_NhanVien";
            command.Connection = conn;

            command.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = nv.Hoten;
            command.Parameters.Add("@NGAYSINH", SqlDbType.Date).Value = nv.NgaySinh;
            command.Parameters.Add("@GT", SqlDbType.NChar).Value = nv.GioTinh;
            command.Parameters.Add("@SDT", SqlDbType.Int).Value = nv.Sdt;
            command.Parameters.Add("@MAIL", SqlDbType.NChar).Value = nv.Mail;
            command.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = nv.DiaChi;
            command.Parameters.Add("@NGAYLAM", SqlDbType.DateTime).Value = nv.NgayLam;
            //command.Parameters.Add(new SqlParameter("@IMAGES", nv.Images));
            //command.Parameters.Add("@IMAGES", SqlDbType.VarChar).Value = nv.Image_01;

            int result = command.ExecuteNonQuery();

            if (result > 0)
            {
                checkInsert = true;
            }

            return checkInsert;
        }


        // Hien thi danh sach NhanVien
        public DataTable GetAllEmployee(NhanVien nv)
        {
            OpenConnection();
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT *FROM dbo.NHANVIEN WHERE MANV NOT LIKE @manv";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@manv", SqlDbType.Int).Value = nv.MaNv;

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
            catch
            {
                throw;
            }
        }

        public List<NhanVien> GetAllLISTEmployee()
        {
            OpenConnection();
            List<NhanVien> nvlist = new List<NhanVien>();
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT *FROM dbo.NHANVIEN";
                sqlCommand.Connection = conn;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    NhanVien nv1 = new NhanVien();
                    nv1.MaNv = int.Parse(dt.Rows[i][0].ToString());
                    nv1.Hoten = dt.Rows[i][1].ToString();
                    nv1.NgaySinh = DateTime.Parse(dt.Rows[i][2].ToString());
                    nv1.GioTinh = dt.Rows[i][3].ToString();
                    nv1.Sdt = int.Parse(dt.Rows[i][4].ToString());
                    nv1.Mail = dt.Rows[i][5].ToString();
                    nv1.DiaChi = dt.Rows[i][6].ToString();
                    nv1.NgayLam = DateTime.Parse(dt.Rows[i][7].ToString());
                    //NhanVien.Image_01 = dt.Rows[i][8].ToString();
                    //nv1.Image_01 = dt.Rows[i][8].ToString();
                    // load image on a picturebox
                    //MemoryStream ms = new MemoryStream((byte[])dt.Rows[i][8]);
                    //nv1.Images = image
                    nvlist.Add(nv1);
                }

                sqlReader.Close();
                return nvlist;

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


        // Update Nhan Vien
        public bool EditNhanVien(NhanVien nv)
        {
            try
            {
                OpenConnection();

                bool checkUpdate = false;

                // lưu ảnh xuống Database
                //FileStream stream = new FileStream(nv.imagesLocation, FileMode.Open, FileAccess.Read);
                //BinaryReader binaryReader = new BinaryReader(stream);
                //nv.Images = binaryReader.ReadBytes((int)stream.Length);

                // gọi câu truy vấn thêm Nhân Viên
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_UPDATE_NHANVIEN";
                command.Connection = conn;

                command.Parameters.Add("@MANV", SqlDbType.Int).Value = nv.MaNv;
                command.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = nv.Hoten;
                command.Parameters.Add("@NGAYSINH", SqlDbType.Date).Value = nv.NgaySinh;
                command.Parameters.Add("@GT", SqlDbType.NChar).Value = nv.GioTinh;
                command.Parameters.Add("@SDT", SqlDbType.Int).Value = nv.Sdt;
                command.Parameters.Add("@MAIL", SqlDbType.NChar).Value = nv.Mail;
                command.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = nv.DiaChi;
                command.Parameters.Add("@NGAYLAM", SqlDbType.DateTime).Value = nv.NgayLam;
                //command.Parameters.Add(new SqlParameter("@IMAGES", nv.Images));

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    checkUpdate = true;
                }

                return checkUpdate;
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


        // Delte Nhan Vien

        //"select * from HANGHOA where TenHang like N'%" + textBox1.Text + "%' or " +
        //        "MaHang like N'%" + textBox1.Text + "%' or MaLoai like N'%" + textBox1.Text + "%' or " +
        //        "DonVi like N'%" + textBox1.Text + "%' or TenNhaSX like N'%" + textBox1.Text + "%' or " +
        //        "GiaDeNghi like '%" + textBox1.Text + "%' or SoLuongSP like '%" + textBox1.Text + "%'"
        // Search Nhan Vien
        public DataTable SearchNhanVien(NhanVien nv)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            //sqlCommand.CommandText = "sp_SearchNhanVien";
            //sqlCommand.CommandText = "SELECT *FROM NHANVIEN WHERE MANV LIKE '%" + nv.Search + "%' OR HOTEN LIKE '%" + nv.Search + "%' OR NGAYSINH LIKE '%" + nv.Search + "%' OR GT LIKE '%" + nv.Search + "%'OR SDT LIKE '%" + nv.Search + "%' OR MAIL LIKE '%" + nv.Search + "%' OR DIACHI LIKE '%" + nv.Search + "%' OR NGAYLAM LIKE '%" + nv.Search + "%'";
            sqlCommand.CommandText = "SELECT *FROM NHANVIEN WHERE MANV = " + nv.Search + " OR HOTEN = '" + nv.Search + "' OR NGAYSINH = '" + nv.Search + "' OR GT = '" + nv.Search + "'OR SDT = " + nv.Search + " OR MAIL = '" + nv.Search + "' OR DIACHI = '" + nv.Search + "' OR NGAYLAM = '" + nv.Search + "'";

            sqlCommand.Connection = conn;

            //sqlCommand.Parameters.Add("@Search", SqlDbType.NVarChar).Value = nv.Search;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sqlDataAdapter.Fill(dt);

            return dt;
        }

        public List<NhanVien> TimKiemNhanVien(NhanVien nv)
        {
            try
            {
                OpenConnection();
                List<NhanVien> nvlist = new List<NhanVien>();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_TimKiemNhanVien";

                sqlCommand.Parameters.Add("@Search", SqlDbType.NVarChar).Value = nv.Search;
                //sqlCommand.CommandText = "SELECT *FROM NHANVIEN WHERE MANV = " + nv.Search + " OR HOTEN LIKE N'" + nv.Search + "' OR GT = N'" + nv.Search + "'OR SDT = " + nv.Search + " OR MAIL = N'" + nv.Search + "'";
                //sqlCommand.CommandText = "SELECT *FROM NHANVIEN WHERE HOTEN LIKE N'%" + nv.Search + "%' OR MANV = " + nv.Search + "";
                sqlCommand.Connection = conn;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    NhanVien nvs = new NhanVien();
                    nvs.MaNv = int.Parse(dt.Rows[i][0].ToString());
                    nvs.Hoten = dt.Rows[i][1].ToString();
                    nvs.NgaySinh = DateTime.Parse(dt.Rows[i][2].ToString());
                    nvs.GioTinh = dt.Rows[i][3].ToString();
                    nvs.Sdt = int.Parse(dt.Rows[i][4].ToString());
                    nvs.Mail = dt.Rows[i][5].ToString();
                    nvs.DiaChi = dt.Rows[i][6].ToString();
                    nvs.NgayLam = DateTime.Parse(dt.Rows[i][7].ToString());

                    nvlist.Add(nvs);
                }
                sqlReader.Close();

                return nvlist;
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

        //Delete NhanVien
        public bool DeleteNhanVien(NhanVien nv)
        {
            OpenConnection();
            bool isCheck = false;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "sp_DELETE_NHANVIEN";
            sqlCommand.Connection = conn;

            sqlCommand.Parameters.Add("@MANV", SqlDbType.Int).Value = nv.MaNv;

            int result = sqlCommand.ExecuteNonQuery();

            if (result > 0)
            {
                isCheck = true;
            }

            return isCheck;

        }

        // Hien Thi Danh Sach Bao Cao
        public DataTable HienThiDanhSachReport()
        {
            try
            {
                OpenConnection();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT *FROM NHANVIEN", conn);

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

        // Loc Nhan Vien
        public DataTable LocNhanVien(NhanVien nv)
        {
            try
            {
                DataTable dt = new DataTable();
                OpenConnection();
                if (nv.Search == "Mã Nhân Viên")
                {
                    SqlDataAdapter sqlData = new SqlDataAdapter("SELECT MANV FROM dbo.NHANVIEN", conn);

                    sqlData.Fill(dt);
                }
                if (nv.Search == "Họ Tên")
                {
                    SqlDataAdapter sqlData = new SqlDataAdapter("SELECT HOTEN FROM dbo.NHANVIEN", conn);
                    sqlData.Fill(dt);
                }
                if (nv.Search == "Ngày Sinh")
                {
                    SqlDataAdapter sqlData = new SqlDataAdapter("SELECT NGAYSINH FROM dbo.NHANVIEN", conn);
                    sqlData.Fill(dt);
                }
                if (nv.Search == "Số Điện Thoại")
                {
                    SqlDataAdapter sqlData = new SqlDataAdapter("SELECT SDT FROM dbo.NHANVIEN", conn);
                    sqlData.Fill(dt);
                }
                if (nv.Search == "Mail")
                {
                    SqlDataAdapter sqlData = new SqlDataAdapter("SELECT MAIL FROM dbo.NHANVIEN", conn);
                    sqlData.Fill(dt);
                }

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

        // Loc Nhan Vien
        public List<NhanVien> LocDSNhanVien(NhanVien nv)
        {
            try
            {
                OpenConnection();
                List<NhanVien> nvlist = new List<NhanVien>();
                SqlCommand sqlCommand = new SqlCommand();
                SqlDataReader sqlReader = null;
                DataTable dt = new DataTable();

                if (nv.Search == "Mã Nhân Viên")
                {
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = "SELECT MANV FROM dbo.NHANVIEN";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();

                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        NhanVien nvs = new NhanVien();
                        nvs.MaNv = int.Parse(dt.Rows[i][0].ToString());

                        nvlist.Add(nvs);
                    }

                }
                else if (nv.Search == "Họ Tên")
                {
                    sqlCommand.CommandText = "SELECT HOTEN FROM dbo.NHANVIEN";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();

                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        NhanVien nvs = new NhanVien();
                        nvs.Hoten = dt.Rows[i][0].ToString();

                        nvlist.Add(nvs);
                    }

                }
                else if (nv.Search == "Ngày Sinh")
                {
                    sqlCommand.CommandText = "SELECT NGAYSINH FROM dbo.NHANVIEN";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();
                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        NhanVien nvs = new NhanVien();
                        nvs.NgaySinh = DateTime.Parse(dt.Rows[i][0].ToString());

                        nvlist.Add(nvs);
                    }
                }
                else if (nv.Search == "Điện Thoại")
                {
                    sqlCommand.CommandText = "SELECT SDT FROM dbo.NHANVIEN";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();
                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        NhanVien nvs = new NhanVien();
                        nvs.Sdt = int.Parse(dt.Rows[i][0].ToString());

                        nvlist.Add(nvs);
                    }
                }
                else if (nv.Search == "Mail")
                {
                    sqlCommand.CommandText = "SELECT MAIL FROM dbo.NHANVIEN";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();
                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        NhanVien nvs = new NhanVien();
                        nvs.Mail = dt.Rows[i][0].ToString();

                        nvlist.Add(nvs);
                    }
                }
                else if (nv.Search == "Giới Tính")
                {
                    sqlCommand.CommandText = "SELECT DISTINCT(GT) FROM dbo.NHANVIEN";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();
                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        NhanVien nvs = new NhanVien();
                        nvs.GioTinh = dt.Rows[i][0].ToString();

                        nvlist.Add(nvs);
                    }

                }

                sqlReader.Close();
                return nvlist;

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

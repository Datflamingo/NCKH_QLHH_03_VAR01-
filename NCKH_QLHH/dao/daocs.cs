using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using NCKH_QLHH.dataprovider;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCKH_QLHH.dao
{
    public class daocs
    {
        public dataprovider.DBConnection conn;
        
        public daocs()
        {
            conn = new dataprovider.DBConnection();
        }
        public void ThemHangHoa(String id, String Product, String Quanlity, String Ex, int e = 0, int i = 0)
        {

            const string sql = "insert into QLHH_main(id, Ten_san_pham, So_thung, So_luong_trong_1_thung, So_donvi_da_xuat, So_thung_da_xuat) values(@id, @Ten_san_pham, @So_thung, @So_luong_trong_1_thung, @So_donvi_da_xuat, @So_thung_da_xuat)";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.BigInt);
            sqlParameters[0].Value = Convert.ToString(id);
            sqlParameters[1] = new SqlParameter("@Ten_san_pham", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(Product);
            sqlParameters[2] = new SqlParameter("@So_thung", SqlDbType.Int);
            sqlParameters[2].Value = Convert.ToString(Quanlity);
            sqlParameters[3] = new SqlParameter("@So_luong_trong_1_thung", SqlDbType.Int);
            sqlParameters[3].Value = Convert.ToString(Ex);
            sqlParameters[4] = new SqlParameter("@So_donvi_da_xuat", SqlDbType.Int);
            sqlParameters[4].Value = Convert.ToString(e);
            sqlParameters[5] = new SqlParameter("@So_thung_da_xuat", SqlDbType.Int);
            sqlParameters[5].Value = Convert.ToString(i);
            conn.executeInsertQuery(sql, sqlParameters);
        }
        public void SuaHangHoa(String id, String Product, String Quanlity, String Ex)
        {
            const string sql = "update QLHH_main set Ten_san_pham = @ten_san_pham, So_thung= @So_thung, So_luong_trong_1_thung = @So_luong_trong_1_thung where id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@Ten_san_pham", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(Product);
            sqlParameters[1] = new SqlParameter("@So_thung", SqlDbType.Int);
            sqlParameters[1].Value = Convert.ToString(Quanlity);
            sqlParameters[2] = new SqlParameter("@So_luong_trong_1_thung", SqlDbType.Int);
            sqlParameters[2].Value = Convert.ToString(Ex);
            sqlParameters[3] = new SqlParameter("@id", SqlDbType.BigInt);
            sqlParameters[3].Value = Convert.ToString(id);
            conn.executeInsertQuery(sql, sqlParameters);
        }

        public void XuatNhapThung(String id, String Boxes)
        {
            const string sql = "update QLHH_main set So_thung = @So_thung where id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@So_thung", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToString(Boxes);
            sqlParameters[1] = new SqlParameter("@id", SqlDbType.BigInt);
            sqlParameters[1].Value = Convert.ToString(id);
            conn.executeInsertQuery(sql, sqlParameters);
        }

        public void XuatThung(String id, String Boxes)
        {
            const string sql = "update QLHH_main set So_thung_da_xuat = @So_thung_da_xuat where id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@So_thung_da_xuat", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToString(Boxes);
            sqlParameters[1] = new SqlParameter("@id", SqlDbType.BigInt);
            sqlParameters[1].Value = Convert.ToString(id);
            conn.executeInsertQuery(sql, sqlParameters);
        }

        public void XuatNhapLon(String id, String Quanlity)
        {
            const string sql = "update QLHH_main set So_donvi_da_xuat = @So_donvi_da_xuat where id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@So_donvi_da_xuat", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToString(Quanlity);
            sqlParameters[1] = new SqlParameter("@id", SqlDbType.BigInt);
            sqlParameters[1].Value = Convert.ToString(id);
            conn.executeInsertQuery(sql, sqlParameters);
        }

        public void XoaHangHoa(String id)
        {
            const string sql = "delete from QLHH_main where id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.BigInt);
            sqlParameters[0].Value = Convert.ToString(id);
            conn.executeInsertQuery(sql, sqlParameters);
        }

        public DataTable CheckID(String id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.cnnStr))
            {
                string sql = "select * from QLHH_main where id = ";
                sql = sql + id;

                using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            dt.Load(dataReader);
                            dataReader.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return dt;
        }

        public DataTable CheckNV(String SDT)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.cnnStr))
            {
                string sql = "select * from Nhan_vien where TaiKhoan = ";
                sql = sql + SDT;

                using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            dt.Load(dataReader);
                            dataReader.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return dt;
        }

    }
    public class HangHoaBUS
    {
        private daocs hhDAO;
        public HangHoaBUS()
        {
            hhDAO = new daocs();
        }
        public void ThemHangHoa(String id, String Product, String Boxes, String Ex, int e, int i)
        {
            hhDAO.ThemHangHoa(id, Product, Boxes, Ex, e, i);
        }

        public void SuaHangHoa(String id, String Product, String Boxes, String Ex)
        {
            hhDAO.SuaHangHoa(id, Product, Boxes, Ex);
        }
        
        
        public void XoaHangHoa(String id)
        {
            hhDAO.XoaHangHoa(id);
        }

        public void XuatNhapThung(String id, String Boxes)
        {
            hhDAO.XuatNhapThung(id, Boxes);
        }

        public void XuatNhapLon(String id, String Quanlity)
        {
            hhDAO.XuatNhapLon(id, Quanlity);
        }

        public void XuatThung(String id, String Boxes)
        {
            hhDAO.XuatThung(id, Boxes);
        }


        public DataTable CheckIDHH(String id)
        {
            return hhDAO.CheckID(id);
        }

        public DataTable CheckTKNV(String SDT)
        {
            return hhDAO.CheckNV(SDT);
        }
    }
}

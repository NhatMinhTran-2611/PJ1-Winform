using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Form1.cs;


namespace Form1.cs
{
    internal class HocSinhDao
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public void Them(HocSinh hs)
        {
            try
            {
                // Ket noi
                conn.Open();
                string sqlStr = string.Format("INSERT INTO HocSinh(Ten , Diachi,Cmnd,NgaySinh) VALUES ('{0}', '{1}','{2}','{3}')", hs.Name, hs.Addressed, hs.Id, hs.Birthday);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);

                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("them thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("them that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public void Xoa(HocSinh hs) 
        {
            try
            {
                // Ket noi
                conn.Open();
                string SQL = string.Format("DELETE FROM HocSinh WHERE Cmnd = '{0}'", hs.Id);
                SqlCommand cmd = new SqlCommand(SQL, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("xoa thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("xoa that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public void Sua(HocSinh hs)
        {
            try
            {
                // Ket noi
                conn.Open();
                string SQL = string.Format("UPDATE HocSinh SET Ten = '{0}', Diachi ='{1}' WHERE Cmnd = '{2}'", hs.Name, hs.Addressed, hs.Id);

                SqlCommand cmd = new SqlCommand(SQL, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("thay doi thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("thay doi that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable load()
        {
            DataTable dtSinhVien = new DataTable();
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM HocSinh");
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(dtSinhVien);
                return dtSinhVien;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

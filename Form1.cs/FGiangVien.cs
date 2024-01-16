using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Form1.cs;
namespace Form1.cs
{
    public partial class FGiangVien : Form
    {
        SqlConnection conn1 = new SqlConnection(Properties.Settings.Default.connStr);
        public FGiangVien()
        {
            InitializeComponent();
        }
        public void reloadF2()
        {
            try
            {
                conn1.Open();
                string sqlStr = string.Format("SELECT *FROM GiangVien");

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn1);
                DataTable dtSinhVien = new DataTable();
                adapter.Fill(dtSinhVien);
                dataGridView1.DataSource = dtSinhVien; /// gvHsinh = name cua data gridview
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn1.Close();
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            reloadF2();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            GiangVien gv = new GiangVien(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            GiangVienDao gvDao = new GiangVienDao();
            gvDao.Them(gv);
            reloadF2();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            GiangVien gv = new GiangVien(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            GiangVienDao gvDao = new GiangVienDao();
            gvDao.Xoa(gv);
            reloadF2();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            GiangVien gv = new GiangVien(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            GiangVienDao gvDao = new GiangVienDao();
            gvDao.Sua(gv);
            reloadF2();
        }
        private void btStudent_Click(object sender, EventArgs e)
        {
            FHocSinh hocSinhForm = new FHocSinh();
            hocSinhForm.Show();
            this.Hide();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Form1.cs;
namespace Form1.cs
{
    public partial class FHocSinh : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public FHocSinh()
        {
            InitializeComponent();
        }
        public void ReloadF1()
        {
            HocSinh hs = new HocSinh(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            HocSinhDao hsDao = new HocSinhDao();
            hsDao.load(hs);
            ReloadF1();
        }
        private void FHocSinh_Load(object sender, EventArgs e)
        {
            ReloadF1();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            HocSinhDao hsDao = new HocSinhDao();
            hsDao.Them(hs);
            ReloadF1();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            HocSinhDao hsDao = new HocSinhDao();
            hsDao.Xoa(hs);
            ReloadF1();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            HocSinhDao hsDao = new HocSinhDao();
            hsDao.Sua(hs);
            ReloadF1();
        }
        private void FHocSinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Prevent the form from closing automatically
            e.Cancel = true;
        }


        private void btTeacher_Click(object sender, EventArgs e)
        {
            FGiangVien giangVienForm = new FGiangVien();
            giangVienForm.Show();
            this.Hide();
        }

        private void btTatChuongTrinh_Click(object sender, EventArgs e)
        {
            Application.Exit() ;
        }

    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Form1.cs
{
    internal class GiangVien
    {
        string name;
        string addressed;
        string id;
        string birthday;
        public GiangVien(string name, string addressed, string id, string birthday)
        {
            this.name = name;
            this.addressed = addressed;
            this.id = id;
            this.birthday = birthday;
        }
        public string Name
        {
            get { return name; }
        }

        public string Addressed
        {
            get { return addressed; }
        }

        public string Id
        {
            get { return id; }
        }

        public string Birthday
        {
            get { return birthday; }
        }
    }
}

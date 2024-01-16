using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Form1.cs
{
    internal class HocSinh
    {
        string name;
        string addressed;
        string id;
        string birthday;
        public HocSinh(string name, string addressed, string id,string birthday)
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

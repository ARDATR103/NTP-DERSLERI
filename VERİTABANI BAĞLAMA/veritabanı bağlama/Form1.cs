using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace veritabanı_bağlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbDataAdapter da;
        DataTable dt;
        private void btnogrtablosu_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=SEYFİ1.accdb");
            da = new OleDbDataAdapter("select * from ogrenci",con);
            dt = new DataTable();
            con.Open();
            da.Fill(dt);
            datagridView1.DataSource=dt;
            con.Close();
        }

        private void btnbolumtablosu_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=SEYFİ1.accdb");
            da = new OleDbDataAdapter("select * from bölüm", con);
            dt = new DataTable();
            con.Open();
            da.Fill(dt);
            datagridView1.DataSource = dt;
            con.Close();
        }
    }
}

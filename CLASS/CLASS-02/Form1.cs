using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASS_ÖRNEK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<KAYITLAR> Kayıt = new List<KAYITLAR>();
        private void button1_Click(object sender, EventArgs e)
        {
            KAYITLAR ögrenci = new KAYITLAR();
            ögrenci.Ad = txtAd.Text;
            ögrenci.Soyad = txtSoyad.Text;
            ögrenci.Numara = txtNumara.Text;

            Kayıt.Add(ögrenci);
            txtAd.Text = null;
            txtNumara.Text = null;
            txtSoyad.Text = null;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (KAYITLAR kayit in Kayıt)
            {
                listBox1.Items.Add(kayit.Numara+" "+kayit.Ad+" "+kayit.Soyad);
            }
            listBox1.Items.Add("----------------------------------------");
            listBox1.Items.Add("Toplam Kayıt Sayısı : "+Kayıt.Count);
        }
    }
}

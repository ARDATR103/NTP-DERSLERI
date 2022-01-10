using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIZILER_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac;
        string[] isimler = new string[5];

        private void button1_Click(object sender, EventArgs e)
        {
            isimler[sayac] = txtAdVeSoyad.Text;
            txtAdVeSoyad.Clear();
            sayac++;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < sayac; i++)
            {
                listBox1.Items.Add(isimler[i]);
            }

        }
    }
}

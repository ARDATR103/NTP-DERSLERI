using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace DIZILER_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList Şehirler = new ArrayList();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Şehirler.Add(txtŞehirler.Text);
            iller();
        }

        private void iller()
        {
            lstŞehirler.Items.Clear();
            txtŞehirler.Text = null;
            foreach (object şehir in Şehirler)
            {
                lstŞehirler.Items.Add(şehir);
            }
        }

        private void btnArayaEkle_Click(object sender, EventArgs e)
        {
            int indexno = lstŞehirler.SelectedIndex;
            Şehirler.Insert(indexno, txtŞehirler.Text);
            iller();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int indexno = lstŞehirler.SelectedIndex;
            Şehirler[indexno] = txtŞehirler.Text;
            iller();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int indexno = lstŞehirler.SelectedIndex;
            Şehirler.RemoveAt(indexno);
            iller();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (Şehirler.Contains(txtŞehirler.Text))
            {
                lblDurum.Text = "ARADIĞINIZI TER AKITIP BULDUK EFENDİM";
                lstŞehirler.SelectedIndex = Şehirler.IndexOf(txtŞehirler.Text);
            }

            else
            {
                lblDurum.Text = "BULAMADIK EFENDİM";
            }
        }
    }       
}

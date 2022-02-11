using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _KitapDukkani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Yazar> yazarlar = new List<Yazar>();
        List<Kitaplar> kitaplar = new List<Kitaplar>();
        List<Musteri> musteriler = new List<Musteri>();
        private void btnYazarEkle_Click(object sender, EventArgs e)
        {
            Yazar yazar = new Yazar();
            yazar.Adi = txtYazarAdi.Text;
            yazar.DogumTarihi = dtYazarDogumTarihi.Value;
            if (chkNobel.Checked==true)
            {
                yazar.NobelAldiMi = true;
            }

            else
            {
                yazar.NobelAldiMi = false;
            }
            yazarlar.Add(yazar);
            cmbYazar.Items.Add(yazar);
            cmbYazar.DisplayMember = "Adi";
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            Kitaplar kitap = new Kitaplar();
            kitap.KitapAdi = txtKitapAdi.Text;
            kitap.KitapTuru = (string)cmbKitapTuru.SelectedItem;
            kitap.SayfaSayisi = int.Parse(txtSayfaSayisi.Text);
            kitap.Fiyat = decimal.Parse(txtFiyat.Text);
            kitap.Yazar = (Yazar)cmbYazar.SelectedItem;
            kitaplar.Add(kitap);
            cmbKitap.Items.Add(kitap);
            cmbKitap.DisplayMember = "KitapAdi";
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            Musteri müsteri = new Musteri();
            müsteri.MusteriAdi = txtMusteriAdi.Text;
            müsteri.Meslegi = txtMeslegi.Text;
            müsteri.Yas = txtMusteriYas.Text;
            müsteri.Kitap = (Kitaplar)cmbKitap.SelectedItem;
            musteriler.Add(müsteri);            
        }

        private void btnMusterileriGetir_Click(object sender, EventArgs e)
        {
            lsbMusteriler.Items.Clear();
            foreach (Musteri Kayıtlar in musteriler)
            {
                lsbMusteriler.Items.Add(Kayıtlar.MusteriAdi+" "+Kayıtlar.Meslegi+" "+Kayıtlar.Yas);  
            }
        }        
    }
}

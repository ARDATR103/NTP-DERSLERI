using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1. Örnek: Adınızı 100 kez ekrana yazdıran programın algoritmasını yazınız.

            listBox1.Items.Clear();

            for (int i = 1; i <= 100; i++)
            {
                listBox1.Items.Add(i+ " Seyfi ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //2. Örnek: Ekrana 100 adet yıldız yazdıran programın algoritmasını yazınız.

            listBox1.Items.Clear();

            for (int i = 1; i <= 100; i++)
            {
                listBox1.Items.Add(i + " Yıldız ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //3. Örnek: Klavyeden girilen ismi ekrana 10 kez yazdıran programın algoritmasını yazınız.
            listBox1.Items.Clear();
            string isim = txtİsim.Text;

            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(i+ " "+  isim);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //4. Örnek: Klavyeden girilen ismi, girilen sayı kadar ekrana yazdıran programın algoritmasını yazınız.

            listBox1.Items.Clear();
            string isim = txtİsim.Text;
            int miktar=int.Parse(txtMiktar.Text);

            for (int i = 1; i <= miktar; i++)
            {
                listBox1.Items.Add(i + " " + isim);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //5. Örnek: 1’den 100’e kadar olan sayıları ekrana yazdıran programın algoritmasını yazınız.

            listBox1.Items.Clear();

            for (int i = 1; i <= 100; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //6. Örnek: 0’dan 100’e kadar olan çift sayıları ekrana yazdıran programın algoritmasını yazınız.

            listBox1.Items.Clear();

            for (int i = 0; i <= 100; i+=2)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //7. Örnek: 1’den 100’e kadar olan tam sayıların toplamını bulup ekranda gösteren programın algoritmasını yazınız.

            listBox1.Items.Clear();
            int toplam=0;

            for (int i = 1; i <= 100; i++)
            {
                toplam += i;
                
            }
            
            listBox1.Items.Add(toplam);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //8. Örnek: 1’den 50’ye kadar olan çift sayıların toplamını bulup ekranda gösteren programın algoritmasını yazınız.

            listBox1.Items.Clear();
            int toplam = 0;

            for (int i = 1; i <= 50; i+=2)
            {
                toplam += i;
            }

            listBox1.Items.Add(toplam);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //9. Örnek: 1’den 100’ye kadar olan tek sayıların toplamını bulup ekranda gösteren programın algoritmasını yazınız.

            listBox1.Items.Clear();
            int toplam = 0;

            for (int i = 1; i <= 100; i+=2)
            {
                toplam += i;
            }

            listBox1.Items.Add(toplam);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //10. Örnek: Klavyeden girilen 10 adet sayının toplamını bulup ekranda gösteren programın algoritmasını yazınız.

            listBox1.Items.Clear();
            Random rnd=new Random();
            int toplam = 0,rastgele=rnd.Next(1, 100);
            for (int i = 0; i <= 10; i++)
            {
                toplam += rastgele;
            }

            listBox1.Items.Add(toplam);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //11. Örnek: Klavyeden girilen 100 adet sayının toplamını ve ortalamasını bulup ekranda gösteren programın algoritmasını yazınız.
            
            listBox1.Items.Clear();
            Random rnd = new Random();
            int toplam = 0, rastgele = rnd.Next(1, 100);
            for (int i = 0; i <= 100; i++)
            {
                toplam += rastgele;
            }

            int ortalama = toplam / 100;

            listBox1.Items.Add("Toplamı = "+toplam);
            listBox1.Items.Add("Ortalaması = " + ortalama);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //12. Örnek: Klavyeden girilen 10 adet sayıdan 50’den büyük olanları ekrana yazdıran programın algoritmasını yazınız.

            listBox1.Items.Clear();
            Random rnd = new Random();
            
            for (int i = 0; i <= 10; i++)
            {
                int rastgele=rnd.Next(1, 100);
                
                if (rastgele >= 50)
                {
                    listBox1.Items.Add(rastgele);
                }  
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //13. Örnek: Klavyeden girilen 10 adet sayıdan 50’den büyük kaç adet sayı olduğunu ekranda gösteren programın algoritmasını yazınız.

            listBox1.Items.Clear();
            int sayac = 0;
            Random rnd = new Random();

            for (int i = 0; i <= 10; i++)
            {
                int rastgele = rnd.Next(1, 100);

                if (rastgele >= 50)
                {
                    sayac++;
                    listBox1.Items.Add(sayac);
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //14. Örnek: Klavyeden 40 öğrencinin notları girilecektir. Notların toplamını ve ortalamasını ekranda gösteren programın algoritmasını yazınız. (Girilen notların 0-100 aralığında olup olmadığı kontrol edilmelidir.)

            listBox1.Items.Clear();
            Random rnd = new Random();
            int toplam = 0, rastgele = rnd.Next(0, 101);
            for (int i = 0; i <= 40; i++)
            {
                toplam += rastgele;
            }

            int ortalama = toplam / 100;

            listBox1.Items.Add("Toplamı = " + toplam);
            listBox1.Items.Add("Ortalaması = " + ortalama);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //15. Örnek: 1’den başlayarak klavyeden girilen değere kadar olan sayıları ekranda listeleyen programın algoritmasını yazınız.

            listBox1.Items.Clear();
            int miktar = int.Parse(txtMiktar.Text);

            for (int i = 1; i <= miktar; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //16. Örnek: 1’den başlayarak klavyeden girilen değere kadar olan sayıların toplamını ekranda gösteren programın algoritmasını yazınız.

            listBox1.Items.Clear();
            int miktar = int.Parse(txtMiktar.Text),toplam=0;

            for (int i = 1; i <= miktar; i++)
            {
                toplam += i;
                
            }
            
            listBox1.Items.Add(toplam);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //17. Örnek: Klavyeden girilen 2 sayı arasındaki sayıları ekranda gösteren programın algoritmasını yazınız.

            listBox1.Items.Clear();
            int sayı1, sayı2;
            sayı1 = int.Parse(txtMiktar.Text);
            sayı2 = int.Parse(txtMiktar2.Text);
            for (int i = sayı1; i <= sayı2; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //18. Örnek: İki tam sayının çarpım işlemini sadece toplama işlemi kullanarak gerçekleştiren programın algoritmasını yazınız.

            listBox1.Items.Clear();
            int sayı1, sayı2,çarpım=0;
            sayı1 = int.Parse(txtMiktar.Text);
            sayı2 = int.Parse(txtMiktar2.Text);

            for (int i = 1; i <= sayı2; i++)
            {
                çarpım += sayı1;
            }

            listBox1.Items.Add(çarpım);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //19. Örnek: 20 kişilik sınıfın yaşları girilecektir. Yaşı 18 ile 25 arasında olan çocukların sayısını bulup ekranda gösteren programın algoritmasını yazınız. (18 ve 25 dahil)

            listBox1.Items.Clear();
            Random rnd=new Random();
            int rast, sayac = 0;

            for (int i = 0; i < 20; i++)
            {
                rast = rnd.Next(1, 100);
                
                if (rast>=18 && rast<=25)
	            {
                    sayac++;
	            }
            }

            listBox1.Items.Add(sayac);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //20. Örnek: 5 sayısının faktöriyelini hesaplayıp sonucunu ekranda gösteren programın algoritmasını yazınız.

            listBox1.Items.Clear();
            int sayac=1, faktoriyel=1;

            for (int i = 1; i <= 5; i++)
            {
                faktoriyel = faktoriyel * sayac;
                sayac = sayac + 1;

            }

            listBox1.Items.Add(faktoriyel);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //21. Örnek: Klavyeden girilen sayının faktöriyelini hesaplayan programın algoritmasını yazınız.

            listBox1.Items.Clear();
            int sayac = 1, faktoriyel = 1;
            int sayı = int.Parse(txtMiktar.Text);

            for (int i = 1; i <= sayı; i++)
            {
                faktoriyel = faktoriyel * sayac;
                sayac = sayac + 1;

            }

            listBox1.Items.Add(faktoriyel);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //22. Örnek: Klavyeden girilen 20 adet sayının karelerini listeleyen programın algoritmasını yazınız.

            listBox1.Items.Clear();
            Random rnd = new Random();
            int sayac = 0, sayı = rnd.Next(1, 100),karesi=0;

            for (int i = 0; i <= 20; i++)
            {
                karesi=sayı* sayı;
                sayac = sayac + 1;
                
            }
            
                listBox1.Items.Add(karesi);            
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //23. Örnek: 30’dan 100’e kadar olan çift sayıları ekranda gösteren programın algoritmasını yazınız.

            listBox1.Items.Clear();

            for (int i = 30; i <= 100; i+=2)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //24. Örnek: 1’den 100’ye kadar olan çift sayıların toplamını bulup ekranda gösteren programın algoritmasını yazınız.

            listBox1.Items.Clear();

            for (int i = 1; i <= 100; i+=2)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //25. Örnek: 1’den 50’e kadar olan çift sayıların kaç adet olduğunu ve ortalamalarını bulup ekranda gösteren programın algoritmasını yazınız.

            listBox1.Items.Clear();

            int sayac = 0, ortalama,toplam=0;

            for (int i = 1; i <= 50; i++)
            {
                sayac++;
                if (i % 2 == 0) 
                {
                  toplam += i;  
                }                                
            }

            ortalama = toplam / 50;
            listBox1.Items.Add("Ortalaması : " + ortalama);
            listBox1.Items.Add("Sayısı : " + sayac);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //26. Örnek: 1’den başlayarak klavyeden girilen sayıya kadar olan tek sayıların toplamını ve ortalamasını ekranda gösteren programın algoritmasını yazınız.

            listBox1.Items.Clear();

            int sayi = int.Parse(txtMiktar.Text), toplam = 0, ortalama;

            for (int i = 1; i < sayi; i++)
            {
                if (i % 2 == 1) 
                {
                    toplam += i;
                }
            }

            ortalama = toplam / sayi;
            listBox1.Items.Add("Toplam : " + toplam);
            listBox1.Items.Add("Ortalaması : "+ortalama);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //27. Örnek: Klavyeden okunan 2 sayı arasındaki sayılardan tek olanları ekranda listeleyen programın algoritmasını yazınız.

            listBox1.Items.Clear();

            int sayi1 = int.Parse(txtMiktar.Text), sayi2 = int.Parse(txtMiktar2.Text);

            for (int i = sayi1; i <= sayi2; i++)
            {
                if (i % 2 == 1)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            //28. Örnek: Klavyeden girilen 20 adet sayıdan çift ve tek sayıların toplamını ayrı ayrı bulup ekranda gösteren programın algoritmasını yazınız.

            listBox1.Items.Clear();

            Random random = new Random();
            int rast, çfttoplam=0, tektoplam=0;

            for (int i = 0; i <= 20; i++)
            {
                rast = random.Next(1,50);

                if (rast % 2 == 0)
                {
                    çfttoplam += i;
                }

                if (rast % 2 == 1)
                {
                    tektoplam += i;
                }
            }

            listBox1.Items.Add("Tek Sayıların Toplamı : " + tektoplam);
            listBox1.Items.Add("Çift Sayıların Toplamı : " + çfttoplam);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            //29. Örnek: Klavyeden girilen 10 adet sayıdan hangilerinin 3’e tam bölünüp bölünmediğini bulan programın algoritmasını yazınız.

            listBox1.Items.Clear();

            Random random = new Random();

            int rnd;

            for (int i = 0; i < 10; i++)
            {
                rnd = random.Next(1, 50);

                if (rnd % 3 == 0)
                {
                    listBox1.Items.Add(rnd);
                }
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            //30. Örnek: Klavyeden girilen 10 adet sayıdan hangilerinin 3’e ve 5’e tam bölünüp bölünmediğini bulan programın algoritmasını yazınız.

            listBox1.Items.Clear();

            Random random = new Random();

            int rnd;

            for (int i = 0; i < 10; i++)
            {
                rnd = random.Next(1, 100);

                if (rnd % 3 == 0 && rnd % 5 == 0)
                {
                    listBox1.Items.Add(rnd);                    
                }              
            }
        }
    }
}

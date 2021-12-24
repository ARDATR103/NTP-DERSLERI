using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AKTARMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int a;
            for (int i = 0; i < 100; i++)
            {
                a = random.Next(1, 300);
                lstTüm.Items.Add(a);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                int sayi = (int)lstTüm.Items[i];
                if (sayi % 3 == 0)
                {
                    lst3ebölünenler.Items.Add(sayi);
                }
                if (sayi % 5 == 0)
                {
                    lst5ebölünenler.Items.Add(sayi);
                }
                if (sayi % 7 == 0)
                {
                    lst7yebölünenler.Items.Add(sayi);
                }
                if (sayi % 3 == 0 && sayi % 5 == 0)
                {
                    lst3ve5ebölünenler.Items.Add(sayi);
                }
                if (sayi % 3 == 0 && sayi % 7 == 0)
                {
                    lst3ve7yebölünenler.Items.Add(sayi);
                }
                if (sayi % 5 == 0 && sayi % 7 == 0)
                {
                    lst5ve7yebölünenler.Items.Add(sayi);
                }
                if (sayi % 3 != 0 && sayi % 5 != 0 && sayi % 7 != 0)
                {
                    lstDiğer.Items.Add(sayi);
                }


            }
        }


    }
}
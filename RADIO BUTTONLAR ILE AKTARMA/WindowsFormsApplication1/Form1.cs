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
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            Random rstsayi = new Random();

            for (int i = 0; i < 100; i++)
            {
                int randomsayi=rstsayi.Next(-100, 101);
                listBox1.Items.Add(randomsayi);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            for (int i = 0; i < 100; i++)
            {
                int sayi = (int)listBox1.Items[i];

                if (rdrPozitif.Checked && sayi>0)
                {
                    if (rdr3.Checked && sayi % 3 == 0) 
                    {
                        listBox2.Items.Add(sayi);
                    }

                    if (rdr5.Checked && sayi % 5 == 0) 
                    {
                        listBox2.Items.Add(sayi);
                    }

                    if (rdr7.Checked && sayi % 7 == 0) 
                    {
                        listBox2.Items.Add(sayi);
                    }
                }

                if (rdrNegatif.Checked && sayi<0)
                {
                    if (rdr3.Checked && sayi % 3 == 0)
                    {
                        listBox2.Items.Add(sayi);
                    }

                    if (rdr5.Checked && sayi % 5 == 0)
                    {
                        listBox2.Items.Add(sayi);
                    }

                    if (rdr7.Checked && sayi % 7 == 0)
                    {
                        listBox2.Items.Add(sayi);
                    }
                }
            }
        }
    }
}

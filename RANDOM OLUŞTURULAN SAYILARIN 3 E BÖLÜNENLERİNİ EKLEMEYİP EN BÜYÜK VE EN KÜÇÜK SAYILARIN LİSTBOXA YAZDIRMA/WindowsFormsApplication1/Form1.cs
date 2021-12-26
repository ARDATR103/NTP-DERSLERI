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
            Random random = new Random();
            int a,max=0,min=100;

            for (int i = 0; i < 20; i++)
            {
                a = random.Next(1, 100);
                
                if (a % 3 == 0)
                {
                    i--;
                    continue;
                }

                if (a>max)
                {
                    max = a;
                }

                if (a<min)
                {
                    min = a;
                }
                
                listBox1.Items.Add(a);
            }            
            listBox1.Items.Add("En Büyük Sayı : "+max);
            listBox1.Items.Add("En Küçük Sayı : "+min);
        }
    }
}

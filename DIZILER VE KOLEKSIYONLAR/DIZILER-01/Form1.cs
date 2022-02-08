using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIZILER_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] isimsoyisim = new string[5];
        int[] dersnotu = new int[5];
        int index = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (index<isimsoyisim.Length)
            {
                isimsoyisim[index] = txtAdSoyad.Text;
                dersnotu[index] = int.Parse(txtDersNotu.Text);
                index++;
                txtAdSoyad.Text = null;
                txtDersNotu.Text = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < isimsoyisim.Length; i++)
            {
                if (isimsoyisim[i]!=null)
                {
                    listBox1.Items.Add(isimsoyisim[i] + "Notu : " + dersnotu[i]);
                }
            }
        }
    }
}

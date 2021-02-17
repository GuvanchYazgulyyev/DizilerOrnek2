using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diziler_2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayilar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            Array.Sort(sayilar);
            lblenbyk.Text = sayilar[sayilar.Length - 1].ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[listBox1.Items.Count];

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayilar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            Array.Sort(sayilar);
            lblenkck.Text = sayilar[0].ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayilar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            int toplam = 0;
            foreach(int sayi in sayilar)
            {
                toplam = toplam + sayi;
            }
            lbltop.Text = toplam.ToString();

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayilar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            int toplam = 0;
            foreach(int sayi in sayilar)
            {
                toplam = toplam + sayi;
            }
            lblort.Text = (toplam / sayilar.Length).ToString();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayilar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            //int toplam = 0;
            foreach(int i in sayilar)
            {
                if (i % 2 == 0)
                {
                    listBox2.Items.Add(i);
                }
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayilar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            foreach(int i in sayilar)
            {
                if (i % 2 == 1)
                {
                    listBox3.Items.Add(i);
                }
            }
        }
    }
}

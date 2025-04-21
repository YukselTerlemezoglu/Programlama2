using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev3
{
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public static int ToplamOgrenci = 2;
        public static int ToplamErkek = 1;
        public static int ToplamKadın = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Lütfen Görmek İstediğiniz Öğrencinin TC'sini Giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(textBox1.Text == "12345678902")
            {
                listView1.Items.Clear();
                listView1.Items.Add("Yüksel");
                listView1.Items.Add("Terlemezoğlu");
                listView1.Items.Add("12345678902");
                listView1.Items.Add("08.08.2004");
                listView1.Items.Add("Erkek");
                listView1.Items.Add("Bilgisayar Mühendisliği");
            }
            else if (textBox1.Text == "12345678904")
            {
                listView1.Items.Clear();
                listView1.Items.Add("Saniye");
                listView1.Items.Add("Akçay");
                listView1.Items.Add("12345678904");
                listView1.Items.Add("19.08.2004");
                listView1.Items.Add("Kadın");
                listView1.Items.Add("Diş Hekimliği");
            }
            else
            {
                MessageBox.Show("Yanlış Bir Değer Girmiş Olabilirsiniz! Lütfen Kontrol Edip Yeniden Deneyin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(ToplamOgrenci);
            progressBar1.Maximum = ToplamOgrenci;
            progressBar2.Maximum = ToplamOgrenci;
            progressBar1.Value = ToplamErkek;
            progressBar2.Value = ToplamKadın;
        }
    }
}

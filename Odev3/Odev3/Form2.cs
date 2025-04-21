using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev3
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static string OgrenciAdi;
        public static string OgrenciSoyadi;
        public static string OgrenciTC;
        public static string OgrenciDogumYili;
        public static string OgrenciCinsiyet;
        public static string OgrenciBolum;
        public static string[] OgrenciDersler;
        public static string OgretmenAdi;
        public static string OgretmenSoyadi;
        public static string OgretmenKullaniciAdi;
        public static string OgretmenSifre;
        public static string OgretmenTC;
        public static string OgretmenDogumYili;
        public static string OgretmenCinsiyet;

        //Manuel eklenen öğrenciler
        public static string OgrenciAdi1 = "Yüksel";
        public static string OgrenciSoyadi1 = "Terlemezoğlu";
        public static string OgrenciTC1 = "12345678902";
        public static string OgrenciDogumYili1 = "08.08.2004";
        public static string OgrenciCinsiyet1 = "Erkek";
        public static string OgrenciBolum1 = "Bilgisayar Mühendisliği";
        public static string OgrenciAdi2 = "Saniye";
        public static string OgrenciSoyadi2 = "Akçay";
        public static string OgrenciTC2 = "12345678904";
        public static string OgrenciDogumYili2 = "19.08.2004";
        public static string OgrenciCinsiyet2 = "Kadın";
        public static string OgrenciBolum2 = "Diş Hekimliği";

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                checkedListBox1.Items.Clear();
                checkedListBox1.Items.Add("Programlama 2");
                checkedListBox1.Items.Add("Olasılık ve İstatistik");
                checkedListBox1.Items.Add("Dosya Organizasyonu");
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                checkedListBox1.Items.Clear();
                checkedListBox1.Items.Add("Biyokimya");
                checkedListBox1.Items.Add("Histoloji");
                checkedListBox1.Items.Add("Mikro Biyoloji");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || dateTimePicker1.Text == "")
            {
                MessageBox.Show("İstenilen verilerden birisini boş bıraktınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OgrenciAdi = Convert.ToString(textBox1.Text);
                OgrenciSoyadi = Convert.ToString(textBox2.Text);
                OgrenciTC = Convert.ToString(textBox3.Text);
                OgrenciDogumYili = Convert.ToString(dateTimePicker1.Text);
                if (radioButton1.Checked)
                {
                    OgrenciCinsiyet = "Erkek";
                    Form3.ToplamErkek = Form3.ToplamErkek + 1;
                }
                else
                {
                    OgrenciCinsiyet = "Kadın";
                    Form3.ToplamKadın = Form3.ToplamKadın + 1;
                }
                OgrenciBolum = Convert.ToString(comboBox1.SelectedItem);
                /*for (int i = 0; i < Convert.ToInt32(checkedListBox1.Size) - 1; i++)
                {
                    OgrenciDersler[i] = Convert.ToString(checkedListBox1.CheckedItems);
                }*/
                Form3.ToplamOgrenci = Form3.ToplamOgrenci + 1;
                MessageBox.Show("Kayıt Başarılı!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || dateTimePicker1.Text == "")
            {
                MessageBox.Show("İstenilen verilerden birisini boş bıraktınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OgretmenAdi = Convert.ToString(textBox4.Text);
                OgretmenSoyadi = Convert.ToString(textBox5.Text);
                OgretmenKullaniciAdi = Convert.ToString(textBox6.Text);
                OgretmenSifre = Convert.ToString(textBox7.Text);
                OgretmenTC = Convert.ToString(textBox8.Text);
                OgretmenDogumYili = Convert.ToString(dateTimePicker1.Text);
                if (radioButton1.Checked) OgretmenCinsiyet = "Erkek";
                else OgretmenCinsiyet = "Kadın";
                MessageBox.Show("Kayıt Başarılı!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Zaten Öğrenci Ekle Ekranındasınız!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }

        private void toolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }
    }
}

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
    public partial class Form1: Form
    {
        public Form1()
        {
            /*
            Yüksel Terlemezoğlu
            16008123154
            Ödev_3
            Tarih:26.03.2025
            */
            InitializeComponent();
        }

        public static string AdminIsim;
        public static string AdminSoyisim;
        public static string AdminKullaniciAdi;
        public static string AdminSifre;

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("İstenilen verilerden birisini boş bıraktınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AdminIsim = Convert.ToString(textBox5.Text);
                AdminSoyisim = Convert.ToString(textBox6.Text);
                AdminKullaniciAdi = Convert.ToString(textBox7.Text);
                AdminSifre = Convert.ToString(textBox8.Text);
                MessageBox.Show("Kayıt Başarılı!","Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Kullanıcı Adını yada Şifreyi boş bıraktınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (AdminKullaniciAdi == textBox3.Text && AdminSifre == textBox4.Text)
            {
                Form form2 = new Form2();
                this.Hide();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı yada Şifre yanlış!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Kullanıcı Adını yada Şifreyi boş bıraktınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Form2.OgretmenKullaniciAdi == textBox3.Text && Form2.OgretmenSifre == textBox4.Text)
            {
                Form form3 = new Form3();
                this.Hide();
                form3.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı yada Şifre yanlış!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zaten Giriş Ekranındasınız!","Bilgilendirme!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabirentForm
{
    public partial class Form1: Form
    {
        const int labBoyut = 10;
        const int hucreBoyut = 20;
        int[,] labirent;
        Label[,] hucreler;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labirent = new int[labBoyut, labBoyut];
            hucreler = new Label[labBoyut, labBoyut];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rastgeleLabirent();
            labirentiCiz();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labirentiCozBFS();
        }
        private void rastgeleLabirent()
        {
            Random rand = new Random();
            for (int i = 0; i < labBoyut; i++)
            {
                for (int j = 0; j < labBoyut; j++)
                {
                    labirent[i, j] = rand.Next(100) < 70 ? 0 : 1;
                }
            }
            labirent[0, 0] = 0;
            labirent[labBoyut - 1, labBoyut - 1] = 0;
        }
        private void labirentiCiz()
        {
            panel1.Controls.Clear();
            panel1.Width = labBoyut * hucreBoyut;
            panel1.Height = labBoyut * hucreBoyut;

            for (int i = 0; i < labBoyut; i++)
            {
                for (int j = 0; j < labBoyut; j++)
                {
                    Label lbl = new Label
                    {
                        Width = hucreBoyut - 1,
                        Height = hucreBoyut - 1,
                        Location = new Point(j * hucreBoyut, i * hucreBoyut),
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = labirent[i, j] == 0 ? Color.White : Color.Black
                    };

                    hucreler[i, j] = lbl;
                    panel1.Controls.Add(lbl);
                }
            }
        }
        private void labirentiCozBFS()
        {
            var bas = (0, 0);
            var son = (labBoyut - 1, labBoyut - 1);
            var kuyruk = new Queue<(int, int)>();
            var ziyaret = new bool[labBoyut, labBoyut];
            var komsu = new Dictionary<(int, int), (int, int)>();

            kuyruk.Enqueue(bas);
            ziyaret[0, 0] = true;

            bool cikisVarYok = false;

            int[] dx = { -1, 1, 0, 0 };
            int[] dy = { 0, 0, -1, 1 };

            while (kuyruk.Count > 0)
            {
                var (x, y) = kuyruk.Dequeue();
                if ((x, y) == son)
                {
                    cikisVarYok = true;
                    break;
                }

                for (int d = 0; d < 4; d++)
                {
                    int nx = x + dx[d];
                    int ny = y + dy[d];
                    if (nx >= 0 && nx < labBoyut && ny >= 0 && ny < labBoyut &&
                        labirent[nx, ny] == 0 && !ziyaret[nx, ny])
                    {
                        kuyruk.Enqueue((nx, ny));
                        ziyaret[nx, ny] = true;
                        komsu[(nx, ny)] = (x, y);
                    }
                }
            }

            if (cikisVarYok)
            {
                var yol = new List<(int, int)>();
                var simdiki = son;
                while (simdiki != bas)
                {
                    yol.Add(simdiki);
                    simdiki = komsu[simdiki];
                }
                yol.Add(bas);
                yol.Reverse();

                foreach (var (x, y) in yol)
                {
                    if (!(x == 0 && y == 0) && !(x == labBoyut - 1 && y == labBoyut - 1))
                        hucreler[x, y].BackColor = Color.Green;
                }

                hucreler[0, 0].BackColor = Color.Green;
                hucreler[labBoyut - 1, labBoyut - 1].BackColor = Color.Green;

                MessageBox.Show("Çıkış bulundu! Adım sayısı: " + yol.Count,"Tebrikler!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Çıkış bulunamadı.","Üzgünüm :(",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}

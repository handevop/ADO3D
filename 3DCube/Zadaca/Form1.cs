using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kocka;

namespace Zadaca
{
    public partial class Form1 : Form
    {
        Kocka.Kocka kocka = new Kocka.Kocka(100, 100, 100);

        public Form1()
        {
            InitializeComponent();

            kocka.odmakniX = 100;
            kocka.odmakniY = 100;

            if (textBox1.Text != "" && kocka.A >= 0 &&
                textBox2.Text != "" && kocka.B >= 0 &&
                textBox3.Text != "" && kocka.C >= 0 &&
                textBox4.Text != "" && kocka.odmakniX >= 0 &&
                textBox5.Text != "" && kocka.odmakniY >= 0 &&
                textBox6.Text != "" && kocka.odmakniZ >= 0)
            {
                kocka.odmakniX = Convert.ToInt32(textBox4.Text) + 100;
                kocka.odmakniY = Convert.ToInt32(textBox5.Text) + 100;
                kocka.odmakniZ = Convert.ToInt32(textBox6.Text);

                kocka.A = Convert.ToInt32(textBox1.Text);
                kocka.B = Convert.ToInt32(textBox2.Text);
                kocka.C = Convert.ToInt32(textBox3.Text);

                kocka.rotirajX = Convert.ToInt32(0);
                kocka.rotirajY = Convert.ToInt32(0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kocka.odmakniX = 100;
            kocka.odmakniY = 100;

            if (textBox1.Text != "" && kocka.A >= 0 &&
                textBox2.Text != "" && kocka.B >= 0 &&
                textBox3.Text != "" && kocka.C >= 0 &&
                textBox4.Text != "" && kocka.odmakniX >= 0 &&
                textBox5.Text != "" && kocka.odmakniY >= 0 &&
                textBox6.Text != "" && kocka.odmakniZ >= 0)
            {
                kocka.odmakniX = Convert.ToInt32(textBox4.Text) + 100;
                kocka.odmakniY = Convert.ToInt32(textBox5.Text) + 100;
                kocka.odmakniZ = Convert.ToInt32(textBox6.Text);

                kocka.A = Convert.ToInt32(textBox1.Text);
                kocka.B = Convert.ToInt32(textBox2.Text);
                kocka.C = Convert.ToInt32(textBox3.Text);

                kocka.rotirajX = Convert.ToInt32(0);
                kocka.rotirajY = Convert.ToInt32(0);
            }
            else
            {
                MessageBox.Show("Unesite potpune podatke(barem 0)");
            }

            pictureBox1.Refresh();

            if (textBox1.Text != null && kocka.A >= 0 &&
                textBox2.Text != null && kocka.B >= 0 &&
                textBox3.Text != null && kocka.C >= 0 &&
                textBox4.Text != null && kocka.odmakniX >= 0 &&
                textBox5.Text != null && kocka.odmakniY >= 0 &&
                textBox6.Text != null && kocka.odmakniZ >= 0)
            {
                Ucitaj();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Ucitaj()
        {
            pictureBox1.Refresh();

            Graphics g = pictureBox1.CreateGraphics();
            // prva strana 

            Point A = new Point(0, 0), B = new Point(0, 0), C = new Point(0, 0), D = new Point(0, 0), E = new Point(0, 0), F = new Point(0, 0), G = new Point(0, 0), H = new Point(0,0);


            if ( kocka.rotirajX  > 0 && kocka.rotirajX <= 90)
            {
                double rotacijaX = Math.Sin(kocka.rotirajX / 180 * Math.PI);

                A.X = Convert.ToInt32(kocka.odmakniX + rotacijaX * kocka.A);
                A.Y = Convert.ToInt32(kocka.odmakniY) + Convert.ToInt32(kocka.B);

                B.X = Convert.ToInt32(kocka.odmakniX + kocka.A);
                B.Y = Convert.ToInt32(kocka.odmakniY + kocka.B);

                C.X = Convert.ToInt32(kocka.odmakniX + kocka.A);
                C.Y = Convert.ToInt32(kocka.odmakniY);

                D.X = Convert.ToInt32(kocka.odmakniX + rotacijaX * kocka.A);
                D.Y = Convert.ToInt32(kocka.odmakniY);


                F.X = Convert.ToInt32(kocka.odmakniX + rotacijaX * kocka.A * 2);
                F.Y = Convert.ToInt32(kocka.odmakniY) + Convert.ToInt32(kocka.B);

                E.X = Convert.ToInt32(kocka.odmakniX + kocka.A + rotacijaX * kocka.A);
                E.Y = Convert.ToInt32(kocka.odmakniY + kocka.B);

                G.X = Convert.ToInt32(kocka.odmakniX + kocka.A + rotacijaX * kocka.A);
                G.Y = Convert.ToInt32(kocka.odmakniY);

                H.X = Convert.ToInt32(kocka.odmakniX + rotacijaX * kocka.A * 2);
                H.Y = Convert.ToInt32(kocka.odmakniY);

            }

            else if ( kocka.rotirajX > 90 &&  kocka.rotirajX <= 180)
            {
                double rotacijaX = Math.Sin((kocka.rotirajX - 90) / 180 * Math.PI);
                double stariX = Math.Sin(kocka.rotirajX / 180 * Math.PI);
                double hf = Math.Sin((kocka.rotirajX - 45) / 180 * Math.PI);

                A.X = Convert.ToInt32(kocka.odmakniX  + kocka.B + rotacijaX * kocka.A);
                A.Y = Convert.ToInt32(kocka.odmakniY) + Convert.ToInt32(kocka.B);

                B.X = Convert.ToInt32(kocka.odmakniX + kocka.A);
                B.Y = Convert.ToInt32(kocka.odmakniY + kocka.B);

                C.X = Convert.ToInt32(kocka.odmakniX + kocka.A);
                C.Y = Convert.ToInt32(kocka.odmakniY);

                D.X = Convert.ToInt32(kocka.odmakniX + kocka.A + rotacijaX * kocka.A);
                D.Y = Convert.ToInt32(kocka.odmakniY);


                F.X = Convert.ToInt32(kocka.odmakniX + kocka.B + hf * kocka.A * Math.Sqrt(2));
                F.Y = Convert.ToInt32(kocka.odmakniY) + Convert.ToInt32(kocka.B);

                E.X = Convert.ToInt32(kocka.odmakniX + kocka.A + stariX * kocka.A);
                E.Y = Convert.ToInt32(kocka.odmakniY + kocka.B);

                G.X = Convert.ToInt32(kocka.odmakniX + kocka.A + stariX * kocka.A);
                G.Y = Convert.ToInt32(kocka.odmakniY);

                H.X = Convert.ToInt32(kocka.odmakniX + kocka.B + hf * kocka.A * Math.Sqrt(2));
                H.Y = Convert.ToInt32(kocka.odmakniY);
            }
            else if (  kocka.rotirajX  > 180 && kocka.rotirajX <= 270)
            {
                
            }
            else if ( kocka.rotirajX > 270)
            {
               
            }

            g.DrawLine(Pens.Black, A, B);
            g.DrawLine(Pens.Red, A, D);
            g.DrawLine(Pens.Blue, B, C);
            g.DrawLine(Pens.Black, C, D);

            g.DrawLine(Pens.Black, A, F);
            g.DrawLine(Pens.Black, B, E);
            g.DrawLine(Pens.Black, C, G);
            g.DrawLine(Pens.Black, D, H);

            g.DrawLine(Pens.Black, E, F);
            g.DrawLine(Pens.Purple, E, G);
            g.DrawLine(Pens.Green, F, H);
            g.DrawLine(Pens.Black, G, H);

            textBox7.Text = Convert.ToString(kocka.rotirajX);
        }

        int lokacijaPocX = 0 , lokacijaPocY = 0;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (lokacijaPocY == 0 && lokacijaPocX == 0)
            {
                lokacijaPocY = e.Y;
                lokacijaPocX = e.X;
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            lokacijaPocX = 0;
            lokacijaPocY = 0;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (lokacijaPocX != 0 && lokacijaPocY != 0)
            {

                kocka.rotirajX = e.X - lokacijaPocX;
                kocka.rotirajY = e.Y - lokacijaPocY;

                kocka.rotirajX += (int)((0 - kocka.rotirajX)/ 360) * 360;
                kocka.rotirajY += (int)((0 - kocka.rotirajY) / 360) * 360;

                //textBox7.Text = Convert.ToString(kocka.rotirajX);
                //textBox8.Text = Convert.ToString(kocka.rotirajY);
                Ucitaj();
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            lokacijaPocX = 0;
            lokacijaPocY = 0;
        }
    }
}

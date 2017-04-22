using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grafika_lab2
{
    public partial class Form1 : Form
    {
        private System.Drawing.Graphics g;
        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Blue, 2);
        public Form1()
        {
            InitializeComponent();
            g = PictureBox1.CreateGraphics();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DrawCircle_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            float SrodekX = 250;
            float SrodekY = 250;
            int LiczbaKrokow = 100;
            float R = 100;
            float Alfa = 0;
            float Dalfa = 5;//(float)0.0628;
            for(int i =0; i<LiczbaKrokow; i++)
            {
                g.DrawLine(pen1, SrodekX + R * (float)Math.Cos(Alfa + Dalfa * i), SrodekY + R * (float)Math.Sin(Alfa + Dalfa * i), SrodekX + R * (float)Math.Cos(Alfa + Dalfa * (i + 1)), SrodekY + R * (float)Math.Sin(Alfa + Dalfa * (i + 1)));
            }
        }

        private void DrawSpiral_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            float SrodekX = 250;
            float SrodekY = 250;
            int LiczbaKrokow = 100;
            float R1 = 100;
            float R2 = 50;
            float Alfa = 0;
            float Dalfa = (float)0.0628;
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < LiczbaKrokow; i++)
                {
                    g.DrawLine(pen1, SrodekX + R1 * (float)Math.Cos(Alfa + Dalfa * i), SrodekY + R2 * (float)Math.Sin(Alfa + Dalfa * i), SrodekX + R1 * (float)Math.Cos(Alfa + Dalfa * (i + 1)), SrodekY + R2 * (float)Math.Sin(Alfa + Dalfa * (i + 1)));
                    g.DrawLine(pen1, SrodekX + R2 * (float)Math.Cos(Alfa + Dalfa * i), SrodekY + R1 * (float)Math.Sin(Alfa + Dalfa * i), SrodekX + R2 * (float)Math.Cos(Alfa + Dalfa * (i + 1)), SrodekY + R1 * (float)Math.Sin(Alfa + Dalfa * (i + 1)));
                }
                R1 += 50;
                R2 += 50;
            }
            for (int i = 0; i < LiczbaKrokow; i++)
            {
                g.DrawLine(pen1, SrodekX + (R1-50) * (float)Math.Cos(Alfa + Dalfa * i), SrodekY + (R1-50) * (float)Math.Sin(Alfa + Dalfa * i), SrodekX + (R1-50) * (float)Math.Cos(Alfa + Dalfa * (i + 1)), SrodekY + (R1-50) * (float)Math.Sin(Alfa + Dalfa * (i + 1)));
            }
        }

        private void DrawSpirale_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            float SrodekX = 250;
            float SrodekY = 250;
            int N = 5;
            float R = 100;
            float Alfa = 0;
            float Dalfa = (float)0.0628;// 2*(float)Math.PI/N;
            float Nn = N * 100;
            float Rr = R / Nn;
            float Rb = 10;
            for(int i = 1; i<Nn; i++)
            {
                Rb = Rr * i;
                g.DrawLine(pen1, SrodekX + Rb * (float)Math.Cos(Alfa + i * Dalfa), SrodekY + Rb * (float)Math.Sin(Alfa + i * Dalfa), SrodekX + Rb * (float)Math.Cos(Alfa + (i + 1) * Dalfa), SrodekX + Rb * (float)Math.Sin(Alfa + (i + 1) * Dalfa));
            }

        }

        private void Draw4Sprial_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            float SrodekX = 250;
            float SrodekY = 250;
            int N = 5;
            float R = 100;
            float Alfa1 = 0;
            float Alfa2 = (float)67.5;
            float Alfa3 = 2*(float)67.5;
            float Alfa4 = 3*(float)67.5;
            float Dalfa = (float)0.0628;// 2*(float)Math.PI/N;
            float Nn = N * 100;
            float Rr = R / Nn;
            float Rb = 10;
            for (int i = 1; i < Nn; i++)
            {
                Rb = Rr * i;
                g.DrawLine(pen1, SrodekX + Rb * (float)Math.Cos(Alfa1 + i * Dalfa), SrodekY + Rb * (float)Math.Sin(Alfa1 + i * Dalfa), SrodekX + Rb * (float)Math.Cos(Alfa1 + (i + 1) * Dalfa), SrodekX + Rb * (float)Math.Sin(Alfa1 + (i + 1) * Dalfa));
                g.DrawLine(pen1, SrodekX + Rb * (float)Math.Cos(Alfa2 + i * Dalfa), SrodekY + Rb * (float)Math.Sin(Alfa2 + i * Dalfa), SrodekX + Rb * (float)Math.Cos(Alfa2 + (i + 1) * Dalfa), SrodekX + Rb * (float)Math.Sin(Alfa2 + (i + 1) * Dalfa));
                g.DrawLine(pen1, SrodekX + Rb * (float)Math.Cos(Alfa3 + i * Dalfa), SrodekY + Rb * (float)Math.Sin(Alfa3 + i * Dalfa), SrodekX + Rb * (float)Math.Cos(Alfa3 + (i + 1) * Dalfa), SrodekX + Rb * (float)Math.Sin(Alfa3 + (i + 1) * Dalfa));
                g.DrawLine(pen1, SrodekX + Rb * (float)Math.Cos(Alfa4 + i * Dalfa), SrodekY + Rb * (float)Math.Sin(Alfa4 + i * Dalfa), SrodekX + Rb * (float)Math.Cos(Alfa4 + (i + 1) * Dalfa), SrodekX + Rb * (float)Math.Sin(Alfa4 + (i + 1) * Dalfa));
            }
            for (int i = 0; i < 100; i++)
            {
                g.DrawLine(pen1, SrodekX + R * (float)Math.Cos(Alfa1 + Dalfa * i), SrodekY + R * (float)Math.Sin(Alfa1 + Dalfa * i), SrodekX + R * (float)Math.Cos(Alfa1 + Dalfa * (i + 1)), SrodekY + R * (float)Math.Sin(Alfa1 + Dalfa * (i + 1)));
            }
        }

        private void Draw16_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            float SrodekX = 250;
            float SrodekY = 250;
            float R = 200;
            float Alfa = 0;
            float Dalfa = (float)(2*Math.PI/20);
            for (int i = 0; i<20; i++)
            {
                //g.DrawLine(pen1, SrodekX + R * (float)Math.Cos(Alfa + Dalfa * i), SrodekY + R * (float)Math.Sin(Alfa + Dalfa * i), SrodekX + R * (float)Math.Cos(Alfa + Dalfa * (i + 1)), SrodekY + R * (float)Math.Sin(Alfa + Dalfa * (i + 1)));
                for (int j = 0; j < 20; j++)
                {
                    g.DrawLine(pen1, SrodekX + R * (float)Math.Cos(Alfa + Dalfa * i), SrodekY + R * (float)Math.Sin(Alfa + Dalfa * i), SrodekX + R * (float)Math.Cos(Alfa + Dalfa * j), SrodekY + R * (float)Math.Sin(Alfa + Dalfa * j));
                }
            }
        }

        private void Draw19_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            float size = 100;
            float SrodekX = 250;
            float SrodekY = 250;
            float p1x = size/2;
            float p1y = size / 2;
            float p2x = size / 2;
            float p2y = -size / 2;
            float p3x = -size / 2;
            float p3y = -size / 2;
            float p4x = -size / 2;
            float p4y = size / 2;
            for(int i =0; i<100; i++)
            {
                g.DrawLine(pen1, p1x + SrodekX, p1y + SrodekY, p2x + SrodekX, p2y + SrodekY);
                g.DrawLine(pen1, p2x + SrodekX, p2y + SrodekY, p3x + SrodekX, p3y + SrodekY);
                g.DrawLine(pen1, p3x + SrodekX, p3y + SrodekY, p4x + SrodekX, p4y + SrodekY);
                g.DrawLine(pen1, p1x + SrodekX, p1y + SrodekY, p4x + SrodekX, p4y + SrodekY);
            }
          
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework7
{
    public partial class Form1 : Form
    {
        bool IsSetting = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            IsSetting = true;
            if (graphics == null)
                graphics = this.CreateGraphics();
            Pen penColor = new Pen(Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value));
            drawCayleyTree(int.Parse(textBox1.Text), double.Parse(textBox7.Text), double.Parse(textBox8.Text), double.Parse(textBox2.Text), -Math.PI / 2,penColor);
            
        }
        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        
        void drawCayleyTree (int n,double x0,double y0,double leng,double th,Pen penColor)
        {
            if(IsSetting)
            {
                per2 = double.Parse(textBox3.Text);
                per1 = double.Parse(textBox4.Text);
                th2 = double.Parse(textBox5.Text);
                th1 = double.Parse(textBox6.Text);
                IsSetting = false;
            }
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1,penColor);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1,penColor);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2,penColor);
        }
        void drawLine(double x0, double y0, double x1, double y1,Pen penColor)
        {
                graphics.DrawLine(penColor, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            graphics.Clear(this.BackColor);
        }
        static int GetRandomSeed()
        {
            byte[] bytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            IsSetting = false;
            if (graphics == null)
                graphics = this.CreateGraphics();
            double RanLeng = new Random().NextDouble();
            if (RanLeng < 0.6) RanLeng += 0.6;
            while (per1 - per2 > 0.2)
            {
                per1 = new Random(GetRandomSeed()).NextDouble();
                per2 = new Random(GetRandomSeed()).NextDouble();
            }
            th2 = new Random(GetRandomSeed()).NextDouble();
            th1 = new Random(GetRandomSeed()).NextDouble();
            Pen penColor = new Pen(Color.FromArgb(new Random(GetRandomSeed()).Next(0, 255), new Random(GetRandomSeed()).Next(0, 255), new Random(GetRandomSeed()).Next(0, 255)));
            drawCayleyTree(new Random().Next(5,20),this.Width/2,this.Height,100*RanLeng, -Math.PI / 2,penColor);
        }
    }
}

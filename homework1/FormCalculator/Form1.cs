using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void clickBtn(string s1,string s2,int i)
        {
            if (calculator.judgeNum(s1) && calculator.judgeNum(s2))
                textBox3.Text = calculator.calculate(s1, s2, i);
            else
                textBox3.Text = "输入有误";
        }
        private void abtnClick_Click(object sender, EventArgs e)
        {
            clickBtn(textBox1.Text, textBox2.Text, 1);
        }
        private void bbtnClick_Click(object sender, EventArgs e)
        {
            clickBtn(textBox1.Text, textBox2.Text, 2);
        }
        private void cbtnClick_Click(object sender, EventArgs e)
        {
            clickBtn(textBox1.Text, textBox2.Text, 3);
        }
        private void dbtnClick_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox3.Text = "除数不能为0";
                return;
            }
            clickBtn(textBox1.Text, textBox2.Text, 1);
        }
        private void CEbtnClick_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
        }
    }
    class calculator
    {
        public static bool judgeNum(string s)
        {
            double a;
            return Double.TryParse(s, out a);
        }
        public static string calculate(string s1, string s2, int op)
        {
            double a = Convert.ToDouble(s1);
            double b = Convert.ToDouble(s2);
            string rlt = " ";
            switch (op)
            {
                case 1:
                    rlt = Convert.ToString(a + b);
                    break;
                case 2:
                    rlt = Convert.ToString(a - b);
                    break;
                case 3:
                    rlt = Convert.ToString(a * b);
                    break;
                case 4:
                    rlt = Convert.ToString(a / b);
                    break;
                default:
                    break;
            }
            return rlt;
        }
    }
}

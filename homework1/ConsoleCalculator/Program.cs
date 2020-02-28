using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("两位数字计算器");
                Console.WriteLine("---------------");
                Console.WriteLine("请输入第一个数字：");
                string s1 = Console.ReadLine();
                double a;
                if (Double.TryParse(s1, out a))
                    a = Double.Parse(s1);
                else
                {
                    Console.WriteLine("输入有误，按任意键重新输入");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                Console.WriteLine("请输入第二个数字：");
                string s2 = Console.ReadLine();
                double b;
                if (Double.TryParse(s2, out b))
                    b = Double.Parse(s2);
                else
                {
                    Console.WriteLine("输入有误，按任意键重新输入");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                Console.WriteLine("请输入运算符：");
                string s3 = Console.ReadLine();
                if (b == 0 && s3 == "/")
                {
                    Console.WriteLine("除数不能为0，按任意键重新输入");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                double rlt = 0;
                bool right = true;
                switch (s3)
                {
                    case "+":
                        rlt = a + b;
                        break;
                    case "-":
                        rlt = a - b;
                        break;
                    case "*":
                        rlt = a * b;
                        break;
                    case "/":
                        rlt = a / b;
                        break;
                    case "^":
                        rlt = System.Math.Pow(a, b);
                        break;
                    default:
                        Console.WriteLine("运算符输入有误，按任意键重新输入");
                        right = false;
                        break;
                }
                if (right)
                {
                    Console.WriteLine($"{a}{s3}{b}={rlt}\n按任意键继续");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}

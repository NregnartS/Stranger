using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homewore2
{
    class Prime
    {
        public static bool judgeInt(string s)   //判断字符串能否转化成整数
        {
            int a;
            if (int.TryParse(s, out a))
                return true;
            else
            {
                Console.WriteLine("输入有误，请重新输入正确整数");
                Console.ReadKey();
                Console.Clear();
                return false;
            }
        }
        public static bool judgePrime(int n)    //判断某个数是否为素数
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        public static void primeFactor(int n, int i)    //递归输出给定数字的素数因子
        {
            if(n%i==0&&judgePrime(i))
            {
                Console.Write(i + " ");
            }
            i++;
            if (i <= n)
                primeFactor(n, i);
            else
            {
                Console.Write("\n");
                Console.ReadKey();
                Console.Clear();
                return;
            }
        }
        static void Main(string[] args)
        {
            while (true)
            { 
                Console.WriteLine("-------计算任意整数的素数因子-------");
                Console.WriteLine("-------------请输入整数-------------");
                string s = Console.ReadLine();
                int a;
                if (judgeInt(s))
                    a = int.Parse(s);
                else
                    continue;
                Console.Write(a + "的素数因子为:");
                primeFactor(a,2);
            }
        }
    }
}

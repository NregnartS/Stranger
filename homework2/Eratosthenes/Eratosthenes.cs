using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eratosthenes
{
    class Eratosthenes
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
        public static void eratosthenes(int num)    //埃氏筛法求某个数以内的所有素数
        {
            int[] primeArray = new int[num + 1];
            for (int i = 0; i < primeArray.Length; i++) primeArray[i] = 1;
            for (int i = 2; i <= Math.Sqrt(num); i++)
                for (int j = 2; i * j <= num; j++)
                    primeArray[i * j] = 0;
            for (int i = 2; i <= num; i++)
                if (primeArray[i] == 1)
                    Console.Write($"{i} ");
            Console.Write("\n按任意键继续");
            Console.ReadKey();
            Console.Clear();
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("-------用埃氏筛法求给定整数以内的素数-------");
                Console.WriteLine("-----------------请输入整数-----------------");
                string s = Console.ReadLine();
                int num;
                if (judgeInt(s))
                    num = int.Parse(s);
                else
                    continue;
                Console.WriteLine(num + "以内的素数为:");
                eratosthenes(num);
            }
        }
    }
}

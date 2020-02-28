using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Array
    {
        public static void wrong(int i, out int[] a)
        {
            switch (i)
            {
                case 0:break;
                case 1: Console.WriteLine("输入不能为空，请重新输入");
                    break;
                case 2: Console.WriteLine("输入格式有误，第一个或最后一个字符必须为数字（见示例），请重新输入");
                    break;
                case 3: Console.WriteLine("输入有误，只能输入数字和空格（见示例），请重新输入");
                    break;
                case 4: Console.WriteLine("输入有误，每两个数字间只能有一个空格（见示例），请重新输入");
                    break;
                default: break;
            }
            Console.WriteLine("按任意键继续");
            Console.ReadKey();
            Console.Clear();
            a = null;
        }
        public static void readArray(string s, out int[] a) //判断输入格式正误并将输入写入数组
        {
            int index = 0;
            if (s == "")
            {
                wrong(1, out a);
                return;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if ((i == 0 || i == s.Length - 1) && !(s[i] >= '0' && s[i] <= '9'))
                {
                    wrong(2, out a);
                    return;
                }
                else if (s[i] != ' ' && !(s[i] >= '0' && s[i] <= '9'))
                {
                    wrong(3, out a);
                    return;
                }
                else if (s[i] == ' ' && s[i + 1] == ' ')
                {
                    wrong(4, out a);
                    return;
                }                
                if (s[i] == ' ')
                    index++;
            }
            a = new int[index + 1];
            int num = 0;
            s += ' ';
            for (int j = 0, k = 0; j < s.Length; j++)//1 2 3 
            {
                while (s[j] != ' ' && j < s.Length)
                {
                    num = num * 10 + s[j] - 48;
                    j++;
                }
                a[k] = num;
                k++;
                num = 0;
            }
        }
        public static void calArray(int[] a)
        {
            int max, min;
            double average, sum = 0;
            max = min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
                if (a[i] < min) min = a[i];
                if (a[i] > max) max = a[i];
            }
            average = sum / a.Length;
            Console.WriteLine($"该数组的最大值为：{max}、最小值为{min}、平均值为{average}、元素和为{sum}");
            wrong(0, out a);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("-------计算整数数组的最大值、最小值、平均值、元素和-------");
                Console.WriteLine("----------------------请输入整数数组----------------------");
                Console.WriteLine("----------------数字间以空格隔开， 如1 1 1----------------");
                string s = Console.ReadLine();
                int[] theArray;
                readArray(s, out theArray);
                if (theArray == null)
                    continue;
                calArray(theArray);
                s = null;
            }
        }
    }
}
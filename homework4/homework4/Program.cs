using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }
        public Node<T> Head
        {
            get => head;
        }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T> action)
        {
            for(Node<T> Item=head;Item!=null;Item=Item.Next)
            {
                action(Item.Data);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            GenericList<int> MyList = new GenericList<int>();
            Console.WriteLine("请依次输入10个值作为数组元素：");
            for(int x=0;x<10;x++)
            {
                MyList.Add(int.Parse(Console.ReadLine()));
            }
            MyList.ForEach(Item => Console.Write("该数组元素依次为："+Item+" "));
            int sum = 0,max=int.MinValue,min=int.MaxValue;
            MyList.ForEach(Item => sum += Item);
            MyList.ForEach(Item => { if (max < Item) max = Item; });
            MyList.ForEach(Item => { if (min > Item) min = Item; });
            Console.WriteLine($"该数组元素和为：{sum}");
            Console.WriteLine($"该数组最大值为：{max}");
            Console.WriteLine($"该数组最小值为：{min}");
            Console.ReadKey();
        }
    }
}

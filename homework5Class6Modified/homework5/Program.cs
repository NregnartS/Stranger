using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class Program
    {
        public static Order CreatOrder()   
        {
            Console.WriteLine("请输入订单号");
            int Id = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out Id))
                { Id = int.Parse(input);break; }
                else
                    Console.WriteLine("请输入正确格式订单号");
            }
            Console.WriteLine("请输入客户名称");
            Customer customer=new Customer( Console.ReadLine());
            Console.WriteLine("请依次输入商品名称、商品数量、商品单价");
            string type=" ";int Num=0;double Price=0;
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                    type = Console.ReadLine();
                else if(i==1)
                {
                    string inputNum = Console.ReadLine();
                    if (int.TryParse(inputNum, out Num))
                        Num = int.Parse(inputNum);
                    else
                    { Console.WriteLine("请输入正确格式的商品数量"); i = 0; }
                }
                else
                {
                    string PriceInput = Console.ReadLine();
                    if (double.TryParse(PriceInput, out Price))
                        Price = double.Parse(PriceInput);
                    else
                    { Console.WriteLine("请输入正确格式的商品单价"); i = 1; }
                }
            }
            Goods goods = new Goods(Num, type, Price);
            OrderItem orderItem = new OrderItem(customer, goods);
            Order order = new Order(Id,orderItem);
            return order;
        }
        public static void SelectFun(OrderService service,string input)
        {
            bool Exit = false;
            while (!Exit)
            {
                switch (input)
                {
                    case "A":
                        Console.WriteLine("请输入订单号：");
                        int ID;
                        string inputID = Console.ReadLine();
                        if (int.TryParse(inputID, out ID))
                        { ID = int.Parse(inputID); service.SelectOrderByID(ID); Exit = true; }
                        else
                            Console.WriteLine("订单号格式有误");
                        break;
                    case "B":
                        Console.WriteLine("请输入客户名称：");
                        string CustomerName=Console.ReadLine();
                        service.SelectOrderByCustomer(CustomerName);
                        Exit = true;
                        break;
                    case "C":
                        Console.WriteLine("请输入商品名称：");
                        string name = Console.ReadLine();
                        service.SelectOrderByName(name);
                        Exit = true;
                        break;
                }
            }
        }
        public static void PrintScreen(OrderService Service)
        {
            while (true)
            {
                Console.WriteLine("---------------------------订单管理系统--------------------------");
                Console.WriteLine("----------------------------请选择功能---------------------------");
                Console.WriteLine("A:添加订单 B:删除订单 C:修改订单 D:查询订单 E:显示所有订单 F:清屏");
                Console.WriteLine("------G:将当前所有订单序列化为xml文件 H:从xml文件中载入订单------");
                Console.WriteLine("----------------I:显示当前xml文件内容  Q:退出程序----------------");
                string s = Console.ReadLine();
                string FilePath;
                switch (s)
                {
                    case "A":
                        Service.AddOrder(CreatOrder());
                        break;
                    case "B":
                        {
                            Console.WriteLine("请输入要删除订单的订单号：");
                            string inputID = Console.ReadLine();
                            int DeleteId = 0;
                            if (int.TryParse(inputID, out DeleteId))
                            {
                                DeleteId = int.Parse(inputID);
                                Service.DeleteOrder(DeleteId);
                            }
                            else
                                Console.WriteLine("请输入正确格式的订单号");
                        }
                        break;
                    case "C":
                        {
                            Console.WriteLine("-----修改订单-----");
                            Console.WriteLine("------旧订单------");
                            Order OldOrder = CreatOrder();
                            Console.WriteLine("------新订单------");
                            Order NewOrder = CreatOrder();
                            Service.ModifyOrder(OldOrder, NewOrder);
                        }
                        break;
                    case "D":
                        Console.WriteLine("--------------------------查询订单--------------------------");
                        Console.WriteLine("--A:根据订单号查询  B:根据客户名称查询  C:根据商品名称查询--");
                        string input = Console.ReadLine();
                        SelectFun(Service, input);
                        break;
                    case "E":
                        if (Service.OrderData.Count() == 0)
                            Console.WriteLine("当前无订单！");
                        else
                        {
                            for (int i = 0; i < Service.OrderData.Count(); i++)
                                Console.WriteLine(Service.OrderData[i]);
                        }
                        break;
                    case "F":
                        Console.Clear();
                        break;
                    case "G":
                        Console.Write("请输入xml文件路径(格式错误或未输入则默认为根目录)：");
                        FilePath = Console.ReadLine();
                        Service.Export(FilePath);
                        break;
                    case "H":
                        Console.Write("请输入xml文件路径(格式错误或未输入则默认为根目录)：");
                        FilePath = Console.ReadLine();
                        Service.Import(FilePath);
                        break;
                    case "I":
                        Service.ReadXml();
                        break;
                    case "Q":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("输入有误，按任意键重新输入");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            OrderService Service = new OrderService();
            PrintScreen(Service);
        }
    }
}

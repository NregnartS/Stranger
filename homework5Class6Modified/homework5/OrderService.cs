using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace homework5
{
        public class OrderService
    {
        XmlSerializer SerializeOrder = new XmlSerializer(typeof(Order[]));
        public List<Order> OrderData = new List<Order>();
        public void AddOrder(Order NewOrder)
        {
            if (OrderData.IndexOf(NewOrder) != -1)
                throw new Exception("新订单已存在！");
            else
                OrderData.Add(NewOrder);
        }
        public void DeleteOrder(int ID)
        {
            var temp = from O in OrderData
                       where O.ID == ID
                       select OrderData.IndexOf(O);
            if (temp.Count()==0)
                throw new Exception("该订单不存在！");
            else
            {
                List<int> tempList = temp.ToList();
                OrderData.RemoveAt(tempList[0]);
                Console.WriteLine("删除订单成功！");
            }
        }
        public void ModifyOrder(Order OldOrder, Order NewOrder)
        {
            if (OldOrder.Equals(NewOrder))
                throw new Exception("没有对任何参数进行修改！");
            if (OrderData.IndexOf(NewOrder) != -1)
                throw new Exception("新订单已存在！");
            else
            {
                if (!OrderData.Contains(OldOrder))
                    Console.WriteLine("被修改订单不存在！");
                else
                {
                    OrderData.Remove(OldOrder);
                    OrderData.Add(NewOrder);
                }
            }
        }
        public void SelectOrderByID(int Id)
        {
            var temp = OrderData
                .Where(O => O.ID == Id)
                .OrderBy(O => O.OrderItem.AmountOfMoney);
            if (temp.Count() == 0)
                Console.WriteLine("该订单号不存在！");
            else
            {
                Console.WriteLine("查询结果为：");
                List < Order > orders= temp.ToList();
                Console.WriteLine(orders[0]);
            }
        }
        public void SelectOrderByName(string Name)
        {
            var temp = OrderData
                .Where(O => O.OrderItem.Goods.Type == Name)
                .OrderBy(O => O.OrderItem.AmountOfMoney);
            if (temp.Count()==0)
                Console.WriteLine("该商品名称不存在！");
            else
            {
                Console.WriteLine("查询结果为：");
                List<Order> orders = temp.ToList();
                for(int i=0;i<temp.Count();i++)
                    Console.WriteLine(orders[i]);
            }
        }
        public void SelectOrderByCustomer(string Customer)
        {
            var temp = OrderData
                .Where(O => O.OrderItem.Customer.CustomerName==Customer)
                .OrderBy(O => O.OrderItem.AmountOfMoney);
            if (temp.Count()==0)
                Console.WriteLine("该客户不存在！");
            else
            {
                Console.WriteLine("查询结果为：");
                List<Order> orders = temp.ToList();
                for (int i = 0; i < temp.Count(); i++)
                    Console.WriteLine(orders[i]);
            }
        }
        public void ReadXml()
        {
            Console.WriteLine(File.ReadAllText("Order.xml"));
        }
        public void Export(string FilePath)
        {
            using (FileStream xmlfstream = new FileStream(FilePath+"Order.xml", FileMode.Create))
            {
                Array array= OrderData.ToArray();
                SerializeOrder.Serialize(xmlfstream, array);
            }
            Console.WriteLine("序列化成功！当前xml文件内容：");
            Console.WriteLine(File.ReadAllText(FilePath+"Order.xml"));
        }
        public void Import(string FilePath)
        {
            using (FileStream xmlfilestream=new FileStream(FilePath+"Order.xml",FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                Order[] TempOderList = (Order[])SerializeOrder.Deserialize(xmlfilestream);
                int sum=0;
                foreach(Order tempOrder in TempOderList)
                {
                    OrderData.Add(tempOrder);
                    sum += 1;
                }
                if (sum == 0)
                { Console.WriteLine("未读入任何内容，请检查xml文件是否为空！"); }
                else
                {
                    Console.WriteLine("反序列化成功！读取的xml文件内容：");
                    Console.WriteLine(File.ReadAllText(FilePath+"Order.xml"));
                }
            }
        }
    }
}

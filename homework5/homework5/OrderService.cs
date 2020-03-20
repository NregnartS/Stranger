using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
        class OrderService
    {
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
            if (temp == null)
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
    }
}

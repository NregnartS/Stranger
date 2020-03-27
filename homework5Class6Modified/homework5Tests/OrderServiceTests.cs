using Microsoft.VisualStudio.TestTools.UnitTesting;
using homework5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace homework5.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService orderService = new OrderService();
        List<Order> result = new List<Order>();
        Goods goods = new Goods(1, "保温杯", 98.9);
        Customer customer = new Customer("Miss 冻");
        [TestMethod()]
        public void AddOrderTest()
        {
            result.Clear();
            OrderItem orderItem = new OrderItem(customer, goods);
            Order order = new Order(101, orderItem);
            result.Add(order);
            orderService.AddOrder(order);
            CollectionAssert.Equals(orderService.OrderData, result);
        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            result.Clear();
            OrderItem orderItem = new OrderItem(customer, goods);
            Order order = new Order(101, orderItem);
            orderService.OrderData.Add(order);
            orderService.DeleteOrder(101);
            CollectionAssert.Equals(orderService.OrderData, result);
        }

        [TestMethod()]
        public void ModifyOrderTest()
        {
            result.Clear();
            OrderItem orderItem = new OrderItem(customer, goods);
            Order OldOrder = new Order(101, orderItem);
            Order NewOrder = new Order(201, orderItem);
            orderService.ModifyOrder(OldOrder, NewOrder);
            result.Add(NewOrder);
            CollectionAssert.Equals(orderService.OrderData, result);
        }

        [TestMethod()]
        public void ImportTest()
        {
            result.Clear();
            OrderItem orderItem = new OrderItem(customer, goods);
            Order order = new Order(101, orderItem);
            result.Add(order);
            orderService.Import("test");
            CollectionAssert.Equals(orderService.OrderData, result);
        }
    }
}
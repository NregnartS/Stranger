using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class Order
    {
        public Order(int ID,OrderItem orderItem)
        {
            this.ID = ID;
            OrderItem = orderItem;
        }
        public int ID { get; set; }
        public OrderItem OrderItem { set; get; }
        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   ID == order.ID &&
                   EqualityComparer<OrderItem>.Default.Equals(OrderItem, order.OrderItem);
        }
        public override int GetHashCode()
        {
            var hashCode = -1225691856;
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<OrderItem>.Default.GetHashCode(OrderItem);
            return hashCode;
        }
        public override string ToString()
        {
            return "订单订单号：" + ID + OrderItem;
        }
    }
}

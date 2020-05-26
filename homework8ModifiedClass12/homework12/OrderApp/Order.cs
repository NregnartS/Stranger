using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace homework12.OrderApp
{
    [Serializable]
    public class Order
    {
        [Key]
        public int ID { get; set; }
        public Order() { ID = -1; OrderItem = new OrderItem(); }
        public Order(int ID, OrderItem orderItem)
        {
            this.ID = ID;
            OrderItem = orderItem;
        }
        public OrderItem OrderItem { set; get; }
        public override string ToString()
        {
            return "订单订单号：" + ID + OrderItem;
        }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   ID == order.ID;
        }
        public override int GetHashCode()
        {
            int hashCode = -1225691856;
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<OrderItem>.Default.GetHashCode(OrderItem);
            return hashCode;
        }
    }
}

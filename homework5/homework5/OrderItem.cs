using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class OrderItem
    {
        public Customer Customer { get; set; }
        public Goods Goods { get; set; }
        public double AmountOfMoney { get; set; }
        public OrderItem( Customer Customer, Goods Goods)
        {
            this.Customer = Customer;
            this.Goods = Goods;
            this.AmountOfMoney = this.Goods.UnitPrice * this.Goods.Number;
        }
        public override string ToString()
        {
            return " "+Customer + Goods + " 订单总金额：" + AmountOfMoney;
        }
        public override bool Equals(object obj)
        {
            return obj is OrderItem item &&
                   EqualityComparer<Customer>.Default.Equals(Customer, item.Customer) &&
                   EqualityComparer<Goods>.Default.Equals(Goods, item.Goods) &&
                   AmountOfMoney == item.AmountOfMoney;
        }
        public override int GetHashCode()
        {
            var hashCode = 1703163722;
            hashCode = hashCode * -1521134295 + EqualityComparer<Customer>.Default.GetHashCode(Customer);
            hashCode = hashCode * -1521134295 + EqualityComparer<Goods>.Default.GetHashCode(Goods);
            hashCode = hashCode * -1521134295 + AmountOfMoney.GetHashCode();
            return hashCode;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace homework12.OrderApp
{
    public class OrderItem
    {
        [Key]
        public string ID { get; set; }
        public OrderItem() { ID = Guid.NewGuid().ToString(); }
        public Customer Customer { get; set; }
        public Goods Goods { get; set; }
        public double AmountOfMoney { get; set; }
        public OrderItem(Customer Customer, Goods Goods)
        {
            ID = Guid.NewGuid().ToString();
            this.Customer = Customer;
            this.Goods = Goods;
            this.AmountOfMoney = this.Goods.UnitPrice * this.Goods.Number;
        }
        public override string ToString()
        {
            return " " + Customer + Goods + " 订单总金额：" + AmountOfMoney;
        }
        public override bool Equals(object obj)
        {
            return obj is OrderItem item &&
                   ID == item.ID &&
                   EqualityComparer<Customer>.Default.Equals(Customer, item.Customer) &&
                   EqualityComparer<Goods>.Default.Equals(Goods, item.Goods) &&
                   AmountOfMoney == item.AmountOfMoney;
        }
        public override int GetHashCode()
        {
            int hashCode = -750575702;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ID);
            hashCode = hashCode * -1521134295 + EqualityComparer<Customer>.Default.GetHashCode(Customer);
            hashCode = hashCode * -1521134295 + EqualityComparer<Goods>.Default.GetHashCode(Goods);
            hashCode = hashCode * -1521134295 + AmountOfMoney.GetHashCode();
            return hashCode;
        }
    }
}

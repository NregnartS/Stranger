using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace homework12.OrderApp
{
    public class Goods
    {
        [Key]
        public string ID { get; set; }
        public Goods() { ID = Guid.NewGuid().ToString(); }
        public Goods(int Num, string Type, double Price)
        {
            ID = Guid.NewGuid().ToString();
            this.Number = Num;
            this.Type = Type;
            this.UnitPrice = Price;
        }
        public int Number { get; set; }
        public string Type { get; set; }
        public double UnitPrice { get; set; }
        public override string ToString()
        {
            return " 商品名称：" + Type + " 商品数量：" + Number + " 商品单价：" + UnitPrice;
        }
        public override bool Equals(object obj)
        {
            return obj is Goods goods &&
                   ID == goods.ID &&
                   Type == goods.Type;
        }
        public override int GetHashCode()
        {
            int hashCode = 430596813;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            return hashCode;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    public class Goods
    {
        public Goods() { }
        public Goods(int Num, string Type, double Price)
        {
            this.Number = Num;
            this.Type = Type;
            this.UnitPrice = Price;
        }
        public int Number { get; set; }
        public string Type { get; set; }
        public double UnitPrice { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Goods goods &&
                   Number == goods.Number &&
                   Type == goods.Type &&
                   UnitPrice == goods.UnitPrice;
        }

        public override string ToString()
        {
            return " 商品名称：" + Type + " 商品数量：" + Number + " 商品单价：" + UnitPrice;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class Customer
    {
        public string CustomerName { get; set; }

        public Customer(string Name)
        {
            CustomerName = Name;
        }
        public override bool Equals(object obj)
        {
            return obj is Customer customer &&
                   CustomerName == customer.CustomerName;
        }

        public override string ToString()
        {
            return " 顾客姓名：" + CustomerName;
        }

    }
}

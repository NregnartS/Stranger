using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace homework12.OrderApp
{
    public class Customer
    {
        [Key]
        public string ID { get; set; }
        public string CustomerName { get; set; }

        public Customer()
        { ID = Guid.NewGuid().ToString(); }
        public Customer(string Name)
        {
            ID = Guid.NewGuid().ToString();
            CustomerName = Name;
        }
        public override bool Equals(object obj)
        {
            var customer = obj as Customer;
            return customer != null &&
                   ID == customer.ID &&
                   CustomerName == customer.CustomerName;
        }
        public override string ToString()
        {
            return " 顾客姓名：" + CustomerName;
        }
        public override int GetHashCode()
        {
            int hashCode = -684839406;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CustomerName);
            return hashCode;
        }
    }
}

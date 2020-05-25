using System;
using homework5;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace homework8
{
    public partial class Form2 : Form
    {
        public OrderService OrderServic { get; internal set; }
        public Form2(OrderService orderService)
        {
            InitializeComponent();
            this.OrderServic = orderService;
        }
        public bool Check(string id,string price,string num)
        {
            bool tag = true;
            int Num;
            if (!int.TryParse(num, out Num))
            {
                MessageBox.Show("商品数量输入有误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tag = false;
            }
            double Price;
            if (!double.TryParse(price, out Price))
            {
                MessageBox.Show("商品单价输入有误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tag = false;
            }
            int ID;
            if (!int.TryParse(id, out ID))
            {
                MessageBox.Show("订单号输入有误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tag = false;
            }
            return tag;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modify_Click(object sender, EventArgs e)
        {
            if (Check(IdTextBox.Text, PriceTextBox.Text, NumTextBox.Text))
            {
                Goods goods = new Goods(int.Parse(NumTextBox.Text), NameTextBox.Text, double.Parse(PriceTextBox.Text));
                Customer customer = new Customer(CustomerTextBox.Text);
                OrderItem orderItem = new OrderItem(customer, goods);
                Order order = new Order(int.Parse(IdTextBox.Text), orderItem);
                string id = Interaction.InputBox("请输入要修改订单的订单号：", "删除订单", "", -1, -1);
                int ID;
                if (!int.TryParse(id, out ID))
                {
                    MessageBox.Show("订单号只能由数字构成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                OrderServic.DeleteOrder(int.Parse(id));
                OrderServic.AddOrder(order);
                MessageBox.Show("修改订单成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (Check(IdTextBox.Text, PriceTextBox.Text, NumTextBox.Text))
            {
                Goods goods = new Goods(int.Parse(NumTextBox.Text), NameTextBox.Text, double.Parse(PriceTextBox.Text));
                Customer customer = new Customer(CustomerTextBox.Text);
                OrderItem orderItem = new OrderItem(customer, goods);
                Order order = new Order(int.Parse(IdTextBox.Text), orderItem);
                OrderServic.AddOrder(order);
                MessageBox.Show("添加订单成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
    }
}

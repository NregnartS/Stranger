using homework5;
using System;
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
    public partial class Form1 : Form
    {
        OrderService orderService;
        void SearchOrderComboBox()
        {
            SearchComboBox.Items.Add("订单号");
            SearchComboBox.Items.Add("商品名称");
            SearchComboBox.Items.Add("客户名称");
        }
        public Form1()
        {
            InitializeComponent();
            orderService = new OrderService();
            Goods goods = new Goods(100, "信纸",1.0);
            Customer customer = new Customer("李");
            OrderItem orderItem = new OrderItem(customer, goods);
            Order order = new Order(001, orderItem);
            orderService.AddOrder(order);
            Goods sgoods = new Goods(10, "水杯", 10.0);
            Customer scustomer = new Customer("王");
            OrderItem sorderItem = new OrderItem(scustomer, sgoods);
            Order sorder = new Order(002, sorderItem);
            orderService.AddOrder(sorder);
            OrderBindingSource.DataSource = orderService.GetAllOrders() ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SearchOrderComboBox();
        }
        private void QueryAll()
        {
            OrderBindingSource.DataSource = orderService.GetAllOrders();
            OrderBindingSource.ResetBindings(false);
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SearchOrder_Click(object sender, EventArgs e)
        {
            switch (SearchComboBox.Text)
            {
                case "订单号":
                    string id = Interaction.InputBox("请输入订单号：", "按订单号查询","", -1,-1);
                    int ID;
                    if (id == "")
                    { MessageBox.Show("订单号不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    else if (!int.TryParse(id, out ID))
                    {
                        MessageBox.Show("订单号只能由数字构成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        List<Order> orders = orderService.SelectOrderByID(int.Parse(id));
                        OrderBindingSource.DataSource = orderService.GetAllOrders();
                    }
                    break;
                case "商品名称":
                    string good = Interaction.InputBox("请输入商品名称：", "按商品名称查询", "", -1, -1);
                    if (good == "")
                    { MessageBox.Show("商品名称不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    else
                    {
                        List<Order> orders = orderService.SelectOrderByName(good);
                    }
                    break;
                case "客户名称":
                    string customer = Interaction.InputBox("请输入客户名称：", "按客户名称查询", "", -1, -1);
                    if (customer == "")
                    { MessageBox.Show("客户名称不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    else
                    {
                        List<Order> orders = orderService.SelectOrderByCustomer(customer);
                    }
                    break;
                default:
                    MessageBox.Show("请选择查询条件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            OrderBindingSource.ResetBindings(true);
        }

        private void CreateOrder_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(orderService);
            form2.ShowDialog();
            orderService = form2.OrderServic;
            OrderBindingSource.ResetBindings(false);
        }

        private void DeleteOrder_Click(object sender, EventArgs e)
        {
            string id = Interaction.InputBox("请输入订单号：", "删除订单", "", -1, -1);
            int ID;
            if (!int.TryParse(id, out ID))
            {
                MessageBox.Show("订单号只能由数字构成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            orderService.DeleteOrder(int.Parse(id));
            OrderBindingSource.ResetBindings(false);
        }

        private void ModifyOrder_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(orderService);
            form2.ShowDialog();
            orderService = form2.OrderServic;
            OrderBindingSource.ResetBindings(false);
        }

        private void OutOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                String fileName = saveFileDialog1.FileName;
                orderService.Export(fileName);
            }
        }

        private void InOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                String fileName = openFileDialog1.FileName;
                orderService.Import(fileName);
                QueryAll();
            }
        }
    }
}
    
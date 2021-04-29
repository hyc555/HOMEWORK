using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeWork8._6;

namespace HomeWork8._5
{
    public partial class Form2 : Form
    {
        private OrderService os;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(ref Order os) : this() => this.os = os;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            List<Order> list = new List<Order>();
            list = os.SelectOrderByNumber(textBox_OrderNum.Text);
            foreach(Order order in list)
            {
                os.DeletOrder(order);
            }
           
        }

        private void btn_addGoods_Click(object sender, EventArgs e)
        {
            Order order = new Order(textBox_OrderNum.Text, textBox_client.Text);
            os.AddOrder(order);
        }

        private void btn_addDetail_Click(object sender, EventArgs e)
        {

            List<Order> list = new List<Order>();
            list = os.SelectOrderByNumber(textBox_OrderNum.Text);
            os.AddDetails(list[0], textBox_Goods.Text, double.Parse(textBox_price.Text), int.Parse(textBox_number.Text));
        }
    }
}

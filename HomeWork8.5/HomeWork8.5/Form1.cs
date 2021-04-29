using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeWork8._6;

namespace HomeWork8._5
{
    public partial class Form1 : Form
    {
        OrderService os = new OrderService();
        public Form1()
        {
            InitializeComponent();
            orderBindingSource.DataSource = os.List;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchText = selectType.SelectedItem.ToString();
            switch (searchText) {
                case "姓名":                   
                    orderBindingSource.DataSource = os.SelectOrderByCilent(searchText);
                    break;
                case "价格":                   
                    orderBindingSource.DataSource = os.SelectOrderByPrice(int.Parse(searchText));
                    break;
                case "订单号":
                    orderBindingSource.DataSource = os.SelectOrderByNumber(searchText);
                    break;
                case "商品名":                   
                    orderBindingSource.DataSource = os.SelectOrderByGoods(searchText);
                    break;
                default:
                    MessageBox.Show("错误");
                    orderBindingSource.DataSource = os.List;
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            os.Expotr(os.List) ;
        }

       
        private void btn_input_Click(object sender, EventArgs e)
        {
            os.Import(os.List);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void orderBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

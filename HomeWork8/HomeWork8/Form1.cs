using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeWork5;

namespace HomeWork8
{
    
    public partial class Form1 : Form
    {
        List<Order> orders = new List<Order>();
        public Form1()
        {

            InitializeComponent();
            orders.Add(new Order("15",20,"LiMing"));
            bs_order.DataSource = orders;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

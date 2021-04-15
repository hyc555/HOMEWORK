using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace HomeWork7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private Graphics graphics;
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (graphics == null)
            {
                graphics = this.CreateGraphics();
            }
            try
            {
                drawCayleyTree(int.Parse(numericUpDown1.Value.ToString()), 200, 310, double.Parse(MainLength.Text), -Math.PI / 2);
            }
            catch
            {
                MessageBox.Show("输入错误");
            }
        }

        void drawCayleyTree(int n,double x0,double y0,double leng,double th) {
            if (n == 0) { return; }
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, double.Parse(RightLength.Text) * leng, th + double.Parse(RightAngle.Text) * Math.PI / 180);
            drawCayleyTree(n - 1, x1, y1, double.Parse(LeftLength.Text) * leng, th - double.Parse(LeftAngle.Text) * Math.PI / 180);
        }

        void drawLine( double x0, double y0, double x1, double y1) {
            Pen pen=Pens.Black;
            string penColor = PenColor.SelectedItem.ToString();
            switch (penColor)
            {
                case "黑色":
                    pen = Pens.Black;
                    break;
                case "红色":
                    pen = Pens.Red;
                    break;
                case "蓝色":
                    pen = Pens.Blue;
                    break;
                case "黄色":
                    pen = Pens.Yellow;
                    break;
                case "绿色":
                    pen = Pens.Green;
                    break;
                case "橙色":
                    pen = Pens.Orange;
                    break;
                default:
                    break;
            }
            graphics.DrawLine(pen,(int)x0,(int)y0,(int)x1,(int)y1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RightLength_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void LeftLength_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void RightAngle_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void MainLength_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

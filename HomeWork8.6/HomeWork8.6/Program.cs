using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeWork8._6
{
   
        public class Order
        {
            string orderNumber;
            List<OrderDetails> orderDetails = new List<OrderDetails>();
            double price;
            DateTime time;
            string cilent;

            public Order()
            {
            }

            public Order(string orderNumber, double price, string cilent)
            {
                this.orderNumber = orderNumber;
                this.price = price;
                this.time = DateTime.Now;
                this.cilent = cilent;

            }

            public string OrderNumber
            {
                get => orderNumber;
            }

            public string Cilent
            {
                get => cilent;
                set => cilent = value;
            }
            public double Price
            {
                get => price;
                set => price = value;
            }
            public List<OrderDetails> OrderDetails
            {
                get => orderDetails;
                set => orderDetails = value;
            }

            public override bool Equals(object obj)
            {
                Order order = obj as Order;
                return order != null && order.orderNumber == orderNumber;
            }

            public override int GetHashCode()
            {
                return int.Parse(OrderNumber);
            }

            public override string ToString()
            {
                return $"买家用户名：{cilent}，价格：{price}，购买时间：{time.ToString("yyyy年MM月dd日 HH:mm:ss")}，订单号：{orderNumber}";
            }

        }

        [Serializable]
        public class OrderDetails
        {
            string goodsName;
            double price;
            int number;

            public OrderDetails()
            {
            }

            public OrderDetails(string goodsName, double price, int number)
            {
                this.goodsName = goodsName;
                Price = price;
                Number = number;
            }

            public int Number
            {
                get => number;
                set => number = value;
            }

            public double Price
            {
                get => price;
                set => price = value;
            }
            public string GoodsName
            {
                get => goodsName;
            }

            public override bool Equals(object obj)
            {
                return obj is OrderDetails details &&
                       goodsName == details.goodsName &&
                       price == details.price &&
                       number == details.number &&
                       Number == details.Number &&
                       Price == details.Price &&
                       GoodsName == details.GoodsName;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(goodsName, price, number, Number, Price, GoodsName);
            }

            public override string ToString()
            {
                return $"商品名：{goodsName},数量:{number},价格:{price}";
            }
        }

        class OrderService
        {
            List<Order> list = new List<Order>();
            public List<Order> List
            {
                get => list;
                set => list = value;
            }
            public OrderService()
            {
                List<Order> list = new List<Order>();
            }

            public List<Order> SelectOrderByNumber(string number)
            {
                var goalOrder = from Order in list
                                where Order.OrderNumber == number
                                orderby Order.Price
                                select Order;
                List<Order> goalOrderList = goalOrder.ToList();
                return goalOrderList;
            }
            public List<Order> SelectOrderByCilent(string cilent)
            {
                var goalOrder = from Order in list
                                where Order.Cilent == cilent
                                orderby Order.Price
                                select Order;
                List<Order> goalOrderList = goalOrder.ToList();
                return goalOrderList;
            }
            public List<Order> SelectOrderByPrice(double price)
            {
                var goalOrder = from Order in list
                                where Order.Price == price
                                orderby Order.Price
                                select Order;
                List<Order> goalOrderList = goalOrder.ToList();
                return goalOrderList;
            }
            public List<Order> SelectOrderByGoods(string goodsName)
            {
                List<Order> goalList = new List<Order>();
                foreach (Order order in list)
                {
                    foreach (OrderDetails orderDetails in order.OrderDetails)
                    {
                        if (orderDetails.GoodsName.Equals(goodsName))
                        {
                            goalList.Add(order);
                            break;
                        }
                    }
                }
                //var goalOrder = from Order in list
                //                where Order.Goods[1] == goodsName
                //                orderby Order.Price
                //                select Order;
                //List<Order> goalOrderList = goalOrder.ToList();
                var goalOrder = from Order in goalList
                                orderby Order.Price
                                select Order;
                List<Order> goalOrderList = goalOrder.ToList();
                return goalOrderList;
            }
            public void AddOrder(Order order)
            {
                bool flag = false;
                foreach (Order o in list)
                {
                    if (o.Equals(order))
                    {
                        flag = true;
                        throw new OptionException("订单已存在");
                    }

                }
                if (flag == false)
                {
                    list.Add(order);
                }
            }
            public void AddDetails(Order order, string goodsName, double price, int number)
            {
                bool flag = false;
                OrderDetails orderDetails = new OrderDetails(goodsName, price, number);
                foreach (OrderDetails o in order.OrderDetails)
                {
                    if (o.Equals(orderDetails))
                    {
                        flag = true;
                        throw new OptionException("订单已存在");
                    }

                }
                if (flag == false)
                {
                    list.Add(order);
                }
            }

            public void DeletOrder(Order order)
            {
                if (list.Exists(x => x.OrderNumber.Equals(order.OrderNumber)))
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (order.OrderNumber.Equals(list[i].OrderNumber))
                        {
                            list.Remove(list[i]);
                            Console.WriteLine(List[i].ToString());
                        }
                    }
                }
                else
                {
                    throw new OptionException("订单不存在");
                }
            }

            public void ChangeOrder(Order order)
            {
                string number = order.OrderNumber;
                List<Order> oldOrderList = SelectOrderByNumber(number);
                if (oldOrderList != null)
                {
                    list.Remove(oldOrderList[0]);
                    list.Add(order);
                }
                else
                {
                    throw new OptionException("订单不存在");
                }

            }

            public void Expotr(List<Order> orders)
            {
            System.Xml.Serialization.XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
                using (FileStream fileStream = new FileStream("order.xml", FileMode.Create))
                {
                    xmlSerializer.Serialize(fileStream, orders);
                }
            }

            public void Import(List<Order> orders)
            {
                XmlSerializer xmlSeriazer = new XmlSerializer(typeof(List<Order>));
                using (FileStream fileStream = new FileStream("order.xml", FileMode.Open))
                {
                    orders = (List<Order>)xmlSeriazer.Deserialize(fileStream);
                }
            }
        }
        class OptionException : ApplicationException
        {
            public OptionException(String message) : base(message)
            {
            }
        }


    
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

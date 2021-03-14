using System;

namespace HomeWork3
{
    public interface Shape
    {
        public double Area { get; set; }
        bool IsRightShape();
    }

    public class Point
    {
        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        internal int x { get; set; }
        internal int y { get; set; }

        public static void Length(Point p1, Point p2, out double length)
        {
            if (p1 != null && p2 != null) {
                length = Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
            }
            else
            {
                length = 0;
            }
        }
    }

    public class Triangle : Shape
    {
        int pointNumber = 3;
        Point[] p = new Point[4];
        double[] l = new double[4];
        double Shape.Area
        {
            get {
                double pm = (l[1] + l[2] + l[3]) / 2;

                double area = Math.Sqrt(pm * (pm - l[1]) * (pm - l[2]) * (pm - l[3]));
                return area;
            }
            set {
                double pm = (l[1] + l[2] + l[3]) / 2;

                double area = Math.Sqrt(pm * (pm - l[1]) * (pm - l[2]) * (pm - l[3]));
                area = value;
            }
        }

        //int Shape.Area => throw new NotImplementedException();

        public Triangle(Point p1,Point p2,Point p3)
        {
            p[1] = p1;
            p[2] = p2;
            p[3] = p3;
            Point.Length(p[1], p[2], out l[1]);
            Point.Length(p[2], p[3], out l[2]);
            Point.Length(p[3], p[1], out l[3]);
        }

        public bool IsRightShape()
        {
            if (pointNumber == 3) {
                return true;
            }
            else if (p[1].x == p[2].x && p[1].y == p[2].y)
            {
                return false;
            }
            else if (p[2].x == p[3].x && p[2].y == p[3].y)
            {
                return false;
            }
            else if (p[1].x == p[3].x && p[1].y == p[3].y)
            {
                return false;
            }
            else
            {
                return false;
            }
        }
    }
    public class Rectango : Shape
    {
        protected int pointNumber = 4;
        protected Point[] p = new Point[5];
        protected double[] l = new double[7];
        int Area { get; set; }

        double Shape.Area
        {
            get
            {
                double area = l[1] * l[2];
                return area;
            }
            set
            {
                double area = l[1] * l[2];
                area = value;
            }
        }

        public Rectango(Point p1,Point p2)
        {
            p[1] = p1;
            p[3] = p2;
            p[2] = new Point(p2.x, p1.y);
            p[4] = new Point(p1.x, p2.y);
            Point.Length(p[1], p[2], out l[1]);
            Point.Length(p[2], p[3], out l[2]);
            Point.Length(p[3], p[4], out l[3]);
            Point.Length(p[4], p[1], out l[4]);
        }


        public bool IsRightShape()
        {
            if (pointNumber != 4) {
                return false;
            }
            else if (p[1].x == p[3].x && p[1].y == p[3].y)
            {
                return false;
            }
            else if (l[1] != l[3] || l[2] != l[4])
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    public class Square : Rectango
    {
        public Square(Point p1,Point p2):base(p1,p2)
        {
            p[1] = p1;
            p[2] = p2;
            p[3] = new Point(p2.x+p1.y-p2.y, p2.y+p2.x-p1.x);
            p[4] = new Point(p1.x+p1.y-p2.y, p1.y+p2.x-p1.x);
            Point.Length(p[1], p[2], out l[1]);
            Point.Length(p[2], p[3], out l[2]);
            Point.Length(p[3], p[4], out l[3]);
            Point.Length(p[4], p[1], out l[4]);
        }
        public bool IsRightShape()
        {
            if (base.IsRightShape() == false)
            {
                return false;
            }
            else if (p[1].x == p[3].x && p[1].y == p[3].y)
            {
                return false;
            }
            else if (l[1] != l[2])
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    class Factory
    {
        static public Shape GetShape()
        {
            Random rd = new Random();
            int n = rd.Next(1, 4);
            Point p1 = new Point(rd.Next(1,100), rd.Next(1,100));
            Point p2 = new Point(rd.Next(1,100), rd.Next(1,100));
            Point p3 = new Point(rd.Next(1,100), rd.Next(1,100));
            switch (n)
            {
                case 1:
                    Console.WriteLine("生成三角形");
                    return new Triangle(p1, p2, p3);
                case 2:
                    Console.WriteLine("生成长方形");
                    return new Rectango(p1, p2);
                case 3:
                    Console.WriteLine("生成正方形");
                    return new Square(p1, p2);
                default:
                    Console.WriteLine("ERROR");
                    return null;
            }
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Factory f = new Factory();
            Shape[] s = new Shape[10];
            for(int i = 0; i < 10; i++)
            {
                s[i] = Factory.GetShape();
            }
            for (int i = 0; i < 10; i++)
            {
                if (s[i].IsRightShape() == true)
                {
                    Console.WriteLine($"第{i+1}个图形的面积是{ (int)s[i].Area}");
                }
                else
                {
                    Console.WriteLine("生成错误");
                }
            }
        }
    }
}

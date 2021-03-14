using System;

namespace HomeWork22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many numbers");
            int?sum=null;
            int?max=null;
            int?min=null;
            double?average=0;
            int num;
            int[] a;
            num = int.Parse(Console.ReadLine());
            a = new int[num];
            Console.WriteLine("enter the numbers");
            for (int i = 0; i < num; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            foreach(int k in a)
            {
                if (sum == null) 
                {
                    sum = k;
                }
                else {
                    sum += k;
                }
                if (max == null)
                {
                    max = k;
                }
                else
                {
                    max = max > k ? max : k;
                }
                if (min == null)
                {
                    min = k;
                }
                else
                {
                    min = min < k ? min : k;
                }
                if (sum != null)
                {
                    average = sum / num;
                }
            }
            Console.WriteLine($"max is {max}");
            Console.WriteLine($"min is {min}");
            Console.WriteLine($"sum is {sum}");
            Console.WriteLine($"average is {average}");
        }
    }
}

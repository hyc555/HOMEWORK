using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number:");
            int num=int.Parse(Console.ReadLine());
            int k = num;
            for(int i = 2; i <=k; i++)
            {
                int flag = 0;
                while (k % i == 0)
                {
                    k = k / i;
                    if (flag == 0)
                    {
                        Console.WriteLine(i);
                    }
                    flag = 1;
                }
            }
        }
    }
}

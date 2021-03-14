using System;

namespace HomeWork222
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] flag;
            flag = new int[101];
            for(int i = 0; i <= 100; i++)
            {
                flag[i] = 0;
            }
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0 && i / j != 1)
                    {
                        flag[i] = 1;
                    }
                }
            }
            for (int i = 2; i <= 100; i++)
            {
                if (flag[i] == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

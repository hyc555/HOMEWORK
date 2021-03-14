using System;

namespace HomeWork2222
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            Console.WriteLine("Input M、N") ;
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string[] a;
            int[,] b = new int[m, n];
            a = new string[n];
            for(int i = 0; i < m; i++)
            {
                string s = Console.ReadLine();
                a= s.Split(" ");
                for(int j = 0; j < n; j++)
                {
                    b[i, j] = int.Parse(a[j]);
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i+1<m&&j+1<n)
                    {
                        if (b[i, j]!= b[i + 1, j + 1])
                        {
                            flag = 1;
                        }
                    }
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("true");
            }

        }
    }
}

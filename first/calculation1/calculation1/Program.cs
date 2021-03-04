using System;

namespace calculation1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first number");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the secong number");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the operator" );
            char c = (char)Console.Read();
            double d;
            if (c.Equals('+'))
            {
                d = a + b;
                Console.WriteLine("Result is" + d);
            }
            else if (c.Equals('-'))
            {
                d = a - b;
                Console.WriteLine("Result is" + d);
            }
            else if (c.Equals('*'))
            {
                d = a * b;
                Console.WriteLine("Result is" + d);

            }
            else if (c.Equals('/'))
            {
                d = a / b;
                Console.WriteLine("Result is"+d);
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}

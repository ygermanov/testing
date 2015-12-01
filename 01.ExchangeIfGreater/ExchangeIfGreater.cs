using System;

namespace _01.ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if (a < b)
            {
                Console.WriteLine(a + " " + b);
            }
            else
            {
                Console.WriteLine(b + " "+ a);
            }
        }
    }
}

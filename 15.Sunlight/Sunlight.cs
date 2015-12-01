using System;

namespace _15.Sunlight
{
    class Sunlight
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int n = ((number * 3) - 1) / 2;
            Console.WriteLine("{0}*{0}", new string('.', n));
            for (int i = 1; i < number; i++)
            {
                n = (((number * 3) - 1) / 2) - (i + 1);
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', i), new string('.', n));
            }
            for (int i = 0; i < (number - 1) / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', number), new string('*', number));
            }
            Console.WriteLine(new string('*', number * 3));
            for (int i = 0; i < (number - 1) / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', number), new string('*', number));
            }
            for (int i = number - 1; i > 0; i--)
            {
                n = (((number * 3) - 1) / 2) - (i + 1);
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', i), new string('.', n));
            }
            n = ((number * 3) - 1) / 2;
            Console.WriteLine("{0}*{0}", new string('.', n));
        }
    }
}

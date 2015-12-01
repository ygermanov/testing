using System;

namespace _12.ZeroSubset
{
    class ZeroSubset
    {
        static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());
            int number5 = int.Parse(Console.ReadLine());
            bool check = false;
            if (number1 == number2 && number2 == number3 && number3 == number4 && number4 == number5)
            {
                Console.WriteLine(number1 + " + " + number2 + " + " + number3 + " + " + number4 + " + " + number5 + " = 0");
                    check = true;
            }
            else
            {
                if (number1 + number2 == 0)
                {
                    Console.WriteLine(number1 + " + " + number2 + " = 0");
                    check = true;
                }
                if (number1 + number3 == 0)
                {
                    Console.WriteLine(number1 + " + " + number3 + " = 0");
                    check = true;
                }
                if (number1 + number4 == 0)
                {
                    Console.WriteLine(number1 + " + " + number4 + " = 0");
                    check = true;
                }
                if (number1 + number5 == 0)
                {
                    Console.WriteLine(number1 + " + " + number5 + " = 0");
                    check = true;
                }
                if (number1 + number2 + number3 == 0)
                {
                    Console.WriteLine(number1 + " + " + number2 + " + " + number3 + " = 0");
                    check = true;
                }
                if (number1 + number2 + number4 == 0)
                {
                    Console.WriteLine(number1 + " + " + number2 + " + " + number4 + " = 0");
                    check = true;
                }
                if (number1 + number2 + number5 == 0)
                {
                    Console.WriteLine(number1 + " + " + number2 + " + " + number5 + " = 0");
                    check = true;
                }
                if (number1 + number2 + number3 + number4 == 0)
                {
                    Console.WriteLine(number1 + " + " + number2 + " + " + number3 + " + " + number4 + " = 0");
                    check = true;
                }
                if (number1 + number2 + number3 + number5 == 0)
                {
                    Console.WriteLine(number1 + " + " + number2 + " + " + number3 + " + " + number5 + " = 0");
                    check = true;
                }
                if (number1 + number2 + number3 + number4 + number5 == 0)
                {
                    Console.WriteLine(number1 + " + " + number2 + " + " + number3 + " + " + number4 + " + " + number5 + " = 0");
                    check = true;
                }
                if (number2 + number3 == 0)
                {
                    Console.WriteLine(number2 + " + " + number3 + " = 0");
                    check = true;
                }
                if (number2 + number4 == 0)
                {
                    Console.WriteLine(number2 + " + " + number4 + " = 0");
                    check = true;
                }
                if (number2 + number5 == 0)
                {
                    Console.WriteLine(number2 + " + " + number5 + " = 0");
                    check = true;
                }
                if (number2 + number3 + number4 == 0)
                {
                    Console.WriteLine(number2 + " + " + number3 + " + " + number4 + " = 0");
                    check = true;
                }
                if (number2 + number3 + number5 == 0)
                {
                    Console.WriteLine(number2 + " + " + number3 + " + " + number5 + " = 0");
                    check = true;
                }
                if (number2 + number4 + number5 == 0)
                {
                    Console.WriteLine(number2 + " + " + number4 + " + " + number5 + " = 0");
                    check = true;
                }
                if (number2 + number3 + number4 + number5 == 0)
                {
                    Console.WriteLine(number2 + " + " + number3 + " + " + number4 + " + " + number5 + " = 0");
                    check = true;
                }
                if (number3 + number4 == 0)
                {
                    Console.WriteLine(number3 + " + " + number4 + " = 0");
                    check = true;
                }
                if (number3 + number5 == 0)
                {
                    Console.WriteLine(number3 + " + " + number5 + " = 0");
                    check = true;
                }
                if (number3 + number4 + number5 == 0)
                {
                    Console.WriteLine(number3 + " + " + number4 + " + " + number5 + " = 0");
                    check = true;
                }
                if (number4 + number5 == 0)
                {
                    Console.WriteLine(number4 + " + " + number5 + " = 0");
                    check = true;
                }
                if (!check)
                {
                    Console.WriteLine("no zero subset");
                }
            }
        }
    }
}

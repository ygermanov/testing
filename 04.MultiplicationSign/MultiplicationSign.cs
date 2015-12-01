using System;

namespace _04.MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());
            double numberThree = double.Parse(Console.ReadLine());
            if (numberOne == 0 || numberTwo == 0 || numberThree == 0)
            {
                Console.WriteLine(0);
            }
            else if (numberOne > 0 && numberTwo > 0 && numberThree > 0)
            {
                Console.WriteLine("+");
            }
            else if (numberOne < 0 && numberTwo < 0 && numberThree < 0)
            {
                Console.WriteLine("-");
            }
            else if (numberOne < 0)
            {
                if (numberThree > 0 && numberTwo > 0)
                {
                    Console.WriteLine("-");
                }
                else if (numberThree < 0)
                {
                    if (numberTwo > 0 )
                    {
                        Console.WriteLine("+");
                    }
                    else
                    {
                        Console.WriteLine("-");
                    }
                }
                else
                {
                    Console.WriteLine("+");
                }
            }
            else if (numberThree < 0)
            {
                if (numberOne > 0 && numberTwo > 0)
                {
                    Console.WriteLine("-");
                }
                else if (numberOne < 0)
                {
                    if (numberTwo > 0)
                    {
                        Console.WriteLine("+");
                    }
                    else
                    {
                        Console.WriteLine("-");
                    }
                }
                else
                {
                    Console.WriteLine("+");
                }
            }
            else if (numberTwo < 0)
            {
                if (numberThree > 0 && numberOne > 0)
                {
                    Console.WriteLine("-");
                }
                else if (numberThree < 0)
                {
                    if (numberTwo > 0)
                    {
                        Console.WriteLine("+");
                    }
                    else
                    {
                        Console.WriteLine("-");
                    }
                }
                else
                {
                    Console.WriteLine("+");
                }
            }
        }
    }
}

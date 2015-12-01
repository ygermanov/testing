using System;

namespace _07.Sort3NumbersWithNestedIfs
{
    class Sort3NumbersWithNestedIfs
    {
        static void Main()
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());
            double numberThree = double.Parse(Console.ReadLine());
            if (numberOne > numberTwo && numberOne > numberThree)
            {
                if (numberTwo > numberThree)
                {
                    Console.WriteLine(numberOne + " " + numberTwo + " " + numberThree);
                }
                else
                {
                    Console.WriteLine(numberOne + " " + numberThree + " " + numberTwo);
                }
            }
            else if (numberTwo > numberOne && numberTwo > numberThree)
            {
                if (numberOne > numberThree)
                {
                    Console.WriteLine(numberTwo + " " + numberOne + " " + numberThree);
                }
                else
                {
                    Console.WriteLine(numberTwo + " " + numberThree + " " + numberOne);
                }
            }
            else
            {
                if (numberTwo > numberOne)
                {
                    Console.WriteLine(numberThree + " " + numberTwo + " " + numberOne);
                }
                else
                {
                    Console.WriteLine(numberThree + " " + numberOne + " " + numberTwo);
                }
            }
        }
    }
}

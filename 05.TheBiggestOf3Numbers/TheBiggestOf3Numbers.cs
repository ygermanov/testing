using System;

namespace _05.TheBiggestOf3Numbers
{
    class TheBiggestOf3Numbers
    {
        static void Main()
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());
            double numberThree = double.Parse(Console.ReadLine());
            //Console.WriteLine(Math.Max(numberOne, Math.Max(numberTwo, numberThree)));
            if (numberOne > numberThree && numberOne > numberTwo)
            {
                Console.WriteLine(numberOne);
            }
            else if (numberThree > numberOne && numberThree > numberTwo)
            {
                Console.WriteLine(numberThree);
            }
            else
            {
                Console.WriteLine(numberTwo);
            }
        }
    }
}

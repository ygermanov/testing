using System;

namespace _06.TheBiggestOfFiveNumbers
{
    class TheBiggestOfFiveNumbers
    {
        static void Main()
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());
            double numberThree = double.Parse(Console.ReadLine());
            double numberFour = double.Parse(Console.ReadLine());
            double numberFIve = double.Parse(Console.ReadLine());
            if (numberOne > numberThree && numberOne > numberTwo && numberOne > numberFour && numberOne > numberFIve)
            {
                Console.WriteLine(numberOne);
            }
            else if (numberThree > numberOne && numberThree > numberTwo && numberThree > numberFour && numberThree > numberFIve)
            {
                Console.WriteLine(numberThree);
            }
            else if (numberTwo > numberOne && numberTwo > numberThree && numberTwo > numberFour && numberTwo > numberFIve)
            {
                Console.WriteLine(numberTwo);
            }
            else if (numberFour > numberOne && numberFour > numberThree && numberFour > numberTwo && numberFour > numberFIve)
            {
                Console.WriteLine(numberFour);
            }
            else
            {
                Console.WriteLine(numberFIve);
            }

        }
    }
}

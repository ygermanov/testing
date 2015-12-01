using System;
using System.Numerics;

namespace _14.PetarGame
{
    class PetarGame
    {
        static void Main()
        {
            ulong start = ulong.Parse(Console.ReadLine());
            ulong end = ulong.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            decimal numberSum = 0;
            for (ulong i = start; i < end; i++)
            {
                if (i % 5 == 0)
                {
                    numberSum += i;
                }
                else
                {
                    numberSum += i % 5;
                }
            }
            string temp = string.Empty;
            string checkNum = string.Empty;
            if (numberSum % 2 == 0)
            {
                checkNum = Convert.ToString(numberSum);
                for (int i = 0; i < checkNum.Length; i++)
                {
                    if (checkNum[i] == checkNum[0])
                    {
                        Console.Write(str);
                    }
                    else
                    {
                        Console.Write(checkNum[i]);
                    }
                }
                Console.WriteLine();
            }
            else
            {
                
                checkNum = Convert.ToString(numberSum);
                int mark = checkNum.Length - 1;
                for (int i = 0; i < checkNum.Length; i++)
                {
                    if (checkNum[i] == checkNum[mark])
                    {
                        Console.Write(str);
                    }
                    else
                    {
                        Console.Write(checkNum[i]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

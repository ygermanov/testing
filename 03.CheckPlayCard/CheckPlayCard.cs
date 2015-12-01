using System;

namespace _03.CheckPlayCard
{
    class CheckPlayCard
    {
        static void Main()
        {
            string card = Console.ReadLine();
            if (card == "A" || card == "K" || card == "Q")
            {
                Console.WriteLine("Yes");
            }
            else if (card == "2" || card == "3" || card == "4" || card == "5" || card == "6" || card == "7" || card == "8" || card == "9" || card == "10")
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

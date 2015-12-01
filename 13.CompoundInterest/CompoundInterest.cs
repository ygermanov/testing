using System;

namespace _13.CompoundInterest
{
    class CompoundInterest
    {
        static void Main()
        {
            decimal price = decimal.Parse(Console.ReadLine());
            uint years = uint.Parse(Console.ReadLine());
            decimal bankLoan = decimal.Parse(Console.ReadLine());
            decimal friendLoan = decimal.Parse(Console.ReadLine());
            decimal bankPrice = Convert.ToDecimal(Math.Pow((1 + (double)bankLoan), years)) * price;
            decimal friendPrice = (1 + friendLoan) * price;
            if (friendPrice <= bankPrice)
            {
                Console.WriteLine("{0:F2} Friend", friendPrice);
            }
            else
            {
                Console.WriteLine("{0:F2} Bank", bankPrice);
            }
        }
    }
}

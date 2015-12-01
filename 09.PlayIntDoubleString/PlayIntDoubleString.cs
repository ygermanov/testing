using System;

namespace _09.PlayIntDoubleString
{
    class PlayIntDoubleString
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int\n2 --> double\n3 --> string");
            
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    int number1 = int.Parse(Console.ReadLine());
                    Console.WriteLine(number1 + 1);
                    break;
                case 2:
                    double number2 = double.Parse(Console.ReadLine());
                    Console.WriteLine(number2 + 1d);
                    break;
                case 3:
                    string str = Console.ReadLine();
                    str += "*";
                    Console.WriteLine(str);
                    break;
                default:
                    break;
            }
        }
    }
}

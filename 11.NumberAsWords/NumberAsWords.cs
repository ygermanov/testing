using System;
using System.Collections.Generic;

namespace _11.NumberAsWords
{
    class NumberAsWords
    {
        static Dictionary<int, string> numberToString = new Dictionary<int, string>
        {
            {0, "Zero"},
            {1, "One"},
            {2, "Two"},
            {3, "Three"},
            {4, "Four"},
            {5, "Five"},
            {6, "Six"},
            {7, "Seven"},
            {8, "Eight"},
            {9, "Nine"},

            {10, "Ten"},
            {11, "Еleven"},
            {12, "Тwelve"},
            {13, "Thirteen"},
            {14, "Fourteen"},
            {15, "Fifteen"},
            {16, "Sixteen"},
            {17, "Seventeen"},
            {18, "Eighteen"},
            {19, "Nineteen"},
            
            {20, "Twenty"},
            {30, "Thirty"},
            {40, "Forty"},
            {50, "Fifty"},
            {60, "Sixty"},
            {70, "Seventy"},
            {80, "Eighty"},
            {90, "Ninety"},
            {100, "Hundred"}
        };
        static void Main()
        {
            bool check = true;
            int number = 0;
            string text = " ";
            while (check)
            {
                Console.Clear();
                Console.WriteLine(text + "Please enter number in the interval of 0 to 999:");
                try
                {
                    number = int.Parse(Console.ReadLine());
                    if (number >= 0 && number <= 999)
                    {
                        check = false;
                    }
                    else
                    {
                        text = "number is outside the valid interval !!\n";
                    }

                }
                catch (FormatException)
                {
                    text = "Please enter valid number !!\n";
                }
            }
            string output = string.Empty;
            if (number / 10 != 0)
            {
                if (number / 100 != 0)
                {
                    if ((number / 10) % 10 == 1)
                    {
                        output = numberToString[(number / 100)] + " " + numberToString[100] + " and " + numberToString[number % 100];
                    }
                    else
                    {
                        output = numberToString[(number / 100)] + " " + numberToString[100] + " and " + numberToString[((number / 10) % 10) * 10] + " " + numberToString[number % 10];
                    }
                }
                else
                {
                    if (number / 10 == 1)
                    {
                        output = numberToString[number % 100];
                    }
                    else
                    {
                        output = numberToString[(number / 10) * 10] + " " + numberToString[number % 10];
                    }
                }
            }
            else
            {
                output = numberToString[number];
            }
            Console.WriteLine(output);
        }
    }
}

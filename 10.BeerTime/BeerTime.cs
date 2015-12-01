using System;

namespace _10.BeerTime
{
    class BeerTime
    {
        static bool checkTime(TimeSpan now, TimeSpan start, TimeSpan end)
        {
            if (start < end)
            {
                return start <= now && now <= end;
            }
            else
            {
                return !(end < now && now < start);
            }
        }
        static void Main()
        {
            string time = Console.ReadLine();
            TimeSpan start = new TimeSpan(13,00,00);
            TimeSpan end = new TimeSpan(03,00,00);
            string[] temp = time.Split(' ');
            bool check = true;
            TimeSpan thisTime = new TimeSpan();
            try
            {
                thisTime = TimeSpan.Parse(temp[0]);
                
            }
            catch (OverflowException)
            {
                Console.WriteLine("invalid time");
                check = false;
            }
            catch (FormatException)
            {
                Console.WriteLine("invalid time");
                check = false;
            }
            if (check)
            {
                string[] temp2 = temp[0].Split(':');
                int[] number = { int.Parse(temp2[0]), int.Parse(temp2[1]) };
                if (temp[1] == "PM" || temp[1] == "pm")
                {
                    number[0] += 12;
                }
                TimeSpan thisTime2 = new TimeSpan(number[0], number[1], 00);
                if (checkTime(thisTime2,start,end))
                {
                    Console.WriteLine("beer time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }
            }
        }
    }
}

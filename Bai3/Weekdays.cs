using System;

namespace Bai3
{
    public class WeekdaysController
    {
        public static void Weekdays()
        {
            while (true)
            {
                Console.WriteLine("Please choose from 1 -> 7: ");
                var choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                }

                if (choose <= 7) continue;
                Console.WriteLine("Please choose again!");
                break;
            }
        }
    }
}
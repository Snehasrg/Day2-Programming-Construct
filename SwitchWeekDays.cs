using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    public class SwitchWeekDays
    {
        public static void CheckDays()
        {
            Console.WriteLine("Enter number between 0 to 6");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;

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
                default:
                    Console.WriteLine("Entered number is not in between 0 to 6");
                    break;
            }
        }
    }
}

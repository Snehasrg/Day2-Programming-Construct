using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    public class IfElseEvenOdd
    {
        public static void CheckEvenOdd()
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Entered number is even");
            }
            else
            {
                Console.WriteLine("Entered number is odd");
            }
        }
    }
}



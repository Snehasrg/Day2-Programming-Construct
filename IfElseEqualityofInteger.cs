using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    public class IfElseEqualityofInteger
    {
        public static void CheckEquality()
        {
            Console.WriteLine("Enter first integer");
            int I1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second integer");
            int I2 = Convert.ToInt32(Console.ReadLine());
            if (I1 == I2)
            {
                Console.WriteLine("Two integers are equal");
            }
            else
            {
                Console.WriteLine("Two integers are not equal");
            }
        }
    }
}

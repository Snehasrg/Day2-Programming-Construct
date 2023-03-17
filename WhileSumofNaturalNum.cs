using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    public class WhileSumofNaturalNum
    {
        public static void DisplaySum()
        {
            int j, sum = 0;

            Console.Write("The first 5 natural number are : ");
            j = 1;
            while (j <= 5)
            {
                sum = sum + j;
                Console.Write("{0} ", j);
                j++;
            }
            Console.Write("\nThe Sum is : {0}\n", sum);
        }
    }
}

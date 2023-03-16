using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    public class ElseifLargestNumber
    {
        public static void FindLargestNum()
        {
            Console.WriteLine("Enter First Number");
            int N1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int N2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            int N3 = Convert.ToInt32(Console.ReadLine());
            if (N1 > N2 && N1 > N3)
            {
                Console.WriteLine("First Number is Greater");
            }
            else if (N2 > N1 && N2 > N3)
            {
                Console.WriteLine("Second Number is Greater");
            }
            else
            {
                Console.WriteLine("Third Number is Greater");
            }
        }
    }
}

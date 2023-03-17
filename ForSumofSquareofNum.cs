using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    public class ForSumofSquareofNum
    {
        public static void summation()
        {
            Console.WriteLine("Enter n terms");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += (i * i);
            }
            Console.Write("\nThe Sum of Square Natural Number upto {0} terms = {1} \n", n, sum);
        }
    }
}

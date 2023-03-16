using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    public class IfElseVotingAge
    {
        public static void CheckEligibility()
        {
            Console.WriteLine("Enter the age of candidate");
            int Age = Convert.ToInt32(Console.ReadLine());
            if (Age >= 18)
            {
                Console.WriteLine("Candidate is eligible for voting.");
            }
            else
            {
                Console.WriteLine("Candidate is not eligible for voting.");
            }
        }
    }
}

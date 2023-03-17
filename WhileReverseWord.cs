using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    public class WhileReverseWord
    {
        public static void CheckReverse()
        {
            Console.WriteLine("Enter name");
            string Name = Console.ReadLine();
            char[] chars1 = Name.ToCharArray();
            Console.WriteLine("After Reversing");
            int i = Name.Length - 1;
            while (i >= 0)
            {
                Console.Write(chars1[i]);
                i--;
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class EvenOdd
    {
        public static void FindingEvenorOdd()
        {
            Console.WriteLine("Welcome To Even or Odd Program");
            int A = 17;
            if (A % 2 == 0)
            {
                Console.WriteLine("Number is even ");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }
}

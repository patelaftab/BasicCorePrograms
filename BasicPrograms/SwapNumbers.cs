using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class SwapNumbers
    {
        public static void ChangingNumbers()
        {
            Console.WriteLine("Welcome To Swap Numbers Program");
            Console.WriteLine("Enter a First Value :" );
            int number1=Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine("Enter a Second Value :" );
            int number2=Convert.ToInt32( Console.ReadLine() );
            int temp;
            temp=number1;
            number1= number2;
            number2 = temp;
            Console.WriteLine("\nAfter Swaping Value Of number2 is :" +number2 +
                "\nAfter Swaping Value Of number1 is :" +number1);
            Console.ReadLine();
        }
    }
}

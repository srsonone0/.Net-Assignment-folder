using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Addition
{
    class Program
    {
        static void Main(string[]  args)
        {
            int a ;
            int b;
            Console.WriteLine(" Please Enter the valu of a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Please Enter the value of b");
            b  = Convert.ToInt32(Console.ReadLine());
            int Result;
            Result = a + b;
            Console.WriteLine("Sum of two numbers :"+ Result.ToString());
            Console.ReadLine();

            

        }
    }
}

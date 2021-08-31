using System;

namespace AccessModifiers
{
    class Program
    {
        class AccessMod
        {
            public int num1;
        }
        static void Main(string[] args)
        {
            AccessMod ob1 = new AccessMod();
            //Direct access to public members  
            ob1.num1 = 100;
            Console.WriteLine("Number one value in main {0}", ob1.num1);
            Console.ReadLine();
        }
    }
}

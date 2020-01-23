using System;

namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c1 = 4 != 5;
            Console.WriteLine(c1); // true

            bool c2 = 2 > 3 && 4 != 5;
            Console.WriteLine(c2); // false

            bool c3 = 2 > 3 || 4 != 5;
            Console.WriteLine(c3);  // true

            bool c4 = ! (2 > 3) && 4 != 5;
            Console.WriteLine(c4); // true

            bool c5 = 10 < 5;
            bool c6 = c1 || c2 && c3;

            Console.WriteLine(c6);




        }
    }
}

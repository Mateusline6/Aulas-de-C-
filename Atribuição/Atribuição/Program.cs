using System;

namespace Atribuição
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            a /= 3;
            Console.WriteLine(a);

            a %= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s); 

            */

            int a = 10;
            int b = ++a;
            a++;
            Console.WriteLine(b);
            Console.WriteLine(a);

            a--;
            Console.WriteLine(a);


        }
    }
}

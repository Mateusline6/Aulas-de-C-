using System;

namespace ConversaoImplicitaCasting
{
    class Program
    {
        static void Main(string[] args)
        {

            // fazendo conversoes utilizado casting;

            float x = 4.5f;

            double y = x;

            Console.WriteLine(y);


            double a;
            float b;

            a = 5.1;
            b = (float)a;

            Console.WriteLine(b);

            double c;
            int d;

            c = 5.1;
            d = (int)c;

            Console.WriteLine(d);

            int q = 5;
            int w = 2;

            double resultado = (double) q / w;

            Console.WriteLine(resultado);



        }
    }
}

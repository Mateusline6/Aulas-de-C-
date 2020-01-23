using System;

namespace IF_ELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int x = 10;


             if (x == 10)
             { 
                 Console.WriteLine("Bom dia");
             }
             else if (x > 5) 
             {
                 Console.WriteLine("Boa tarde"); 
             }
             else {

                 Console.WriteLine("Boa noite");

             }*/


            /*
            Console.WriteLine("Entre com um numero inteiro");

            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }
            */

            Console.WriteLine("Qual a hora atual?");
            int x = int.Parse(Console.ReadLine());
            

            if(x < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if(12 <= x && x < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite");
            }






        }
    }
}

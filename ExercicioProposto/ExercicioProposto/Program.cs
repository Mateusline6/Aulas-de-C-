using System;
using System.Globalization;

namespace ExercicioProposto
{
    class Program
    {
        static void Main(string[] args)
        { /*

            // Primeiro exercicio

            Console.Write("Digite a senha: ");
            int senha = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while(senha != 2002)
            {
                Console.WriteLine("Senha invalida");
                Console.Write("Digite a senha: ");
                senha = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Acesso permitido");

            */

            /*
             * 
             * segundo exercicio
             * 
            Console.WriteLine("Digite dois numeros");
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            while( x != 0 && y != 0)
            {
                if(x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");

                }else if(x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");

                }else if(x < 0 && y < 0)
                {

                    Console.WriteLine("Terceiro");

                }
                else
                {
                    Console.WriteLine("Quarto");

                }

                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);

            }

            */

            /*
             * 
             * exercicio 03
             * 
            Console.Write("Digite um codigo: ");
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;


            int codigo = int.Parse(Console.ReadLine());

            while(codigo != 4)
            {
                if(codigo == 1)
                {
                    alcool = alcool + 1;

                }else if(codigo == 2)
                {
                    gasolina = gasolina + 1;

                }else if(codigo == 3)
                {
                    diesel = diesel + 1;

                }

                codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muito obrigado");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);

    */











        }
    }
}

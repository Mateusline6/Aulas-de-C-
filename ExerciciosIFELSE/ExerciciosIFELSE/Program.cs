using System;
using System.Globalization;

namespace ExerciciosIFELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            // exercicio 01
            /*
            Console.WriteLine("Insira um numero positivo ou negativo");

            int x = int.Parse(Console.ReadLine());

            if(x >= 0)
            {
                Console.WriteLine("Numero Positivo");

            }
            else
            {
                Console.WriteLine("numero negativo");

            }

            */



            /*
             * exercicio 02

            Console.WriteLine("Digite um numero");

            int x = int.Parse(Console.ReadLine());

            if(x % 2 == 0)
            {
                Console.WriteLine("Numero par");

            }
            else
            {

                Console.WriteLine("Numero impar");
            }
            */

            /*
             * 
             * exercicio 03
             * 
            Console.WriteLine("Digite dois numero");

            string[] x = Console.ReadLine().Split(' ');
            int a = int.Parse(x[0]);
            int b = int.Parse(x[1]);


            if(a % b == 0 || b % a == 0)
            {
                Console.WriteLine("Sao multiplos");

            }
            else
            {
                Console.WriteLine("Não são multiplus");

            }
            */

            /*
             * 
             * exercicio 04
                        Console.WriteLine("Digite a hora inicial e hora final");

                        string[] x = Console.ReadLine().Split(' ');
                        int horaInicial = int.Parse(x[0]);
                        int horaFinal = int.Parse(x[1]);

                        int duracao;


                        if(horaInicial < horaFinal)
                        {
                            duracao = horaFinal - horaInicial;

                        }
                        else
                        {
                            duracao = 24 - horaInicial + horaFinal;

                        }
                        Console.WriteLine("O jogo durou " + duracao + " horas(S)");
                        */
            /*
             * 
             * Exercicio 05

                        Console.WriteLine("Insira o codigo do item e a quantidade");

                        string[] x = Console.ReadLine().Split(' ');
                        int cod = int.Parse(x[0]);
                        int qtd = int.Parse(x[1]);
                        double resultado;


                        if(cod == 1)
                        {
                            resultado = qtd * 4.0;

                        }
                        else if(cod == 2)
                        {
                            resultado = qtd * 4.50;
                        }
                        else if (cod == 3)
                        {
                            resultado = qtd * 5.00;
                        }
                        else if (cod == 4)
                        {
                            resultado = qtd * 2.00;
                        }
                        else
                        {
                            resultado = qtd * 1.50;

                        }

                        Console.WriteLine("Total a pagar R$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));

                */



            // exercicio 06

            /*
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero < 0.0 || numero > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (numero <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (numero <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (numero <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            */


            // exercicio 07

            /*
             *
            string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0) {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0) {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0) {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0 && y > 0.0) {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0) {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0) {
                Console.WriteLine("Q3");
            }
            else {
                Console.WriteLine("Q4");
            }
             
             * 
            */

            // exercicio 08
            /*
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;
            if (salario <= 2000.0)
            {
                imposto = 0.0;
            }
            else if (salario <= 3000.0)
            {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0)
            {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }

            */
        }
    }
}

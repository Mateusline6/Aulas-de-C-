using System;
using System.Globalization;

namespace ExercicioFixação
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Some dois numeros");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine('+');
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Seu resultado foi:");
            Console.WriteLine(a + b);*/

            /*
            Console.WriteLine("Some dois numeros");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine('+');
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Seu resultado foi:");
            Console.WriteLine(c + d);*/

            /*
            Console.WriteLine("Some dois numeros");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine('+');
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("Seu resultado foi:");
            Console.WriteLine(e + f);
            */

            // calculando o radio de um circulo utilizado 4 casas decimais

            /*double e = 3.14159;
            Console.WriteLine("insira o valor do raio");
            double f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double g = (e * f * f );
            Console.WriteLine("O resultado é: " + g.ToString("F4"), CultureInfo.InvariantCulture);
           */

            //  calculando diferença
            /* Console.WriteLine("Digite 4 valores inteiros");
             int  a = int.Parse(Console.ReadLine());
             int b = int.Parse(Console.ReadLine());
             int c = int.Parse(Console.ReadLine());
             int d = int.Parse(Console.ReadLine());

             int resultado = (a * b - (c * d));
             Console.WriteLine("O resultado é: " + resultado);*/




            // calculo de valor de horas trabalhadas por horas trabalhadas

            /*  Console.WriteLine("Insira o numero do funcionario:");
              int numero = int.Parse(Console.ReadLine());
              Console.WriteLine("Insira o numero de horas trabalhadas: ");
              int hora = int.Parse(Console.ReadLine());
              Console.WriteLine("Insira o valor de recebimento hora: ");
              double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
              double resultado = salario * hora;
              Console.WriteLine("Numero do Funcionario é " + numero);
              Console.WriteLine("O salario do funcionario é " + resultado.ToString("F2"), CultureInfo.InvariantCulture);*/




            // calculando a qtd de produtos exibindo o valor final da compra , buscando as informações em uma linha
            /*Console.WriteLine("Insira o codigo, numero, valor unitario do produto");
            
            string[] a = Console.ReadLine().Split(' ');
            int codigo = int.Parse(a[0]);
            int numero = int.Parse(a[1]);
            double valor = double.Parse(a[2], CultureInfo.InvariantCulture);

            Console.WriteLine("insira o codigo, numero, valor unitario do produto 2");


            string[] b = Console.ReadLine().Split(' ');
            int cod = int.Parse(b[0]);
            int num = int.Parse(b[1]);
            double val = double.Parse(b[2],CultureInfo.InvariantCulture);


            double resultado = valor * numero + val * num;

            Console.WriteLine("Valor a ser pago: " + resultado.ToString("F2"), CultureInfo.InvariantCulture);
            */



            // calculando a area de um triangulo retangulo

          /*  double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            triangulo = A * C / 2.0;
            circulo = 3.14159 * C * C;
            trapezio = (A + B) / 2.0 * C;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
            */









        }
    }
}

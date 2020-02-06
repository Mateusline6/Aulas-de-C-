using System;
using System.Globalization;

namespace ExercicioO.O
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio 01

            /*
           Pessoa n = new Pessoa();
           Pessoa i = new Pessoa();



            Console.WriteLine("Dados da Primeira pessoa: ");

            Console.Write("Nome: ");
            n.nome = Console.ReadLine();
            Console.Write("idade: ");
            n.idade = int.Parse(Console.ReadLine());


            Console.WriteLine("Dados da Segunda pessoa: ");

            Console.Write("Nome: ");
            i.nome = Console.ReadLine();
            Console.Write("idade: ");
            i.idade = int.Parse(Console.ReadLine());



            if(n.idade > i.idade)
            {
                Console.WriteLine("Pessoa Mais velha: " + n.nome);

            }
            else
            {

                Console.WriteLine("Pessoa mais velha: "+ i.nome);
            }

    */

            Pessoa x = new Pessoa();
            Pessoa y = new Pessoa();


            Console.WriteLine("Dados do primeiro Funcionario: ");
            Console.Write("Nome: ");
            x.nome = Console.ReadLine();
            Console.Write("Salário: ");
            x.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Dados do primeiro Funcionario: ");
            Console.Write("Nome: ");
            y.nome = Console.ReadLine();
            Console.Write("Salário: ");
            y.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            double media = (x.salario + y.salario) / 2.0;


            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}

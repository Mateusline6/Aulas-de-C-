﻿using System;

namespace AulaAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = (double) 10 / 8; // fazendo o casting ou e so colocar 10.0 e 8.0


            double a = 1.0, b = -3.0, c = -4.0;
            double delta = b * b - 4.0 * a * c;
            // double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            // fazendo um calculo de raiz quadrada.
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a); 


            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(delta);
            Console.WriteLine(x1);



        }
    }
}

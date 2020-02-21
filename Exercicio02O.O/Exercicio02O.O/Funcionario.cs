using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio02O.O
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;



        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;

        }
        public void AumentaSalario(double porcentagem)
        {

            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);

        }

        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture) ;
        }


    }
}

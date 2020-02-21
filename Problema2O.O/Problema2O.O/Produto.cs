using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Problema2O.O
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Qtd;


        public double ValorTotalEmEstoque()
        {
            return Preco * Qtd;

        }

        public void AdicionarProdutos(int quantidade)
        {
            Qtd = Qtd + quantidade;


        }

        public void RemoverProduto(int quantidade)
        {
            Qtd = Qtd - quantidade;


        }


        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2",CultureInfo.InvariantCulture) +", " 
                 + Qtd + " unidades, Total: $ " 
                 + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}

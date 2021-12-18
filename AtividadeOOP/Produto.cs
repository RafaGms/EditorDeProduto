using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AtividadeOOP
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicaoProduto(int quantidade)
        {
            Quantidade += quantidade;
        }
        
        public void RemocaoProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public void MudandaValorProduto(int quantidade)
        {
            Preco = quantidade;
        }

        public override string ToString()
        {
            return ($" Nome do produto: {Nome}\n" +
                $" Preço do produto:R$ {Preco.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $" Quantidade de produtos: {Quantidade}\n" +
                $" Total:R$ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)} ");

        }

        
    }
}

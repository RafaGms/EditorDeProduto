using System;
using System.Globalization;

namespace AtividadeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p;
            Decisao d;
            p = new Produto();
            d = new Decisao();

            Console.WriteLine("============== Entre com os dados do produto:==============\n");
            Console.Write(" Nome do produto ");
            p.Nome = Console.ReadLine();
            Console.WriteLine();
            Console.Write(" Preço do produto ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.Write(" Quantidade do produto ");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"============== Dados do produto ==============\n\n{p}");
            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine(d);
                d.valorDecisao = int.Parse(Console.ReadLine());
                if (d.valorDecisao == 1)
                {
                    Console.Clear();
                    Console.Write(" Quantidade para ser adicionada ");
                    int quant = int.Parse(Console.ReadLine());
                    p.AdicaoProduto(quant);
                    Console.WriteLine();
                    Console.WriteLine($"============== Dados Atualizados:============== \n\n{p}");
                }
                else if (d.valorDecisao == 2)
                {
                    Console.Clear();
                    Console.Write(" Quantidade para ser removida ");
                    int quant = int.Parse(Console.ReadLine());
                    p.RemocaoProduto(quant);
                    Console.WriteLine();
                    Console.WriteLine($"============== Dados Atualizados:============== \n\n{p}");
                }
                else if (d.valorDecisao == 3)
                {
                    Console.Clear();
                    Console.Write(" Novo Valor ");
                    int quant = int.Parse(Console.ReadLine());
                    p.MudandaValorProduto(quant);
                    Console.WriteLine();
                    Console.WriteLine($"============== Dados Atualizados:============== \n\n{p}");
                }
                else
                {
                    Environment.Exit(0);

                }
            }
        }
    }
}

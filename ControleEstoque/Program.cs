using System;
using System.Globalization;

namespace ControleEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine(p);

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtde = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtde);

            Console.WriteLine(p);

            Console.Write("Digite o número de produtos a ser removidos do estoque: ");
            qtde = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtde);

            Console.WriteLine(p);
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ControleEstoque
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }


        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"Dados do Produto: {Nome}, R$ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total: R$ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}

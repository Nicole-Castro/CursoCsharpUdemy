﻿using System.Globalization;
namespace Course
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string Nome, double Preco, int Quantidade){
            this.Nome = Nome;
            this.Preco = Preco;
            this.Quantidade = Quantidade;
        }
        public Produto(string nome, double preco){
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
        }
        public Produto(){

        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
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
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
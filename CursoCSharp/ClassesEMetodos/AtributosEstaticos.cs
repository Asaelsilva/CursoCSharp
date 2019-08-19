using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;

        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto()
        {

        }

        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }
    }


    class AtributosEstaticos
    {
        public static void Executar()
        {
            Produto produto1 = new Produto("Caneta", 3.2, 0.1);

            Produto produto2 = new Produto
            {
                Nome = "Lapis",
                Preco = 5.3,
               // Desconto = 0.5
            };


            Produto.Desconto = 0.5;
            Console.WriteLine("Preco com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preco com desconto: {0}", produto2.CalcularDesconto());

            Produto.Desconto = 0.02;
            Console.WriteLine("Preco com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preco com desconto: {0}", produto2.CalcularDesconto());

        }
    }
}

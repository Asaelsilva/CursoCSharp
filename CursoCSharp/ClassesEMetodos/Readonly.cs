using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp
{
    public class Cliente
    {
        public string Nome;
        readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento()
        {
            return string.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }


    class Readonly
    {
        public static void Executar()
        {

            var novoCliente = new Cliente("Asael", new DateTime(1993, 03, 30));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());
        }
    }
}

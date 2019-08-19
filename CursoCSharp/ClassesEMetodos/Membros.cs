using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Aline";
            sicrano.Idade = 23;

            // Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos!");

            sicrano.ApresentarNoConsole();
            sicrano.Zarar();
            sicrano.ApresentarNoConsole();

            Pessoa fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 20;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano.Length);
            Console.WriteLine(apresentacaoDoFulano);
        }
    }
}

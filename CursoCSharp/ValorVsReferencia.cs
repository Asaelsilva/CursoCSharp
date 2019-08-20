using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp
{

    public class Dependente
    {
        public string Nome;
        public int Idade;
    }
    class ValorVsReferencia
    {
        public static void Executar()
        {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}");

            numero++;
            Console.WriteLine($"{numero} {copiaNumero}");

            //======
            Dependente dependente = new Dependente
            {
                Nome = "Asael",
                Idade = 26
            };

            Dependente copiaDependente = dependente;

            Console.WriteLine($"{dependente.Nome} {copiaDependente.Nome}");
            Console.WriteLine($"{dependente.Idade} {copiaDependente.Idade}");

            copiaDependente.Nome = "Jonatas";
            copiaDependente.Idade = 30;

            Console.WriteLine($"{dependente.Nome} {copiaDependente.Nome}");
            Console.WriteLine($"{dependente.Idade} {copiaDependente.Idade}");



        }
    }
}

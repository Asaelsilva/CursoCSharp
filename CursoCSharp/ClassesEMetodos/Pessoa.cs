using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public string Apresentar()
        {
            return string.Format($"Ola! me Chamo {Nome} e tenho {Idade} Anos.");
        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }
        public void Zarar()
        {
            Nome = " ";
            Idade = 0;
        }
    }
}

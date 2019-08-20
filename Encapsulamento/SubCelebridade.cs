using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        //Todos
        public string InfoPublica = "Tenho um instagram!";

        //Herança
        protected string CorDoOlho = "Verde";

        //Mesmo Projeto (assemble)
        internal ulong NumeroCelular = 912345678;

        //Herança ou mesmo Projeto
        protected internal string JeitoDeFalar = "Sou muito educado";

        //Mesma classe ou herança no mesmo projeto
        private protected string SegredoFamilia = "Bla Bla";

        //private é o padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridades...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }

    }
}

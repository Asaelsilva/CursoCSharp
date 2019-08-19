using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano)
        {
            Console.WriteLine("{0:D2}/{1:D1}/{2}", dia, mes, ano);
        }

        public static void Executar()
        {
            Formatar(mes: 1, dia: 6, ano: 1996);
            Formatar(dia: 20, ano: 2000, mes: 12);

        }
    }
}

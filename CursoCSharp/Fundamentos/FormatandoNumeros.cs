using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumeros
    {
        public static void Executar()
        {
            double valor = 20.00;

            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("#.###"));

            CultureInfo culturaBR = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C1", culturaBR));

            CultureInfo culturaEUA = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C2", culturaEUA));

        }
    }
}

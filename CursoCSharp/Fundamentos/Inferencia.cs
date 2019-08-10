using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var name = "Asael";
            // name = 123; proibido pois ja foi determinado como string
            Console.WriteLine(name);

            //int idade;
            var idade = 35;
            Console.WriteLine(idade);

            int a;
            a = 5;

            int b = 7;

            Console.WriteLine(a + b);

        }
    }
}

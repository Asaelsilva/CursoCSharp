using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string name = "Notebook";
            string marca = "Dell";
            double preco = 5800.00;

            Console.WriteLine("O " + name + " da marca " + marca + " Custa " + preco+".");
            Console.WriteLine("O {0} da marca {1} custa {2}.", name, marca, preco);
            Console.WriteLine($"A marca {marca} é Boa.");
            Console.WriteLine($"10 + 10 = {10 + 10}!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2;

            //comparamdo  endereço de memoria
            Console.WriteLine(p1 == p2); // False pois esta comparando referencias de memoria. p1 foi criado em um espaça da memoria, e p2 em outro
            Console.WriteLine(p3 == p2);// true pois as duas variaveis apongam para o mesmo espaço da memoria 


            Console.WriteLine(p1.Equals(p2)); // True pois o metodo equals esta comparando o valor q recebem como parametro
        }
    }
}

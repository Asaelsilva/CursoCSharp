using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class MetodosEstaticos
    {
        public class CalculaoraEstatica
        {

            //Metodo de Classe ou metodo estatico
            public static int Multiplicar(int a, int b)
            {
                return a * b;
            }

            //Metodo de instancia11
            public int Somar(int a, int b)
            {
                return a + b;
            }

        }


        
        public static void Executar()
        {

            var resultado = CalculaoraEstatica.Multiplicar(2, 2);
            Console.WriteLine(CalculaoraEstatica.Multiplicar(2, 2));

            // tendo acesso ao metodo estatico sem instanciar o metodo
            //Console.WriteLine(CalculaoraEstatica.Multiplicar(2, 2));


            //instanciando para ter acesso ao metodo
            CalculaoraEstatica calc = new CalculaoraEstatica();
            Console.WriteLine(calc.Somar(2, 2));
        }
    }
}

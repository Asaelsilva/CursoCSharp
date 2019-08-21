using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class DelegatesComoParametros
    {
        public delegate int Operacao(int x, int y);
        public static int Soma(int x, int y)
        {
            return x + y;
        }
        public static string Calculadora(Operacao op, int x, int y)
        {
            var resultdo = op(x, y);
            return "Resultado: " + resultdo;
        }
        public static void Executar()
        {
            Operacao subtracao = (int x, int y) => x - y;

            Console.WriteLine(Calculadora(subtracao, 5, 8));

            Console.WriteLine(Calculadora(Soma, 5, 8));

        }
    }
}

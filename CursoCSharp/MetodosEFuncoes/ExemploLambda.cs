using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            //Action algoNoConsole = () =>
            //{
            //    Console.WriteLine("1°- Lambda com C#!");
            //};
            //algoNoConsole();

            Action<string> algoNoConsole = (a) =>
            {
                Console.WriteLine("1°- Lambda com C#!" + a);
            };
            algoNoConsole("!!!");

            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };
            Console.Write("2°- ");
            Console.WriteLine(jogarDado());

            Func<int, string> conversorHex = numero => numero.ToString("X");
            Console.Write("3°- ");
            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) => string.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.Write("4°- ");
            Console.WriteLine(formatarData(10,08,2019));
        }
    }
}

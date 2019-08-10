using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415; constante não pode trocar o valor, o C# não aceita e retorna um erro

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A área é " + area);

            //Tipos Internos

            bool estaChovendo = true;
            Console.WriteLine("Esta Chovendo? " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Sbyte e De " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Short e de " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor int é de " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            long menorvalorLong = long.MinValue;
            Console.WriteLine("Menor valor Long " + menorvalorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial " + populacaoMundial);

            float valorFloat = 1299.99f;
            Console.WriteLine("Valor Float " + valorFloat);

            double valorDeMercadoDaApple = 1_000_000_000_000.00;
            Console.WriteLine("Valor Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Valor maximo do Decimal é de " + distanciaEntreEstrelas);

            char letra = 'A';
            Console.WriteLine("Letra " + letra);

            string texto = "Tipo de variavel que suporta texto";
            Console.WriteLine(texto);
        }
    }
}

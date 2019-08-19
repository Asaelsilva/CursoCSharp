using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }
        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
        public int Dividir(int a, int b)
        {
            return a / b;
        }
    }
    class calculadoraCadeia
    {
        int memoria;
        public calculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;
        }
        public calculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }
        public calculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }

        public calculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }
        public int Resultado()
        {
            return memoria;
        }

    }
    class MetodosComRetorno
    {
        public static void Executar()
        {
            CalculadoraComum calculadoraComum = new CalculadoraComum();

            //var resultado = calculadoraComum.Somar(5, 8);
            //var resultado1 = calculadoraComum.Subtrair(6, 3);
            //var resultado2 = calculadoraComum.Multiplicar(2, 5);
            //var resultado3 = calculadoraComum.Dividir(16, 2);

            //Console.WriteLine(resultado);
            //Console.WriteLine(resultado1);
            //Console.WriteLine(resultado2);
            //Console.WriteLine(resultado3);

            var resultado = calculadoraComum.Somar(5, 8);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(5, 2));
            Console.WriteLine(calculadoraComum.Multiplicar(5, 5));
            Console.WriteLine(calculadoraComum.Dividir(30, 2));


            var CalculadoraCadeia = new calculadoraCadeia();
            CalculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().
                Limpar().Imprimir();

            resultado = CalculadoraCadeia.Somar(3).Multiplicar(6).Resultado();
            Console.WriteLine(resultado);

        }
    }
}

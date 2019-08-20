using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OrientacaoAObjetos
{
    interface Teste
    {
        bool Bla(string a);
    }
    interface OperacaoBinaria //: Teste
    {
        int Operacao(int a, int b);
    }

    //====
    class Soma : OperacaoBinaria//, Teste
    {
        public int Operacao(int a, int b)
        {
            return a + b;
        }
        //public bool Bla(string Teste)
        //{
        //    return true;
        //}
    }

    class Subtracao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a - b;
        }
    }

    class Multiplicacao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }
    }

    class Calculadora
    {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>
        {
            new Soma(),
            new Subtracao(),
            new Multiplicacao()
        };

        public string ExecutarOperacoes(int a, int b)
        {
            string resultado = "";

            foreach (var op in operacoes)
            {
                resultado += $"Usuario {op.GetType().Name} = {op.Operacao(a, b)}\n";
            }
            return resultado;
        }
    }
   
    class Interface
    {
        public static void Executar()
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.ExecutarOperacoes(20, 5);
            Console.WriteLine(resultado);
        }
    }
}

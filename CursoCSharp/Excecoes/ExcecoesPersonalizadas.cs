﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes
{
    public class NegativoException : Exception
    {
        public NegativoException() { }
        public NegativoException(string message) : base(message) { }
        public NegativoException(string message, Exception inner) : base (message, inner) { }
    }

    public class ImparExcepption : Exception
    {
        public ImparExcepption(string message) : base(message) { }
    }
    class ExcecoesPersonalizadas
    {
        public static int PositivoPar()
        {
            Random random = new Random();
            int valor = random.Next(-30, 30);

            if (valor < 0)
            {
                throw new NegativoException("Numero negativo... :(");
            }
            if (valor % 2  == 1)
            {
                throw new ImparExcepption("Valor Impar...:(");
            }
            return valor;
        }
        public static void Executar()
        {
            try
            {
                Console.WriteLine(PositivoPar());
            }
            catch (NegativoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ImparExcepption ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes
{

    public class Conta
    {
        private double Saldo;

        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                throw new ArgumentException("Saldo Insuficiente");
            }
        }
    }
    class PrimeiraExcecao
    {
        public static void Executar()
        {
            var conta = new Conta(1_223.45);

            try
            {
                conta.Sacar(1600);
                Console.WriteLine("Saque realizado com Sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Obrigado!");
            }

        }
    }
}

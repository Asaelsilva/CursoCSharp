﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Props
    {
        public class CarroOpcional
        {
            double desconto = 0.1;
            string nome;
            public string Nome
            {
                get
                {
                    return "opcional: " + nome;
                }
                set
                {
                    nome = value;
                }
            }
            //Propriedades autoImplementadas
            public double Preco { get; set; }

            //Propriedades Somente Leitura
            public double PrecoComDesconto
            {
                // get => Preco - (desconto * Preco); // Lambda
                get
                {
                    return Preco - (desconto * Preco);
                }
            }

            public CarroOpcional()
            {
            }

            public CarroOpcional(string nome, double preco)
            {
                Nome = nome;
                Preco = preco;
            }
        }

        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar condicionado", 3499.9);
            Console.WriteLine(op1.PrecoComDesconto);

            //op1.PrecoComDesconto = 3000; impossivel realizar esse comando, a propriedade é somente leitura.
            var op2 = new CarroOpcional();
            op2.Nome = "Direção Eletrica";
            op2.Preco = 2349.9;

            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);

            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.PrecoComDesconto);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Construtores
    {
        class Carro
        {
            public string Modelo;
            public string Fabricante;
            public int Ano;

            public Carro()
            {

            }

            public Carro(string fabricante, string modelo, int ano)
            {
                Modelo = modelo;
                Fabricante = fabricante;
                Ano = ano;
            }
           
        }

        public static void Executar()
        {
            var carro1 = new Carro();

            carro1.Fabricante = "BMW";
            carro1.Modelo = "123";
            carro1.Ano = 2018;

            Console.WriteLine($"{ carro1.Fabricante} { carro1.Modelo} { carro1.Ano}");



            var carro2 = new Carro("Ka", "Ford", 2015);

            Console.WriteLine($"{ carro2.Fabricante} { carro2.Modelo} { carro2.Ano}");

            var carro3 = new Carro()
            {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2015

            };
            Console.WriteLine($"{ carro3.Fabricante} { carro3.Modelo} { carro3.Ano}");

        }
    }
}

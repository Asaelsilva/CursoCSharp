using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OrientacaoAObjetos
{
    public class Animal
    {
        public string Nome { get; set; }

        public Animal(string nome)
        {
            Nome = nome;
        }
    }

    public class Cachorro : Animal
    {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome)
        {
            Console.WriteLine($"cachorro {nome} inicializado");
        }
        public Cachorro(string nome, double altura) : this(nome)
        {
            Altura = altura;
            //Console.WriteLine($"cachorro {nome} inicializado");
        }
        public override string ToString()
        {
            return $"{Nome} tem {Altura}cm de altura";
        }
    }


    class ConstrutorThis
    {
        public static void Executar()
        {
            var spike = new Cachorro("Spike");
            var max = new Cachorro("max", 40.0);

            Console.WriteLine(spike);
            Console.WriteLine(max);



        }
    }
}

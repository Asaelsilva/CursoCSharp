using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp
{
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia };

    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }


    class Enums
    {
        public static void Executar()
        {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Três espiãs";
            filmeParaFamilia.GeneroDoFilme = Genero.Acao;

            Console.WriteLine("{0} é um filme de {1}!", filmeParaFamilia.Titulo, filmeParaFamilia.GeneroDoFilme);
        }
    }
}

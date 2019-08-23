using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Array
    {
        public static void Executar()
        { 

            string[] aluno = new string[5];
            aluno[0] = "Asael";
            aluno[1] = "Lais";
            aluno[2] = "Jhoe";
            aluno[3] = "Jessica";
            aluno[4] = "Bia";

            foreach (var alunos in aluno)
            {
                Console.WriteLine(alunos);
            }
            Console.WriteLine();

            double somatorio = 0;
            double[] notas = { 5.5, 7.7, 8.8, 10.0, 9.4 };
            foreach (var nota in notas)
            {
                somatorio += nota;
            }
            double media = somatorio / notas.Length;
            Console.WriteLine(media);
            Console.WriteLine();

            char[] letra = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letra);
            Console.WriteLine(palavra);

        }
    }
}

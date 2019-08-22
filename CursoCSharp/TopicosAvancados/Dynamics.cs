using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados
{
    class Dynamics
    {
        public static void Executar()
        {
            dynamic meuObjeto = "teste";
            meuObjeto = 3;
            meuObjeto++;

            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Asael João";
            aluno.nota = 10.0;
            aluno.idade = 26;
            Console.WriteLine($"{aluno.nome} tem a nota {aluno.nota} com {aluno.idade} anos.");

        }
    }
}

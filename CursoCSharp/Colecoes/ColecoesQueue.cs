using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("Jonatas");
            fila.Enqueue("Asael");
            fila.Enqueue("Adna");
            fila.Enqueue("Acsa");
            fila.Enqueue("Natanael");
            fila.Enqueue("Sara");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);
            Console.WriteLine(fila.Peek());
            Console.WriteLine();

            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine();
            Console.WriteLine(salada.Contains("item"));
        }
    }
}

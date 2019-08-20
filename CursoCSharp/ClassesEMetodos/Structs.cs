using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp
{

    interface Ponto
    {
        void MoverNaDiagonal(int delta);

    }
    struct Coodernada : Ponto
    {
        public int X;
        public int Y;

        public Coodernada(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void MoverNaDiagonal(int delta)
        {
            X += delta;
            Y += delta;
        }
    }

    class ExemploStructs
    {
        public static void Executar()
        {
            Coodernada coodernadaInicial;
            coodernadaInicial.X = 2;
            coodernadaInicial.Y = 2;

            Console.WriteLine("Coodernada Inicial: ");
            Console.WriteLine("X = {0} ", coodernadaInicial.X);
            Console.WriteLine("Y = {0} ", coodernadaInicial.Y);

            var coordenadaFinal = new Coodernada(x: 9, y: 1);
            coordenadaFinal.MoverNaDiagonal(10);

            Console.WriteLine("Coodernada Final: ");
            Console.WriteLine("X = {0} ", coordenadaFinal.X);
            Console.WriteLine("Y = {0} ", coordenadaFinal.Y);


        }
    }
}

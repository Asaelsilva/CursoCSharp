using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class GetSet
    {
        public class Moto
        {
            private string Marca {get; set; }
            private string Modelo;
            private uint Cilindrada;
            
           public Moto(string marca, string modelo, uint cilindrada)
            {
                //Marca = marca;
                //Modelo = modelo;
                //Cilindrada = cilindrada;
                SetMarca(marca);
                SetModelo(modelo);
                SteCilindrada(cilindrada);

            }

            public Moto()
            {

            }

            public string GetMarca()
            {
                return Marca;
            }

            public void SetMarca(string marca)
            {
                Marca = marca;
            }

            public string GetModelo()
            {
                return Modelo;
            }

            public void SetModelo(string modelo)
            {
                Modelo = modelo;
            }

            public uint GetCilindrada()
            {
                return Cilindrada;
            }

            public void SteCilindrada(uint cilindrada)
            {
                //1° opção
                //if (Cilindrada > 0)
                //{
                //    Cilindrada = cilindrada;
                //}

                //2° opção
                //Cilindrada = Math.Abs(cilindrada); 

                Cilindrada = cilindrada;
            }

        }
        public static void Executar()
        {

            Moto moto1 = new Moto("Kawasaki", "Ninja zr-6r", -633);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            Moto moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SteCilindrada(-150);
            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() + " " + moto2.GetCilindrada());
            



        }
    }
}

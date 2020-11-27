using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class GetSet
    {
        public class Moto
        {
            private string Marca;
            private string Modelo;
            private uint Cilindrada;

            public Moto(string marca, string modelo, uint cilindrada)
            {
                Marca = marca;
                Modelo = modelo;
                Cilindrada = cilindrada;
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

            public void SetCilindrada(uint cilindrada)
            {
                // Para a Cilindrada não retornar números negativos:

                // 1 Opcão
                //if (cilindrada >= 0) {
                //    Cilindrada = cilindrada;
                //} else {
                //    Cilindrada = cilindrada * (-1);
                //}

                // 2 Opcão
                //Cilindrada = Math.Abs(cilindrada);

                // 3 Opcão
                Cilindrada = cilindrada; //para esse método altere-sa o 'int' Cilindrada e 
                                         //e o 'int' cilindrada para 'uint' - linhas 13 e 15
                                         //e nas linhas 47 e 52.
                                         //Dessa forma o valor de entrada não poderá aceitar
                                         //números negativos.
            }
        }

        public static void Executar()
        {
            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            Console.WriteLine("");

            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(150);
            Console.WriteLine(moto2.GetMarca());
            Console.WriteLine(moto2.GetModelo());
            Console.WriteLine(moto2.GetCilindrada());

        }
    }
}

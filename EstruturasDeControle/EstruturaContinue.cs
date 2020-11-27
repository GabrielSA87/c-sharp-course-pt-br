using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaContinue
    {
        public static void Executar()
        {
            //int intervalo = 0;
            Console.Write("Digite o numero máximo: ");            
            int.TryParse(Console.ReadLine(), out int intervalo);
            Console.WriteLine(" ");
            Console.WriteLine("Numeros pares entre 1 e {0}!", intervalo);

            Console.Write("Teste A: ");

            for (int i = 1; i <= intervalo; i++) {
                if (i % 2 == 1) {
                    continue;
                }
                
                Console.Write(i + " ");                
            }
            Console.WriteLine(" ");

            // Uma maneira mais simples de mostrar os numeros pares:
            //Console.Write("Teste B: ");

            //for (int i = 2; i <= intervalo; i += 2) {
                
            //    Console.Write(i + " ");
            //}

            //Console.WriteLine(" ");
            //Console.WriteLine(" ");
        }
    }
}

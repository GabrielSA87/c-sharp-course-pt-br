using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaBreak
    {
        public static void Executar()
        {
            Random numeroRandom = new Random();
            int numero = numeroRandom.Next(1, 51);

            Console.WriteLine("O numero que queremos é: {0}.", numero);
            Console.WriteLine(" ");

            for (int i = 1; i <= 50; i++) {
                Console.Write("{0} é o numero que queremos? ", i);
                if (i == numero) {
                    Console.WriteLine("Sim!");
                    break; // o break está associado ao switch ou a um laco de repeticão
                } else {
                    Console.WriteLine("Não!");
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("Fim!");
        }
    }
}

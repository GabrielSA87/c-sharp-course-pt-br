using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            var palpite = 0;
            Random palpiteInput = new Random();

            var numeroSecreto = palpiteInput.Next(1, 31);
            var numeroEncontrado = false;
            var tentativasRestantes = 5;
            var tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado) {
                Console.Write("Isira o seu palpite: ");
                var entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite) {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write("Número encontrado em {0} tentativas.", tentativas);
                    Console.BackgroundColor = corAnterior;
                } else if (palpite > numeroSecreto) {
                    Console.WriteLine("Menor... tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}.", tentativasRestantes);
                } else {
                    Console.WriteLine("Maior... Tente novamente!");
                    Console.WriteLine("Tentaivas restantes: {0}.", tentativasRestantes);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElse
    {
        public static void Executar()
        {
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            if (nota >= 7.0) {
                Console.WriteLine("Aprovado!");

                if (nota >= 7 && nota <= 8) {
                    Console.WriteLine("Não fez mais que sua obrigacão...");
                } else {
                    Console.WriteLine("Bom trabalho!");
                }
            } else {
                if (nota <= 3) {
                    Console.WriteLine("Reprovado!");
                    Console.WriteLine("Que feio!");
                } else {
                    Console.WriteLine("Recuperacão.");                    
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.Write("Digite a nota do aluno: ");
            var entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            if (nota >= 9.0) {
                Console.WriteLine("Quadro de honra!");
            } else if (nota >= 7.0 && nota < 9.0) {
                Console.WriteLine("Aprovado!");

                // o "else if" corresponde à :
                //    else {
                //      if (nota >= 7.0 && nota < 9.0) {
                //          Console.WriteLine("Aprovado!");
                //      } else {
                //          if()...
                // Porém o código não ficaria bem legível.

            } else if (nota >= 5.0 && nota <= 7.00) {
                Console.WriteLine("Recuperacão!");
            } else {
                Console.WriteLine("Te vejo na próxima...");
            }

            Console.WriteLine("Fim!!!");
        }
    }
}

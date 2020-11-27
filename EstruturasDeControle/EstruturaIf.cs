using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            Console.Write("Possui bom comportamento (S/N)? ");
            entrada = Console.ReadLine();

            bomComportamento = entrada.ToLower() == "s";
            // esse "IF" poderia ser escrito :
            // if (entrada == "S" || entrada == "s")
            //     bomComportamento = true;
            // ou :
            // bomComportamento = entrada == "S" || entrada == "s";

            if (nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de Honra!");
            }
        }
    }
}

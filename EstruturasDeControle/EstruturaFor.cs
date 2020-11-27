using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaFor
    {
        public static void Executar()
        {
            /*
            var i = 1;
            while(i <= 10) {
                Console.WriteLine($"O valor de i eh {i}.");
                i++;
            
            // O WHILE acima pode ser substituido por um FOR

            for (var i = 1; i <= 10; i++) {
                Console.WriteLine($"O valor de 'i' eh {i}.");
            }
            
            ---> O 'for' sendo usado para uma quantidade determinada de repetcões
            ---> O 'while'sendo usado para uma quantidade indeterminada de repetcões

            */

            double somatorio = 0;
            string entrada;

            Console.Write("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for(int i = 1; i <= tamanhoTurma; i++) {
                Console.Write("Informe a nota do aluno {0}: ", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAzul);

                somatorio += notaAzul;
            }

            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine("Media da turma: {0}", media.ToString("#.##"));
        }
    }
}

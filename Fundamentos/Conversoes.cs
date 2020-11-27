using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro; //conversao implicita
            Console.WriteLine(quebrado);

            Console.WriteLine("---------------------");

            double nota = 9.7;
            int notaTruncada = (int) nota; //converte EXPLICITAMENTE o valor 'nota' em inteiro (int).
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            Console.WriteLine("---------------------");

            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            Console.WriteLine("---------------------");

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            Console.WriteLine("---------------------");

            // Forma mais 'segura' para converter string para inteiro

            Console.Write("Digite o primeiro numero: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine("O resultado A é: {0}.", numero1);
            Console.WriteLine("");
            Console.Write("Digite o segundo numero: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("O resultado B é: {0}.", numero2);
        }
    }
}

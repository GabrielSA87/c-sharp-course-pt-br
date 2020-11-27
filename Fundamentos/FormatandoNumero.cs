using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("#.##")); //outra forma do "F1" que seria o "F2"
            Console.WriteLine("------------------------------------");
            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C2", cultura));
            Console.WriteLine("------------------------------------");
            int inteiro = 00000000000256; // não aparace os 0 na esquerda
            Console.WriteLine(inteiro.ToString("D4")); // para aparecer os 0 usa-se o D#

        }
    }
}

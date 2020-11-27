using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritimeticos
    {
        public static void Executar()
        {
            // Preco Desconto
            var preco = 1000;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalDesconto = total - (total * desconto);

            Console.WriteLine("O preco final é {0}.", totalDesconto);


            // IMC
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2); //math.pow(var, #) = var*var, onde # é a potência. Nesse exemplo altura*altura
            Console.WriteLine($"O IMC é: {imc}.");


            // Numero Par/Impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);

        }
    }
}

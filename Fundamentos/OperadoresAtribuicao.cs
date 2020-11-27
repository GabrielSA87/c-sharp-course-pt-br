using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 = 7;   // substituiu o valor de num1 de 3 para 7
            num1 += 10; // num1 = num1 + 10
            num1 -= 3;  // num1 = num1 - 3
            num1 *= 5;  // num1 = num1 * 5
            num1 /= 2;  // num1 = num1 / 2

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            a++; // a = a + 1
            b--; // b = b - 1

            Console.WriteLine($"{a} {b}");


            //Não se preocupar com o código a seguir por enquanto!
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;
            d.nome = "Maria";

            Console.WriteLine(c.nome);

        }
    }
}

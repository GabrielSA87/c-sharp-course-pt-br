using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            // PS: Todo 'Action' é uma funcão void (Não tem retorno) 
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Lambda com C#!");
            };

            algoNoConsole();

            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7); //lembrando que retornará o valor de 1 à 6
            };

            Console.WriteLine(jogarDado());

            Func<int, string> conversorHex = numero => numero.ToString("X"); //nesse caso 'numero.ToString("X");' está implicto o return.

            // A Func acima é a mesma coisa de:

            //Func<int, string> conversorHex = (numero) =>
            //{
            //    return numero.ToString("X");
            //};

            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
                String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatarData(20, 1, 2020));
        }
    }
}

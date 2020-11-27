using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var nome = "Gabriel";
            // nome = 123; --> na inferencia acima a var foi atribuida como sendo uma string, logo nao podemos altera-la para outro tipo, ex aqui um int
            Console.WriteLine(nome);

            // var idade; --> aqui está um erro, pois nao podemos declarar uma var sem atribuir um valor a ela em uma inferencia
            // nesse caso poderia usar:
            /* 
             * int idade;
             * idade = 33;
             */
            var idade = 33; // o modo mais simples.
            Console.WriteLine(idade);

            int a; // declaracao de uma var
            a = 1; // atribuindo um valor a var declarada acima
            int b = 2; // declaracao de uma var e inicializar (dar uma valor inicial) a var
            Console.WriteLine(a + b);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados
{
    class Nullables
    {
        public static void Executar()
        {
            
            // Dois modos para criar uma variável nula:
            Nullable<int> num1 = null;
            int? num2 = null;

            if(num1.HasValue)
            {
                Console.WriteLine("Valor de num1: " + num1);
            }
            else
            {
                Console.WriteLine("A variável não possui valor!\n");
            }

            int valor = num1 ?? 1000;

            Console.WriteLine(valor + "\n");

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();
            Console.WriteLine($"Valor padrão de um boolean: {resultado} \n");

            try
            {
                int x = num1.GetValueOrDefault();
                int y = num2.GetValueOrDefault();
                //int y = num1.Value; //Ao tentar pegar o Value diretamente retornará um erro, caindo no catch abaixo.
                //int y = num2.Value;
                Console.WriteLine(x + y);
            }catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}\n");
            }
        }
    }
}

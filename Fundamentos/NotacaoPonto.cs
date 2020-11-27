using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "olá".ToUpper().Insert(3, " World!")
                .Replace("World!", "Mundo!");
            Console.WriteLine(saudacao);

            // usando a notacao '.' apos a "variavel/constante" e 'ctrl+space' abre as funcionalidades para a mesma
            // ex.: "teste".lenght - retornará o 'lenght' para a string "teste"
            Console.WriteLine("teste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante);


            // como o valorImportante é nulo se chamarmos o lenght dele retornara um erro
            // como no exemplo abaixo:
            /*
             * string valorImportante = null;
             * Console.WriteLine(valorImportante.Length);
             * 
             * 
             * Para ele funcionar poderiamos utilizar o '?'
             * 
             * string valorImportante = null;
             * Console.WriteLine(valorImportante?.Length);
             * 
             * O '?' faz com que o 'lenght' só seja acessado se o valorImportatante esteja definida
             * Isso se chama de 'Navegacão Segura'
            */


        }
    }
}

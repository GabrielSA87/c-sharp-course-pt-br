using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    /// <summary>
    /// Esse é o XML Comments '///' - Ex.: Cria um sumario para parametros com alguns tags, criando documentacoes...
    /// </summary>
    class Comentarios
    {
        public static void Executar()
        {
            
            Console.WriteLine("Código claro é sempre melhor!");

            Console.WriteLine("O C# tem o XML Comments");

            // Esse é um comentário de linha unica.
            // Usado para comentar detalhes no codigo.

            //-----------------------------------------------------------------------------------------

            /* Esse é um comentário
             * de multiplas linhas
             * abrindo com   /*
             * e terminando com  * /
            */

            //-----------------------------------------------------------------------------------------

            //Selecionando as linhas de codigo podemos comentar com Ctrl+K + Ctrl+C para comenta-las
            // e Ctrl+K + Ctrl+U para descomentar.

            //Console.WriteLine("Selecionando linhas para comenta-las");
            //Console.WriteLine("E depois remover o comentario para voltar a utilizar o codigo");

            //-----------------------------------------------------------------------------------------

        }
    }
}
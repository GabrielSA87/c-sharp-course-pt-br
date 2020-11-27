using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        int a = 10;
        
        public static void Executar()
        {
            //Desafio: Acessar a variável 'a' dentro do método Executar!
            //Não pode alterar a linha 9!!!

            //Console.WriteLine(a); //Não funcionará, teria que alterar a linha 9 para static

            DesafioAtributo desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);

            // OBS: Estando dentro de um metodo estático (linha 11), tentando acessar
            // um atributo que pertence à estância. Como o atributo pertence à estância
            // precisa-se criar uma estância (linha 18 - 'new DesafioAtributo()') e atribuir
            // à uma variável (linha 18 - 'desafio'), então acessar (linha 19) o atributo 
            // a partir da estância usando a notacão '.'
        }
    }
}

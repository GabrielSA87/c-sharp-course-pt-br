using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "'Notebook Gamer'";
            string marca = "'Dell'";
            double preco = 5800.00;

            Console.WriteLine("O " + nome + " da marca " + marca + " custa R$" + preco + ".");
            //pode tambem ser escritos das seguintes formas:
            Console.WriteLine("O {0} da marca {1} custa R${2}.", nome, marca, preco);
            Console.WriteLine($"O {nome}" + $" da marca {marca}" + $" custa R${preco}.");
        }
    }
}

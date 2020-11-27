using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        // atributos
        public string Nome;
        public int Idade;

        // comportamentos (metodos)
        public string Apresentar() // ESSE METODO É MELHOR POIS NÃO É AMARRADO, PODENDO RETORNAR DIVERSAS INFORMACÕES.
        {
            return string.Format($"Olá, me chamo {Nome} e tenho {Idade} anos.");
        }

        public void ApresentarNoConsole() // ESSE METODO EH MUITO MAIS AMARRADO.
        {
            Console.WriteLine(Apresentar());
        }

        public void zerar() //mesmo nao recebendo e retornando NADA, faz algo útil.
        {
            Nome = "";
            Idade = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 9;
            bool bomComportamento = true;
            var resultado = nota >= 7 && bomComportamento? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}

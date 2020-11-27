using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        // Todos
        public string InfoPublica = "Tenho um instagram!";

        // Heranca
        protected string CorDosOlhos = "Verde";

        // Mesmo Projeto (Assembly)
        internal ulong NumeroCelular = 5581998877665;

        // Heranca ou Mesmo Projeto (Assembly)
        protected internal string JeitoDeFalar = "Uso muitas girias.";

        // Mesma Classe ou Heranca no Mesmo Projeto (C# >= 7.2)
        private protected string SegredoFamilia = "Bla bla";

        // Private, é o Valor Padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridade...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}

using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesArrayList
    {
        public static void Executar()
        {
            var arraylist = new System.Collections.ArrayList
            {
                "Palavra",
                3,
                true
            };

            arraylist.Add(3.14);

            foreach (var item in arraylist) {
                Console.WriteLine("{0} => {1}", item, item.GetType());
            }
        }
    }
}

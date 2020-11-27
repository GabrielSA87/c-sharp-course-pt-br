using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2;

            Console.WriteLine(p1 == p2);
            Console.WriteLine(p3 == p2);
            
            Console.WriteLine(p1.Equals(p2)); // mesma comparacão de endereco de memoria
                                              // que a ==. Para ser feita a comparacão
                                              // rotornar TRUE, fez-se alteracões na
                                              // class Produto (linha 18 à 23) em 
                                              // ColecoesList.cs.
        } // OBS.: Muito importante usar o GetHashCode junto do Equals, pois a partir desse
          // metodo quando colocar elementos dentro de  colecões que usem Hash, as buscas e 
          // definicÕes de igualdade irão funcionar de forma correta.
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraEstatica
    {
        //Método de Classe ou Método Estático!!!
        public static int Multiplicar(int a, int b) //"static" faz o metodo nao pertencer mais ao objeto (instância) e sim a classe
        {
            return a * b;
        }

        //Método de Objeto ou Método de Instância!!!
        public int Somar(int a, int b) 
        {
            return a + b;
        }
    }
    
    class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2); //como o metodo é static (linha 10), pode ser acessivel a partir da classe
            Console.WriteLine("Resultado: {0}.", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica(); //como o metodo nao é static (linha 15), so pode ser acessivel a partir da instância.
            Console.WriteLine(calc.Somar(2,2));
        }
    }
}

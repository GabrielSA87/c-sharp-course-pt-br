using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraComum
    {
        public int Somar(int a, int b) // a assinatura, Nome(parametros) = "Somar(int a, int b)", de um metodo é única em uma mesma classe
        {
            return a + b;
        }
        
        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Dividir(int a, int b)
        {
            return a / b;
        }
    }

    class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;
        }
        
        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }
        
        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado()
        {
            return memoria;
        }
    }
    
    class MetodosComRetorno
    {
        public static void Executar() //dentro de Executar vou instanciar um objeto
                                      //do tipo CalculadoraComum, armazenar com um
                                      //new CalculadoraComum, armazenar em uma var
                                      //e apartir dessa var consigo chamar os metodos
                                      // Somar, Subtrair, Multiplicar e Dividir
        {
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(5, 5);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(2,7));
            Console.WriteLine(calculadoraComum.Multiplicar(4, 4));
            Console.WriteLine(calculadoraComum.Dividir(10, 3));

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();

            resultado = calculadoraCadeia.Somar(3).Multiplicar(2).Resultado();
            Console.WriteLine(resultado);

        }
    }
}

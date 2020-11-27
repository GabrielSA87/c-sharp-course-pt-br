using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        double desconto = 0.1;
        
        string nome;
        public string Nome
        {
            get
            {
                return "Opcional: " + nome;
            }

            set
            {
                nome = value;
            }
        }

        // Propriedade autoimplementada
        public double Preco { get; set; }

        // Propriedade somente leitura
        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco); // Lambda
            //poderiamos escrever:
            //get {
            //    return Preco - (desconto * Preco);
            //}
        }

        public CarroOpcional()
        {

        }

        public CarroOpcional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
    
    class Props
    {
        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar condicionado ", 3499.9);
            Console.WriteLine("Preco com desconto no Opcional 1: " + op1.PrecoComDesconto);

            var op2 = new CarroOpcional();
            op2.Nome = "Direcão Elétrica";
            op2.Preco = 2349.9;
            Console.WriteLine("--");
            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);
            Console.WriteLine("----");
            Console.WriteLine(op2.Nome);
            Console.WriteLine("Preco: " + op2.Preco);
            Console.WriteLine("Preco com desconto: " + op2.PrecoComDesconto);
        }
    }
}

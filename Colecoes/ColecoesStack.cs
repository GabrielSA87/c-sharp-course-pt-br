using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach (var item in pilha) {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nPop: " + pilha.Pop());

            foreach (var item in pilha) {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n"); // "\n" é a mesma coisa que " ". Com WriteLine deixa a 
                                     // linha em branco.

            Console.WriteLine("Peek: " + pilha.Peek());
            Console.WriteLine(pilha.Count);
        }
    }
}

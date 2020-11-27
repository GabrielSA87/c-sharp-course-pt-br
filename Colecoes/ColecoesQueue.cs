using System;
using System.Collections.Generic;
using System.Collections;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>(); //ao colocar 'string' amarra-se os elementos 
                                            //para serem do tipo 'string'.
            fila.Enqueue("Fulano"); // 'Enqueue' adiciona um item na fila.
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine("Pessoas na fila: ");
            foreach (var pessoa in fila) {
                Console.WriteLine("- " + pessoa);
            }
            
            Console.WriteLine(" ");

            Console.WriteLine("Olhada - Peek");
            Console.WriteLine("Primeiro da fila: " + fila.Peek()); // 'Peek' pega-se o primeiro da fila sem remove-lo
            Console.WriteLine("Total: " + fila.Count);

            Console.WriteLine(" ");

            Console.WriteLine("Desenfileirar - Dequeue");
            Console.WriteLine("Primeiro da fila: " + fila.Dequeue()); // 'Dequeue' remove o primeiro da fila.
            Console.WriteLine("Total: " + fila.Count);

            Console.WriteLine(" ");

            Console.WriteLine("Restante após o Dequeue:");
            foreach (var pessoa in fila) {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(" ");

            Console.WriteLine(salada.Contains("item"));
            Console.WriteLine(salada.Contains("Item"));
        }
    }
}

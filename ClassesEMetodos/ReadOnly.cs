using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Cliente
    {
        public string Nome;
        readonly DateTime Nascimento; // 'readonly' seta o valor, imutável,
                                      // diretamente no construtor.

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento()
        {
            return String.Format("{0:D2}/{1:D2}/{2}", Nascimento.Day, Nascimento.Month,
                Nascimento.Year);
        }
    }
    
    class ReadOnly
    {
        public static void Executar()
        {
            var novoCliente = new Cliente("Gabriel Araujo", new DateTime(1987, 1, 20));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());
        }
    }
}

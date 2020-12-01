using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Api
{
    class ExemploDateTime
    {
        public static void Executar()
        {
            var dateTime = new DateTime(year: 2000, month: 2, day: 6);

            Console.WriteLine(dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year);

            //Sem Horas
            var hoje = DateTime.Today;
            Console.WriteLine("\n=== Hoje S/ Horas ===\n" + hoje);

            //Com Horas
            var diaAtual = DateTime.Now;
            Console.WriteLine("\n=== Atual C/ Horas ===\n" + diaAtual);
            Console.WriteLine("\nHora: " + diaAtual.Hour);
            Console.WriteLine("Minuto: " + diaAtual.Minute);
            Console.WriteLine("Segundo: " + diaAtual.Second);

            var amanha = diaAtual.AddDays(+1);
            Console.WriteLine("\nAmanhã: " + amanha);

            var ontem = diaAtual.AddDays(-1);
            Console.WriteLine("\nOntem: " + ontem);

            Console.WriteLine(diaAtual.ToString("\ndd"));
            Console.WriteLine(diaAtual.ToString("d"));
            Console.WriteLine(diaAtual.ToString("D"));
            Console.WriteLine(diaAtual.ToString("g"));
            Console.WriteLine(diaAtual.ToString("G"));
            Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH:mm:ss"));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro
    {
        public string Modelo; // atributos da classe (Modelo, Fabricante e Ano)
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano) //parametros (modelo, fabricante e ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        public Carro()
        {

        }
    }
    
    class Construtores
    {
        public static void Executar()
        {
            var Carro1 = new Carro(); // construtor PADRÃO, nao foi feito dentro de Carro
            Carro1.Fabricante = "BMW";
            Carro1.Modelo = "325i";
            Carro1.Ano = 2017;

            Console.WriteLine($"O carro da marca {Carro1.Fabricante} e modelo " +
                $"{Carro1.Modelo} e ano {Carro1.Ano} foi vendido.");

            var Carro2 = new Carro("Ka", "Ford", 2018);
            Console.WriteLine($"{Carro2.Fabricante} {Carro2.Modelo} {Carro2.Ano}");

            var Carro3 = new Carro()
            {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2019
            };

            Console.WriteLine($"{Carro3.Fabricante} {Carro3.Modelo} {Carro3.Ano}");
        }
    }
}

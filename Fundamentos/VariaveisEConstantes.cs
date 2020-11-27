using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // var => 'tipo variavel' + 'identificador (nome)' + 'simbolo de atribuicao (=, >=, <=...)' + 'valor'
            
            // area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415;

            double area = PI * raio * raio; // 'double' tem o dobro do 'float'
            Console.WriteLine(area);
            Console.WriteLine("A área é: " + area);

            Console.WriteLine("------------------------------------------------------------------");

            // Tipos Internos

            bool estaChovendo = true; //--> boolean
            Console.WriteLine("boolean = Ex.: Está chovendo: " + estaChovendo);

            // byte = 1 byte (8 bits), short = 2 bytes, int = 4 bytes, long = 8 bytes
            byte idade = 45;
            Console.WriteLine("byte = Ex.: Idade: " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("sbyte = Ex.: O saldo de gols: " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("short = Ex.: Salario: " + salario);

            int menorValorInt = int.MinValue; // int = Mais usado dos inteiros!
            Console.WriteLine("int = Ex.: O menor 'int' é: " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("uint = Ex.: Populacao Brasileira é: " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("long = Ex.: O menor valor do 'long' é: " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("ulong = Ex.: A populacao mundial é: " + populacaoMundial);

            // Pontos flutuantes (valores reais):

            float precoComputador = 1299.99f; // se coloca o 'f' apos o numero para passar de double para float
            Console.WriteLine("float = Ex.: Preco do Computador é: " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; // mais usado por ter o dobro do float
            Console.WriteLine("double = Ex.: O valor de Mercado da Aplle é: " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue; // numeros 'gigantes'
            Console.WriteLine("decimal = Ex.: Distancia entre as estrelas é: " + distanciaEntreEstrelas);

            char letra = 'b'; // char limita-se a uma unica letra (character), mais de uma letra usa-se uma string entre "" 
            Console.WriteLine("char = Ex.: Letra: " + letra);

            string texto = "Sejam bem vindos!";
            Console.WriteLine("string = Ex.: " + texto);
        }
    }
}

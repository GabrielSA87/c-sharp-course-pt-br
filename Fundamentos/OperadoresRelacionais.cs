using System;


namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            //double nota = 6.0;
            Console.Write("Digite a nota do aluno: ");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDeCorte = 7.0;

            Console.WriteLine("Nota inválida maior que 10? {0}", nota > 10.0);
            Console.WriteLine("Nota inválida menos que 0? {0}", nota < 0.0);
            Console.WriteLine("Perfeito? {0}", nota == 10.0);
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);
            Console.WriteLine("Passou por média? {0}", nota >= notaDeCorte);
            Console.WriteLine("Recuperacão? {0}", nota < notaDeCorte);
            Console.WriteLine("Reporvado? {0}", nota <= 3.0);
        }
    }
}

using System;
using System.IO;

namespace CursoCSharp.Api
{
    class Diretorios
    {
        public static void Executar()
        {
            var novoDiretorio = @"~/PastaCSharp".ParseHome();
            var novoDiretorioDestino = @"~/PastaCSharpDestino".ParseHome();
            var dirProjeto = @"~/source/repos/CursoCSharp/CursoCSharp".ParseHome();

            if(Directory.Exists(novoDiretorio))
            {
                Directory.Delete(novoDiretorio, true);
            }

            if(Directory.Exists(novoDiretorioDestino))
            {
                Directory.Delete(novoDiretorioDestino, true);
            }

            Directory.CreateDirectory(novoDiretorio);
            Console.WriteLine(Directory.GetCreationTime(novoDiretorio));

            Console.WriteLine("=== Pastas ===");
            var pastas = Directory.GetDirectories(dirProjeto);

            foreach(var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n\n=== Arquivos ===");
            var arquivos = Directory.GetFiles(dirProjeto);

            foreach(var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n\n=== Raiz ===");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDiretorio));

            Directory.Move(novoDiretorio, novoDiretorioDestino);
        }
    }
}

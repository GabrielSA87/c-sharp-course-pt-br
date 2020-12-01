using System;
using System.IO;

namespace CursoCSharp.Api
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }

    class PrimeiroArquivo
    {     
        public static void Executar()
        {
            //Sem o @ antes da string:

            //var s = "\teste\nameteste\a.txt";
            //Console.WriteLine(s + "\n");

            var path = @"~/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write("Esse é ");
                    sw.Write("o nosso ");
                    sw.Write("primeiro ");
                    sw.Write("arquivo!\n");
                    sw.Write("\nObrigado!");                    
                }
            }

            using (StreamWriter sw = File.AppendText(path))
            {                
                sw.Write("\n");
                sw.Write("\nÉ possível ");
                sw.Write("adicionar ");
                sw.Write("mais texto!");
            }
        }
    }
}

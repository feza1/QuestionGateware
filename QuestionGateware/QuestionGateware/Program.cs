using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuestionGateware
{
    class Program
    {
        static void Main(string[] args)
        {
            //questão numero 1 - Em C#, encontre o maior numero inteiro em um array. (Digite o endereço do Clone with HTTPS)
            int[] array1 = { 2, 5, 8, 10, 2, 23, 2, 4, 5, 8, 8 };
            int maior = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1.Length > maior)
                {
                    maior = array1[i];
                }

            }

            Console.WriteLine("Maior numero do array -> " + maior);


            //2 - Em C#, me passe a lista de arquivos texto em um diretório específico quem possuem em seu 
            //conteúdo números de telefone em um formato específico. (Digite o endereço do Clone with HTTPS)


            string[] _diretorios = Directory.GetDirectories(@"C:\Arquivos\");
            Console.WriteLine("LSITA DE DIRETÓRIOS: ");
            Console.WriteLine("");

            Regex rgx = new Regex("\\(..\\)[0-9]{3,5}-[0-9]{4}");

            foreach (string dir in _diretorios)
            {
                Console.WriteLine(dir);

                string[] arrArquivos = Directory.GetFiles(dir, "*.txt");

                for (int x = 0; x < arrArquivos.Length; x++)
                {
                    if (File.Exists(arrArquivos[x]))
                    {
                        using (StreamReader sr = new StreamReader(arrArquivos[x]))
                        {
                            var total = rgx.Matches(sr.ToString()).Count;
                            if (total > 0)
                            {
                                Console.WriteLine("Tem telefones");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(" O arquivo " + arrArquivos[x] + "não foi localizado !");
                    }

                    Console.WriteLine("");
                }
            }
            Console.ReadKey();


            //(3)Em C#, Dentro do “C:” crie uma pasta dinamicamente e copie
            //imagens de um determinado diretório para este, aplique TDD para executar os testes.

            string Propiretariopath = @"C:\arquivosImagens";
            string Destinopath = @"C:\arquivosImagens/test";

            if (!Directory.Exists(Propiretariopath))
            {
                Directory.CreateDirectory(Propiretariopath);
            }

            Directory.Move(Propiretariopath, Destinopath);





        }

    }
}

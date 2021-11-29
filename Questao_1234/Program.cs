using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_1234
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();

            while (frase != null)
            {
                transformarSentencaDnacante(frase);
                frase = Console.ReadLine();
            }
        }

        static void transformarSentencaDnacante(string frase)
        {
            bool upperCase = false;

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i].ToString() != " ")
                {
                    if (upperCase)
                    {
                        Console.Write(frase[i].ToString().ToLower());
                        upperCase = false;
                    } else
                    {
                        Console.Write(frase[i].ToString().ToUpper());
                        upperCase = true;
                    }
                } else
                {
                    Console.Write(frase[i]);
                }
            }
            Console.WriteLine();
        }
    }
}

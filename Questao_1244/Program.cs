using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_1244
{
    class Program
    {
        public static string[] frase;
        public static int[] indexFraseOrdenada;

        static void Main(string[] args)
        {
            int quantidadeTestes = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidadeTestes; i++)
            {
                frase = (Console.ReadLine().Trim()).Split(' ');

                indexFraseOrdenada = new int[frase.Length];
                ColocarNaOrdem();
                PrintFrase();
            }
            Console.ReadLine();
        }

        static void PrintFrase()
        {
            for(int i = 0; i < frase.Length; i++)
            {
                if (i != frase.Length)
                {
                    Console.Write(frase[i] + " ");
                } else
                {
                    Console.Write(frase[i]);
                }
            }
            Console.WriteLine();
        }

        static void ColocarNaOrdem()
        {
            for (int i = 0; i < frase.Length; i++)
            {
                indexFraseOrdenada[i] = frase[i].Length;
            }
            OrdenarFrase();
        }

        // Insertion Sort
        static void OrdenarFrase()
        {
            for (var i = 1; i < indexFraseOrdenada.Length; i++)
            {
                var aux = indexFraseOrdenada[i];
                var auxFrase = frase[i];
                var j = i - 1;

                while (j >= 0 && indexFraseOrdenada[j] < aux)
                {
                    indexFraseOrdenada[j + 1] = indexFraseOrdenada[j];
                    frase[j + 1] = frase[j];
                    j -= 1;
                }
                indexFraseOrdenada[j + 1] = aux;
                frase[j + 1] = auxFrase;
            }
        }
    }
}

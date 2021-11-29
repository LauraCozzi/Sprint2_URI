using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_1259
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeEntradas = int.Parse(Console.ReadLine());
            int numero;
            List<int> pares = new List<int>();
            List<int> impares = new List<int>();

            for (int i = 0; i < quantidadeEntradas; i++)
            {
                numero = int.Parse(Console.ReadLine());
                if (numero % 2 == 0) pares.Add(numero);
                else impares.Add(numero);
            }

            int[] numerosPares = pares.ToArray();
            int[] numerosImpares = impares.ToArray();

            numerosPares = Quicksort(numerosPares);
            numerosImpares = Quicksort(numerosImpares);

            PrintArrayPares(numerosPares);
            PrintArrayImpares(numerosImpares);

            Console.ReadLine();
        }

        static void PrintArrayPares(int [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        static void PrintArrayImpares(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }

        static void Swap(int i, int j, int[] lista)
        {
            int temp = lista[i];
            lista[i] = lista[j];
            lista[j] = temp;
        }

        static int[] QuicksortRec(int esq, int dir, int[] lista)
        {
            int i = esq, j = dir;
            int pivo = lista[(dir + esq) / 2];

            while (i <= j)
            {
                while (lista[i] < pivo) i++;
                while (lista[j] > pivo) j--;
                if (i <= j)
                {
                    Swap(i, j, lista);
                    i++;
                    j--;
                }
            }

            if (esq < j) QuicksortRec(esq, j, lista);
            if (i < dir) QuicksortRec(i, dir, lista);

            return lista;
        }

        static int[] Quicksort(int[] lista)
        {
            lista = QuicksortRec(0, lista.Length - 1, lista);
            return lista;
        }
    }
}

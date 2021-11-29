using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_1251
{
    class Program
    {
        public static int[] frequencia = new int[128];
        static void Main(string[] args)
        {
            string entrada = Console.ReadLine();

            while (entrada != null)
            {
                inicializaFrequencia();
                ContarFrequencia(entrada);
                OrganizaListas();
                entrada = Console.ReadLine();
                if(entrada != null) Console.WriteLine();
            }
        }

        static void OrdenaFrequencia(int[] elementos, int [] frequenciaElementos, int quantidade)
        {
            for (var i = 1; i < elementos.Length; i++)
            {
                var aux = elementos[i];
                var auxF = frequenciaElementos[i];
                var j = i - 1;

                while (j >= 0 && frequenciaElementos[j] >= auxF)
                {
                    if (frequenciaElementos[j] != auxF)
                    {
                        elementos[j + 1] = elementos[j];
                        frequenciaElementos[j + 1] = frequenciaElementos[j];
                        j -= 1;
                    } else
                    {
                        // verifica qual char é menor
                        if (elementos[j] < aux)
                        {
                            elementos[j + 1] = elementos[j];
                            frequenciaElementos[j + 1] = frequenciaElementos[j];
                            j -= 1;
                        } else
                        {
                            j--;
                        }
                    }
                }
                elementos[j + 1] = aux;
                frequenciaElementos[j + 1] = auxF;
            }

            PrintFrequencia(elementos, frequenciaElementos);
        }

        static void inicializaFrequencia()
        {
            for (int i = 0; i < frequencia.Length; i++)
            {
                frequencia[i] = 0;
            }
        }

        static void OrganizaListas()
        {
            int quantidadeElementos = 0;

            for (int i = 0; i < frequencia.Length; i++)
            {
                if (frequencia[i] != 0)
                {
                    quantidadeElementos++;
                }
            }

            int[] elementosOrdenados = new int[quantidadeElementos];
            int[] frequenciaElementosOrdenados = new int[quantidadeElementos];
            int index = 0;

            for (int i = 0; i < frequencia.Length; i++)
            {
                if (frequencia[i] != 0)
                {
                    elementosOrdenados[index] = i;
                    frequenciaElementosOrdenados[index] = frequencia[i];
                    index++;
                }
            }

            OrdenaFrequencia(elementosOrdenados, frequenciaElementosOrdenados, quantidadeElementos);

        }

        static void PrintFrequencia(int[] elementos, int[] frequenciaElementos)
        {

            for (int i = 0; i < elementos.Length; i++)
            {
                Console.WriteLine(elementos[i] + " " + frequenciaElementos[i]);
            }
        }

        static void ContarFrequencia(string entrada)
        {
            char[] entradas = entrada.ToCharArray();
            int index = 0;

            foreach (char character in entradas)
            {
                index = character;
                frequencia[index]++; 
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_1507
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeTestes; 
            int quantidadeQueries; 
            string palavraBase; 
            string casos_queries; 

            quantidadeTestes = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidadeTestes; i++)
            {
                palavraBase = Console.ReadLine();
                quantidadeQueries = int.Parse(Console.ReadLine());

                for (int j = 0; j < quantidadeQueries; j++)
                {
                    casos_queries = Console.ReadLine();
                    if (EhSubsequencia(palavraBase, casos_queries)) Console.WriteLine("Yes");
                    else Console.WriteLine("No");
                }
            }
            Console.ReadLine();
        }

        static bool EhSubsequencia(string palavraBase, string caso)
        {
            bool subsequencia = false;
            int posCaso = 0;
            int pospalavraBase = 0;

            while (pospalavraBase < palavraBase.Length)
            {
                if (caso[posCaso] == palavraBase[pospalavraBase])
                {
                    posCaso++; pospalavraBase++;
                }
                else
                {
                    pospalavraBase++;
                }

                if (posCaso == caso.Length)
                {
                    subsequencia = true;
                    pospalavraBase = palavraBase.Length;
                }
            }

            return subsequencia;
        }
    }
}

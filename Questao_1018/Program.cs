using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_1018
{
    class Program
    {
        public static int [] notas = { 100, 50, 20, 10, 5, 2, 1 };
        public static CultureInfo cultura = new CultureInfo("pt-BR");

        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());
            quantidade_notas(valor);

            Console.ReadLine();
        }

        static void quantidade_notas(int valor_monetario)
        {
            int quantidade;
            Console.WriteLine(valor_monetario);

            for (int i = 0; i < 7; i++)
            {
                quantidade = valor_monetario / notas[i];
                valor_monetario -= (notas[i] * quantidade);

                Console.WriteLine(quantidade + " nota(s) de R$ " +notas[i].ToString("N2", cultura));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_1021
{
    class Program
    {
        public static double[] notas = { 100, 50, 20, 10, 5, 2 };
        public static double[] moedas = { 1, 0.5, 0.25, 0.1, 0.05, 0.01 };
        public static CultureInfo cultura = new CultureInfo("en-US");

        static void Main(string[] args)
        {
            double valor = double.Parse(Console.ReadLine(), cultura);
            quantidade_notas(valor);

            Console.ReadLine();
        }

        static void quantidade_notas(double valor_monetario)
        {
            int quantidade;

            Console.WriteLine("NOTAS:");

            for (int i = 0; i < 6; i++)
            {
                quantidade = (int)(valor_monetario / notas[i]);
                valor_monetario -= (notas[i] * quantidade);

                Console.WriteLine(quantidade + " nota(s) de R$ " + notas[i].ToString("N2", cultura));
            }

            quantidade = 0;
            valor_monetario = (double)Math.Round(valor_monetario, 2);

            Console.WriteLine("MOEDAS:");

            for (int i = 0; i < 6; i++)
            {
                quantidade = (int)(valor_monetario / moedas[i]);
                valor_monetario -= (moedas[i] * quantidade);
                valor_monetario = (double)Math.Round(valor_monetario, 2);

                Console.WriteLine(quantidade + " moeda(s) de R$ " + moedas[i].ToString("N2", cultura));
            }
        }
    }
}

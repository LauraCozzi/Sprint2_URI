using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, valor3, maior;
            string valores = Console.ReadLine();

            valor1 = int.Parse(valores.Split(' ')[0]);
            valor2 = int.Parse(valores.Split(' ')[1]);
            valor3 = int.Parse(valores.Split(' ')[2]);

            maior = Maior(Maior(valor1, valor2), valor3);
            Console.WriteLine(maior + " eh o maior");

            Console.ReadLine();
        }

        static int Maior(int valor1, int valor2)
        {
            return (valor1 + valor2 + Math.Abs(valor1 - valor2)) / 2;
        }
    }
}

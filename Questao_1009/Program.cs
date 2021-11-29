using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = null;
            double salario = 0;
            double totalVendas = 0;
            double comissao = 0.15;
            double valorReceber = 0;

            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valorReceber = salario + totalVendas * comissao;

            Console.WriteLine("TOTAL = R$ " + valorReceber.ToString("f2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}

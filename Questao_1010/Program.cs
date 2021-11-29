using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Questao_1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int idPeca1, numPecas1;
            double valorUnitarioPeca1;
            int idPeca2, numPecas2;
            double valorUnitarioPeca2;
            double total;
            string peca1, peca2;

            peca1 = Console.ReadLine();
            peca2 = Console.ReadLine();

            idPeca1 = int.Parse(peca1.Split(' ')[0]);
            numPecas1 = int.Parse(peca1.Split(' ')[1]);
            valorUnitarioPeca1 = double.Parse(peca1.Split(' ')[2], CultureInfo.InvariantCulture);

            idPeca2 = int.Parse(peca2.Split(' ')[0]);
            numPecas2 = int.Parse(peca2.Split(' ')[1]);
            valorUnitarioPeca2 = double.Parse(peca2.Split(' ')[2], CultureInfo.InvariantCulture);

            total = numPecas1 * valorUnitarioPeca1 + numPecas2 * valorUnitarioPeca2;

            Console.WriteLine("VALOR A PAGAR: R$ "+total.ToString("f2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}

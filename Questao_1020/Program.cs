using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeEmDias = int.Parse(Console.ReadLine());
            int anos, meses, dias;

            // 365 = 1 ano
            anos = idadeEmDias / 365;
            idadeEmDias -= (anos * 365);
            // 30 dias = 1 mes
            meses = idadeEmDias / 30;
            idadeEmDias -= (meses * 30);
            dias = idadeEmDias;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");

            Console.ReadLine();
        }
    }
}

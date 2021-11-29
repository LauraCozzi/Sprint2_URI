using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int segundos = int.Parse(Console.ReadLine());
            int horas, minutos;

            horas = segundos / (60 * 60);
            segundos -= horas * (60 * 60);
            minutos = segundos / 60;
            segundos -= minutos * 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);

            Console.ReadLine();
        }
    }
}

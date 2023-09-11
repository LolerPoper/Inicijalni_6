using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicijalni_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3, broj;
            double sum = 0;

            Console.WriteLine("Unesite broj članova reda: ");
            broj = Convert.ToInt16(Console.ReadLine());

            for(int i = 0; i <= broj; i++)
            {
                sum = sum + 1/Math.Pow(a, i);
            }

            Console.WriteLine("Suma reda je " + sum);

            Console.ReadKey();
        }
    }
}

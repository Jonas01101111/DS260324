using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosCemaZero //vai de 100 a zero muito rapido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 100;
            while (cont >= 1)
            {
                Console.WriteLine(cont);
                cont--;

            }
            Console.ReadKey();
        }
    }
}

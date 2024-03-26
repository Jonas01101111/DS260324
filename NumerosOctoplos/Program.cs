using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosOctoplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 8;
            while (cont <= 100)
            {
                Console.WriteLine(cont);
                cont += 8;

            }
            Console.ReadKey();
        }
    }
}

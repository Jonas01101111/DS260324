using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a tabuada");
            int tb = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de vezes");
            int vz = int.Parse(Console.ReadLine());
            int cont = 0;
            int res = 0;
            while (vz >= cont)
            {
                res = cont * tb;
                Console.WriteLine(tb + "x" + cont + "=" + res);
                cont++;
            }
            Console.ReadKey();
        }
    }
}

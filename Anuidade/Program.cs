using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anuidade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da anuidade");
            double anui = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da matricula");
            double matr = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do material");
            double mate = double.Parse(Console.ReadLine());
            double res = 0;
            int cont = 1;

            while (cont <= 12) 
            {
                res = (anui / 12) + matr + mate;
                Console.WriteLine("Mensalidade "+cont+": R$"+String.Format("{0:0.00}" ,res));

                matr = 0;
                mate = 0;
                cont++;
            }
            Console.ReadKey();
        }
    }
}

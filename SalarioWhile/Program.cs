using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v1, v2, sal = 0, fp = 0, cont = 0;//valor 1, valor 2, salario, salario com desconto,desconto
            string check = "S";
            while (check == "S")
            {
                Console.WriteLine("Insira a forma de contratação(A:assalariado|C:comissionado|H:horista):");
                string ctrt = Console.ReadLine();
                ctrt = ctrt.ToUpper();
                switch (ctrt)//calculo salario
                {
                    case "A":
                        Console.WriteLine("Insira o salário bruto:");
                        v1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Insira o desconto:");
                        v2 = double.Parse(Console.ReadLine());
                        sal = v1 - v2;
                        Console.WriteLine("Salário:" + sal);
                        fp += sal;
                        cont++;
                        break;
                    case "C":
                        Console.WriteLine("Insira a quantidade de vendas:");
                        v1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Insira o percentual de comissão por venda:");
                        v2 = double.Parse(Console.ReadLine());
                        sal = v1 * (v2 / 100);
                        Console.WriteLine("Salário:" + sal);
                        fp += sal;
                        cont++;
                        break;
                    case "H":
                        Console.WriteLine("Insira o valor da hora trabalhada:");
                        v1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Insira quantas horas foram trabalhadas:");
                        v2 = double.Parse(Console.ReadLine());
                        sal = v1 * v2;
                        Console.WriteLine("Salário:" + sal);
                        fp += sal;
                        cont++;
                        break;
                }
                Console.WriteLine("Deseja continuar");
                check = Console.ReadLine();
                check = check.ToUpper();//muda pra maisculo
            }
            Console.WriteLine("Folha de pagamento:" + fp);
            Console.WriteLine("Funcionários cadastrados:" + cont);
            Console.WriteLine("Média salarial:" + fp / cont);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParOuImpar //fiz de um jeito bizonho, bizarro...
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("par ou impar");
            string oe = Console.ReadLine();
            int cont = 0;
            
            while (oe == "par")
            {
                while (cont <= 20)
                {
                    Console.WriteLine(cont);
                    cont += 2;

                }
                Console.ReadKey();
                break;
            }
            
            cont = 2; 
                while (oe == "impar")
                {
                    while (cont <= 20)
                    {

                        Console.WriteLine(cont - 1);
                        cont += 2;
                    
                    }
                Console.ReadKey();
                break;
                }
                
            }
        }
    }


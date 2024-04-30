using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Comissao_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vendedores = new string[5];
            double[] vendas = new double [5];
            double[] comissao = new double[5];

            for (int i = 0; i <= 5; i++) 
            { 
            Console.WriteLine("Digite o nome do vendedor: ");
            vendedores[i]= Console.ReadLine();
            Console.WriteLine("Digite o valor de vendas do vendedor: ");
            vendas[i] = double.Parse(Console.ReadLine());
                if (vendas[i] <= 20000.00)
                {
                    comissao[i] = 5/100 * vendas[i];
                }
                else if (vendas[i] <= 400000.00)
                {
                    comissao[i]= 6/100 * vendas[i];
                }
                else
                {
                    comissao[i] =7/100 * vendas[i];
                }
                

            }

            for(int j=0; j<=5; j++)
            {
                Console.WriteLine("Vendedor: " + vendedores[j] + "Valor da venda: " + vendas[j]+ "Comissão: " + comissao[j]);
            }
               
                Console.ReadKey();
        }
    }
}

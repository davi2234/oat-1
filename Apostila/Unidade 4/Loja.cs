using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                char codigo;
                double valor;
                double totalAVista = 0;
                double totalAPrazo = 0;
                double totalGeral = 0;

                for (int i = 1; i <= 15; i++)
                {
                    Console.Write("Digite o código (V ou P) da transação {0}: ", i);
                    codigo = char.Parse(Console.ReadLine());
                    Console.Write("Digite o valor da transação {0}: ", i);
                    valor = double.Parse(Console.ReadLine());
                    if (codigo == 'V')
                    {
                        totalAVista += valor;
                    }
                    else if (codigo == 'P')
                    {
                        totalAPrazo += valor;
                    }
                    totalGeral += valor;
                }

                Console.WriteLine("Valor total das compras à vista: " + totalAVista);
                Console.WriteLine("Valor total das compras a prazo: " + totalAPrazo);
                Console.WriteLine("Valor total das compras efetuadas: " + totalGeral);
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int contador = 0;
                int valor;
                int soma = 0;
                int maior = int.MinValue;
                int menor = int.MaxValue;

                do
                {
                    Console.Write("Digite um valor inteiro: ");
                    valor = int.Parse(Console.ReadLine());
                    contador++;
                    soma += valor;
                    if (valor > maior)
                    {
                        maior = valor;
                    }
                    if (valor < menor)
                    {
                        menor = valor;
                    }
                } while (contador < 20);

                double media = (double)soma / 20;

                Console.WriteLine("Maior valor: " + maior);
                Console.WriteLine("Menor valor: " + menor);
                Console.WriteLine("Média: " + media);
            }
        }
    }
    }
}

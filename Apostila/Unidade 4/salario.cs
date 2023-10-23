using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salario1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int numPessoas = 200;
                double salario;
                int numFilhos;
                double somaSalario = 0;
                int somaFilhos = 0;
                double maiorSalario = double.MinValue;
                double menorSalario = double.MaxValue;
                int numSalariosAte1500 = 0;

                for (int i = 1; i <= numPessoas; i++)
                {
                    Console.Write("Digite o salário da pessoa {0}: ", i);
                    salario = double.Parse(Console.ReadLine());
                    Console.Write("Digite o número de filhos da pessoa {0}: ", i);
                    numFilhos = int.Parse(Console.ReadLine());

                    somaSalario += salario;
                    somaFilhos += numFilhos;

                    if (salario > maiorSalario)
                    {
                        maiorSalario = salario;
                    }
                    if (salario < menorSalario)
                    {
                        menorSalario = salario;
                    }
                    if (salario <= 1500)
                    {
                        numSalariosAte1500++;
                    }
                }

                double mediaSalario = somaSalario / numPessoas;
                double mediaFilhos = (double)somaFilhos / numPessoas;
                double percentualSalariosAte1500 = (double)numSalariosAte1500 / numPessoas * 100;

                Console.WriteLine("Média do salário: " + mediaSalario);
                Console.WriteLine("Média do número de filhos: " + mediaFilhos);
                Console.WriteLine("Maior salário: " + maiorSalario);
                Console.WriteLine("Menor salário: " + menorSalario);
                Console.WriteLine("Percentual de pessoas com salários até R$1500,00: " + percentualSalariosAte1500 + "%");
            }
        }
    }
    }


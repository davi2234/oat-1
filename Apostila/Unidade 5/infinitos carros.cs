using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infinitos_carros
{
    internal class Program
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Carro> carros = new List<Carro>();

            
            Console.WriteLine("Digite as informações dos carros (Digite 'sair' para encerrar):");
            while (true)
            {
                Console.WriteLine("Marca: ");
                string marca = Console.ReadLine();
                if (marca == "sair") break;

                Console.WriteLine("Valor: ");
                double valor = double.Parse(Console.ReadLine());

                Console.WriteLine("Cor: ");
                string cor = Console.ReadLine();

                Console.WriteLine("Modelo: ");
                string modelo = Console.ReadLine();

                Console.WriteLine("Ano: ");
                int ano = int.Parse(Console.ReadLine());

                Carro carro = new Carro() { Marca = marca, Valor = valor, Cor = cor, Modelo = modelo, Ano = ano };
                carros.Add(carro);
            }

           
            carros.Sort((c1, c2) => c2.Valor.CompareTo(c1.Valor));

          
            Console.WriteLine("Carros ordenados por valor (do maior para o menor):");
            foreach (Carro carro in carros)
            {
                Console.WriteLine($"Marca: {carro.Marca} | Valor: {carro.Valor} | Cor: {carro.Cor} | Modelo: {carro.Modelo} | Ano: {carro.Ano}");
            }
        }
    }
}

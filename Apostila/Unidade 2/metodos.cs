using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos_carro
{
    internal class Class1
    {
        public string Marca;
        public string Modelo;
        public int Ano;
        public string Cor;
        public int VelocidadeMaxima;

        public carro(string marca, string modelo, int ano, string cor, int velocidadeMaxima)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Cor = cor;
            VelocidadeMaxima = velocidadeMaxima;
        }

        public void ImprimirDados()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Cor: {Cor}");
            Console.WriteLine($"Velocidade Máxima: {VelocidadeMaxima} km/h");
            Console.WriteLine();
        }

        public string Acelerar()
        {
            return "O carro está em movimento";
        }

        public string Freiar()
        {
            return "O carro está parado";
        }
    }
}

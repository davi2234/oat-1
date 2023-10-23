using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static q12.Class1;
using static q12.Class2;

namespace q12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarroDAO dao = new CarroDAO();
            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Cadastrar carro");
                Console.WriteLine("2 - Excluir carro");
                Console.WriteLine("3 - Listar carros");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite a marca:");
                        string marca = Console.ReadLine();

                        Console.WriteLine("Digite o valor:");
                        double valor = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a cor:");
                        string cor = Console.ReadLine();

                        Console.WriteLine("Digite o modelo:");
                        string modelo = Console.ReadLine();

                        Console.WriteLine("Digite o ano:");
                        int ano = int.Parse(Console.ReadLine());

                        Carro carro = new Carro();
                        carro.Marca = marca;
                        carro.Valor = valor;
                        carro.Cor = cor;
                        carro.Modelo = modelo;
                        carro.Ano = ano;

                        dao.Cadastrar(carro);

                        Console.WriteLine("Carro cadastrado com sucesso!");
                        break;

                    case 2:
                        List<Carro> carros = dao.Listar();

                        if (carros.Count == 0)
                        {
                            Console.WriteLine("Não há carros cadastrados!");
                            break;
                        }

                        Console.WriteLine("Escolha um carro para excluir:");

                        for (int i = 0; i < carros.Count; i++)
                        {
                            Console.WriteLine($"{i + 1} - {carros[i].Marca} - {carros[i].Modelo} - {carros[i].Ano}");
                        }

                        int indice = int.Parse(Console.ReadLine()) - 1;

                        dao.Excluir(carros[indice]);

                        Console.WriteLine("Carro excluído com sucesso!");
                        break;

                    case 3:
                        List<Carro> carrosOrdenados = dao.Listar();

                        if (carrosOrdenados.Count == 0)
                        {
                            Console.WriteLine("Não há carros cadastrados!");
                            break;
                        }

                        Console.WriteLine("Carros cadastrados:");

                        foreach (Carro c in carrosOrdenados)
                        {
                            Console.WriteLine($"{c.Marca} - {c.Modelo} - {c.Ano} - {c.Cor} - R${c.Valor}");
                        }

                        break;

                    default:
                        sair = true;
                        break;
                }
            }
        }
    }
}

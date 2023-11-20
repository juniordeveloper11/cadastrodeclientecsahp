using System;
using System.Collections.Generic;

class Program
{
    class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
    }

    static List<Cliente> clientes = new List<Cliente>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Cadastro de Clientes");
            Console.WriteLine("--------------------");
            Console.WriteLine("1 - Adicionar Cliente");
            Console.WriteLine("2 - Listar Clientes");
            Console.WriteLine("0 - Sair");

            Console.Write("Digite a opção desejada: ");
            char opcao = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (opcao)
            {
                case '1':
                    AdicionarCliente();
                    break;
                case '2':
                    ListarClientes();
                    break;
                case '0':
                    Console.WriteLine("Saindo do programa. Até logo!");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void AdicionarCliente()
    {
        Cliente novoCliente = new Cliente();

        Console.Write("Digite o nome do cliente: ");
        novoCliente.Nome = Console.ReadLine();

        Console.Write("Digite a idade do cliente: ");
        if (int.TryParse(Console.ReadLine(), out int idade))
        {
            novoCliente.Idade = idade;
        }
        else
        {
            Console.WriteLine("Idade inválida. O cliente não será cadastrado.");
            return;
        }

        Console.Write("Digite o e-mail do cliente: ");
        novoCliente.Email = Console.ReadLine();

        clientes.Add(novoCliente);
        Console.WriteLine("Cliente cadastrado com sucesso!");
    }

    static void ListarClientes()
    {
        Console.WriteLine("Lista de Clientes");
        Console.WriteLine("-----------------");

        if (clientes.Count == 0)
        {
            Console.WriteLine("Nenhum cliente cadastrado.");
        }
        else
        {
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"Nome: {cliente.Nome}, Idade: {cliente.Idade}, Email: {cliente.Email}");
            }
        }

        Console.WriteLine();
    }
}

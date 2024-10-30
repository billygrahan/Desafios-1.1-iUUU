List<Cliente> Clientes = new List<Cliente>();


while (true)
{
    Menu();
    Console.Write("Comando : ");
    string entrada = Console.ReadLine();

    try
    {
        int numero = int.Parse(entrada);
        if (numero == 1)
            Clientes.Add(new Cliente());
        
        else if (numero == 2)
        {
            Console.WriteLine("\n=================================================================================\n");
            foreach (var cliente in Clientes)
            {
                cliente.ImprimirDados();
                Console.WriteLine();
            }
            Console.WriteLine("\n=================================================================================\n");
        }
        else if (numero == 0)
            break;
        else Console.WriteLine("Comando não aceito!");
    }
    catch (FormatException)
    {
        Console.WriteLine("Entrada inválida! Por favor, digite um número inteiro(0,1,2).");
    }
    catch (OverflowException)
    {
        Console.WriteLine("O número digitado é muito grande ou muito pequeno para um inteiro(0,1,2).");
    }

    
}



void Menu()
{
    Console.WriteLine("--------------------------------------------------------");
    Console.WriteLine("Precione 1 para adicionar um novo usuario;");
    Console.WriteLine("Precione 2 para visualizar usuarios;");
    Console.WriteLine("Precione 0 para sair;");
    Console.WriteLine("--------------------------------------------------------");
}
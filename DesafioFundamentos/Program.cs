using DesafioFundamentos.Models;

// Define o encoding como UTF-8 para permitir exibição correta de acentuação no console
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Configuração inicial do sistema


// Solicita o preço inicial do estacionamento com validação
decimal precoInicial;
while (true)
{
    Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!\nDigite o preço inicial:");

    if (decimal.TryParse(Console.ReadLine(), out precoInicial) && precoInicial >= 0)
        break;

    Console.WriteLine("Valor inválido. Digite um número válido.");
}

// Solicita o preço por hora com validação
decimal precoPorHora;
while (true)
{
    Console.WriteLine("Agora digite o preço por hora:");

    if (decimal.TryParse(Console.ReadLine(), out precoPorHora) && precoPorHora >= 0)
        break;

    Console.WriteLine("Valor inválido. Digite um número válido.");
}

// Instancia o objeto responsável por gerenciar as operações do estacionamento
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

// Controla a execução do menu principal
bool exibirMenu = true;


// Loop principal do sistema

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("\nPressione ENTER para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa foi encerrado com sucesso.");


// Feito por Bernas
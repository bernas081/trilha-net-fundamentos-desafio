namespace DesafioFundamentos.Models
{
    /// <summary>
    /// Classe responsável por gerenciar as operações do estacionamento:
    /// cadastro, remoção e listagem de veículos.
    /// </summary>
    public class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoPorHora;

        // Lista que armazena as placas dos veículos estacionados
        private List<string> veiculos = new List<string>();

        /// <summary>
        /// Construtor que define os valores base do estacionamento.
        /// </summary>
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        /// <summary>
        /// Solicita ao usuário a placa e adiciona o veículo à lista.
        /// </summary>
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            veiculos.Add(placa);

            Console.WriteLine($"Veículo {placa} cadastrado com sucesso!");
        }

        /// <summary>
        /// Remove um veículo da lista e calcula o valor total a ser pago.
        /// </summary>
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe na lista (ignorando maiúsculas/minúsculas)
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = int.Parse(Console.ReadLine());

                // Cálculo do valor total
                decimal valorTotal = precoInicial + (precoPorHora * horas);

                // Remove o veículo correspondente
                veiculos.RemoveAll(x => x.ToUpper() == placa.ToUpper());

                Console.WriteLine($"O veículo {placa} foi removido.");
                Console.WriteLine($"Valor total a pagar: R$ {valorTotal:F2}");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado no estacionamento.");
            }
        }

        /// <summary>
        /// Exibe todos os veículos atualmente estacionados.
        /// </summary>
        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Veículos estacionados:");

                foreach (string placa in veiculos)
                {
                    Console.WriteLine($"- {placa}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
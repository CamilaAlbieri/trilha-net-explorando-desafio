using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();


bool executando = true;

Suite suite = null;
Reserva reserva = null;

while (executando)
{
    Console.WriteLine("\nSistema de Hospedagerm\n");
    Console.WriteLine("1 - Cadastrar Hóspedes");
    Console.WriteLine("2 - Cadastrar Suíte");
    Console.WriteLine("3 - Fazer Reserva");
    Console.WriteLine("4 - Exibir Informações da Reserva");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("\nEscolha uma opção: ");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Quantos hóspedes deseja cadastrar?");
            int quantidadeHospedes = int.Parse(Console.ReadLine());
            hospedes.Clear();

            for (int i = 1; i <= quantidadeHospedes; i++)
            {
                Console.WriteLine($"Nome do hóspede {i}: ");
                string nome = Console.ReadLine();

                Console.WriteLine($"Sobrenome do hóspede {i}: ");
                string sobrenome = Console.ReadLine();

                hospedes.Add(new Pessoa(nome, sobrenome));

            }
            Console.WriteLine($"{quantidadeHospedes} hóspedes cadastrados com sucesso!");

            break;

        case "":
            break;

        case "2":
            Console.WriteLine("Tipo de Suíte: ");
            string tipoSuite = Console.ReadLine();

            Console.WriteLine("Capacidade da Suíte: ");
            int capacidadeSuite = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor da Diária: ");
            decimal valorDiaria = decimal.Parse(Console.ReadLine());

            suite = new Suite(tipoSuite, capacidadeSuite, valorDiaria);

            Console.WriteLine("Suíte cadastrada com sucesso!");

            break;

        case "3":
            if (suite == null || hospedes.Count == 0)
            {
                Console.WriteLine("É necessário cadastrar hóspedes e suíte antes de fazer uma reserva.");
                break;
            }

            Console.WriteLine("Quantos dias deseja reservar? ");
            int diasReservados = int.Parse(Console.ReadLine());

            reserva = new Reserva(diasReservados);
            reserva.CadastrarSuite(suite);

            try
            {
                reserva.CadastrarHospedes(hospedes);
                Console.WriteLine("Reserva feita com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao fazer reserva: {ex.Message}");
            }


            break;

        case "4":
            if (reserva == null)
            {
                Console.WriteLine("Nenhuma reserva encontrada. Faça uma reserva primeiro.");
                break;
            }

            Console.WriteLine($"\n--- Informações da Reserva ---");
            Console.WriteLine($"Quantidade de Hóspedes: {reserva.ObterQuantidadeHospedes()}");

            foreach (var hospede in hospedes)
            {
                Console.WriteLine($"- {hospede.NomeCompleto}");
            }

            Console.WriteLine($"Suíte: {suite.TipoSuite}");
            Console.WriteLine($"Dias Reservados: {reserva.DiasReservados}");
            Console.WriteLine($"Valor Total: {reserva.CalcularValorDiaria():C}");

            if (reserva.DiasReservados >= 10)
            {
                Console.WriteLine("Desconto de 10% aplicado por reserva de 10 dias ou mais.");
            }

            break;

        case "0":
            executando = false;
            Console.WriteLine("Encerrando o sistema. Até mais!");
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }


}

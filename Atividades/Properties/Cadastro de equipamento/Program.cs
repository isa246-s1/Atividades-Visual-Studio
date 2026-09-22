using Exercicio09;

List<Equipamento> equipamentos = new List<Equipamento>();

int opcao;

do
{
    Console.Clear();

    Console.WriteLine("========================================");
    Console.WriteLine("       CADASTRO DE EQUIPAMENTOS");
    Console.WriteLine("========================================");
    Console.WriteLine("1 - Cadastrar equipamento");
    Console.WriteLine("2 - Listar equipamentos");
    Console.WriteLine("3 - Pesquisar equipamento");
    Console.WriteLine("4 - Sair");
    Console.Write("Escolha uma opção: ");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Equipamento equipamento = new Equipamento();

            Console.Write("Patrimônio: ");
            equipamento.Patrimonio = Console.ReadLine();

            Console.Write("Tipo: ");
            equipamento.Tipo = Console.ReadLine();

            Console.Write("Marca: ");
            equipamento.Marca = Console.ReadLine();

            Console.Write("Modelo: ");
            equipamento.Modelo = Console.ReadLine();

            Console.Write("Número de série: ");
            equipamento.NumeroSerie = Console.ReadLine();

            Console.Write("Status (Disponível/Em uso/Manutenção): ");
            equipamento.Status = Console.ReadLine();

            equipamentos.Add(equipamento);

            Console.WriteLine("\nEquipamento cadastrado!");
            Console.ReadKey();
            break;

        case 2:
            Console.WriteLine("\n--- EQUIPAMENTOS ---");

            foreach (Equipamento e in equipamentos)
            {
                Console.WriteLine("\n----------------------------");
                e.MostrarEquipamento();
            }

            Console.ReadKey();
            break;

        case 3:
            Console.Write("\nDigite patrimônio, marca ou modelo: ");
            string pesquisa = Console.ReadLine().ToLower();

            bool encontrado = false;

            foreach (Equipamento e in equipamentos)
            {
                if (e.Patrimonio.ToLower().Contains(pesquisa) ||
                    e.Marca.ToLower().Contains(pesquisa) ||
                    e.Modelo.ToLower().Contains(pesquisa))
                {
                    Console.WriteLine("\nEquipamento encontrado:");
                    e.MostrarEquipamento();

                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Nenhum equipamento encontrado.");
            }

            Console.ReadKey();
            break;

        case 4:
            Console.WriteLine("Programa encerrado.");
            break;

        default:
            Console.WriteLine("Opção inválida!");
            Console.ReadKey();
            break;
    }

} while (opcao != 4);

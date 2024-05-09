// Screen Sound

using System;

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine("\r\n Bem vindo ao Screen Sound!");
}

void ExibirTabelaDeOpcoes()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar toas as bandas");
    Console.WriteLine("Digite 3 paraavaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média da uma banda");
    Console.WriteLine("Digite 0 para sair!");

    Console.Write("Digite uma opção: ");
    string opcaoEscoilhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscoilhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2:
            Console.WriteLine();
            break;
        case 3:
            Console.WriteLine();
            break;
        case 4:
            Console.WriteLine();
            break;
        case -1:
            Console.WriteLine();
            break;
        default: Console.WriteLine();
            break;

    }
}
void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirTabelaDeOpcoes();
}
ExibirLogo();
ExibirTabelaDeOpcoes();

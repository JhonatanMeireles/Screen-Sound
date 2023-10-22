﻿// Screen Sound
string mensagemDeBoasVidas = "Boas Vindas ao Screen Sound";
List<string> listaDasBandas = new List<string>();




void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    
    Console.WriteLine(mensagemDeBoasVidas);

}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para Registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break; 
        case 2: MostrarBandasRegistradas();
            break;
        case 3: Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
            break;
        case 4: Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
            break;
        case -1: Console.WriteLine("Bye bye!");
            break;
        default: Console.WriteLine(@"
Tu errou. Tenta de novo e faz certo dessa vez!

░░░░░▄▄▄▀▀▀▀▀▀▀▀▀▄▄▄░░░░░░░░░
░░░▄▀░░░░░░░░░░░░░░░▀▀▄▄░░░░░
░░▄▀░░░░░░░░░░░░░░░░░░░░▀▄░░░
░▄▀░░░░░░░░░░░░░░░░░░░░░░░█░░
░█░░░░░░░░░░░░░░░░░░░░░░░░░█░
▐░░░░░░░░░░░░░░░░░░░░░░░░░░░█
█░░░░▀▀█▄▄▄░░░▄▌░░░░░░░░░░░░▐
▌░░░░░▌░██▀█▀▀░░░▄▄▄▄▄░░░░▌░▐
▌░░░░░▀▄▄▄▀░░░░░░▌░▀███▄▄▀░░▐
▌░░░░░░░░░░░░░░░░░▀▄▄▄▄▀░░░▄▌
▐░░░░▐▀░░░░░░░░░░░░░░░░░░░▄▀░
░█░░░▌░░▄▀▀▀▄▄▄░░░░░░░░░░▄▀░░
░░█░░▀░░░░▄▄▄▄░▀▀▌░░▌░░░█░░░░
░░░▀▄░░░░░░░░░▀░░░▄▀░░▄▀░░░░░
░░░░░▀▄▄▄░░░░░░░░░▄▄▀▀░░░░░░░
░░░░░░░░▐▀▀▀▀▀▀▀▀▀░░░░░░░░░░░
░░░░░░░░█░░░░░░░░░░░░░░░░░░░░
█▀▀█ █▀▀█ █▀▀ 　 █░░█ █▀▀█ █░░█
█▄▄█ █▄▄▀ █▀▀ 　 █▄▄█ █░░█ █░░█
▀░░▀ ▀░▀▀ ▀▀▀ 　 ▄▄▄█ ▀▀▀▀ ░▀▀▀
▒█░▄▀ ▀█▀ ▒█▀▀▄ ▒█▀▀▄ ▀█▀ ▒█▄░▒█ ▒█▀▀█
▒█▀▄░ ▒█░ ▒█░▒█ ▒█░▒█ ▒█░ ▒█▒█▒█ ▒█░▄▄
▒█░▒█ ▄█▄ ▒█▄▄▀ ▒█▄▄▀ ▄█▄ ▒█░░▀█ ▒█▄▄█
▒█▀▄▀█ ▒█▀▀▀ ▀█
▒█▒█▒█ ▒█▀▀▀ █▀
▒█░░▒█ ▒█▄▄▄ ▄░
");
            break;
    }
    
    if(opcaoEscolhidaNumerica == 1)
    {
        Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
    }
    else if (opcaoEscolhidaNumerica == 2)
    {
        Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
    }
    
}


void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("************************");
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("************************");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso.");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirLogo();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas() 
{
    Console.Clear();
    Console.WriteLine("************************************");
    Console.WriteLine("Exibindo todas as bandas registradas");
    Console.WriteLine("************************************\n\n");
    for(int i = 0; i < listaDasBandas.Count; i++ )
    {
        Console.WriteLine($"Banda {i+1}: {listaDasBandas[i]}");
    }

    /* Como eu vou usar o índice utilizarei o loop for mesmo
    foreach(string banda in listaDasBandas)
    {
        Console.WriteLine($"Banda : {banda}");
    }
    */
    Console.WriteLine("\n\nDigite uma tecla para voltar ao menu principal.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}

ExibirLogo();
ExibirOpcoesDoMenu();
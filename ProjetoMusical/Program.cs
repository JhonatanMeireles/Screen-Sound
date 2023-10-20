// Screen Sound
string mensagemDeBoasVidas = "Boas Vindas ao Screen Sound";

void ExibirMensagemDeBoasVindas()
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
        case 1: Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
            break; 
        case 2: Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
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




ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();
﻿class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public String DesricaoResumida => 
        $"A música {Nome} pertence à banda {Artista}.";


    public int a { get; set; }
    public int b { get; set;  }

    public int Somar => a + b;
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+.");
        }
    }
    public void ExibirFichaResumida()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"artista: {Artista}");
    }
}
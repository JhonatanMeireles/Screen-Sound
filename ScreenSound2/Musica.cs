﻿class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    private bool disponivel;

    public void EscreveDisponivel(bool value) 
    {
        disponivel = value;
    }

    public bool LeDisponivel() 
    { 
        return disponivel;
    }
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if (disponivel)
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
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"artista: {artista}");
    }
}
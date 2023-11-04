class Podcast
{
    public List<Episodio> episodios = new List<Episodio>();

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }
    public string Host { get; }

    public string Nome { get; }

    public int TotalEpisodios => episodios.Count;
    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast: {Nome}. Apresentado pelo host:{Host}.\n\n");
        foreach (var episodio in episodios.OrderBy(e => e.Ordem))
        {
            
            Console.WriteLine($"Episódio {episodio.Resumo}");
        }

        Console.WriteLine($"\n\nEste podcast possui {TotalEpisodios} episódios.");
    }

}


class Podcast
{
    public List<Episodio> TotalEpisodios = new List<Episodio>();

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }
    public string Host { get; }

    public string Nome { get; }

    public void AdicionarEpisodio(Episodio episodio)
    {
        TotalEpisodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        foreach (var episodio in TotalEpisodios)
        {
            Console.WriteLine($"Podcast: {Nome} - Host:{Host}.");
            Console.WriteLine(episodio.Titulo);
        } 
    }

}


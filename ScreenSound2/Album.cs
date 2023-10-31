class Album 
{
    private List<Musica> musicas = new List<Musica>();
    public String Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica) 
    {
        musicas.Add(musica);
    }


    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do Album {Nome}\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");

        }

        Console.WriteLine($"Para ouvir esta albúm inteiro você precisará de {DuracaoTotal} segundos.");
    }
}
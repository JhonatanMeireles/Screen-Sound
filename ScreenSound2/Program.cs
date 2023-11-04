Episodio ep1 = new(1, "Técnicas de Facilicitação", 45);

ep1.AdicionarConvidados("Bernardo");
ep1.AdicionarConvidados("Érika");
//Console.WriteLine(ep1.Resumo);

Episodio ep2 = new(2, "Como fazer uma massa de bolo macia", 57);
ep2.AdicionarConvidados("Erika");
ep2.AdicionarConvidados("Serpa");
//Console.WriteLine(ep2.Resumo);

Podcast podcast1 = new("Podcast do Jhon Jhon", "Bernardo Serpa");
podcast1.AdicionarEpisodio(ep1);
podcast1.AdicionarEpisodio(ep2);
podcast1.ExibirDetalhes();
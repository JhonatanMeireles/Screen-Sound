
Musica musica1 = new Musica();
musica1.Nome = "Roxane";
musica1.Artista = "The Police";
musica1.Duracao = 277;
musica1.Disponivel = true;
musica1.a = 1;
musica1.b = 2;
Console.WriteLine(musica1.DesricaoResumida);
Console.WriteLine(musica1.Somar);


Musica musica2 = new Musica();
musica2.Nome = "Vertigo";
musica2.Artista = "U2";
musica2.Duracao = 367;
musica2.Disponivel= false;


musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
musica1.ExibirFichaResumida();
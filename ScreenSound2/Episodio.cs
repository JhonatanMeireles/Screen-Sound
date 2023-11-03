class Episodio
{
    public List<string> convidados = new(); 
    public int Duracao { get; }

    public int Ordem { get;  }

    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ",convidados)}";

    public string Titulo { get;  }

    public Episodio(int ordem, string titulo, int duracao)
    {
        Titulo = titulo;
        Ordem = ordem;
        Duracao = duracao;

    }
    public void AdicionarConvidados(string convidado)
    
    {
        convidados.Add(convidado);

    }
}
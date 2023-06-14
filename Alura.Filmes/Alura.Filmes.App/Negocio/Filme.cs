using Alura.Filmes.App.Negocio;
using System.Collections.Generic;

public class Filme
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public string AnoLancamento { get; set; }
    public short Duracao { get; set; }
    public IList<FilmeAtor> Atores { get; set; }
    public IList<FilmeCategoria> Categorias { get; set; }
    public Idioma IdiomaFalado { get; set; }
    public Idioma IdiomaOriginal { get; set; }

    public Filme()
    {
        Atores = new List<FilmeAtor>();
    }

    public override string ToString()
    {
        return $"Filme ({Id}): {Titulo} - {AnoLancamento}";
    }
}
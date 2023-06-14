using Alura.Filmes.App.Negocio;
using System.Collections.Generic;

public class Categoria
{
    public byte Id { get; set; }
    public string Nome { get; set; }
    public IList<FilmeCategoria> Filmes { get; set; }

    public Categoria()
    {
        Filmes = new List<FilmeCategoria>();
    }

    public override string ToString()
    {
        return $"Categoria ({Id}): {Nome}";
    }
}

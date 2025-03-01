using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        // Ordena a lista de músicas por ordem alfabética do nome do artista, seleciona o nome do artista e remove os artistas repetidos e transforma em uma lista
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musicas => musicas.Artista).Distinct().ToList();

        Console.WriteLine("Lista de Artistas Ordenados");
        // Exibe todos os artistas sem repetir iterando a lista de artistas
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }

    }
}

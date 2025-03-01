using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros;
internal class LinqFilter
{
    // Metodo Estático para filtrar todas as músicas de um determinado gênero musical passando a lista de músicas e o gênero musical
    public static void FiltrarTodosOsGerenosMusicais(List<Musica> musicas)
    {
        // Filtra todas as músicas de um determinado gênero musical sem repetir os gêneros musicais e transforma em uma lista
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        // Exibe todos os gêneros musicais sem repetir iterando a lista de gêneros musicais
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        // Filtra todos os artistas de um determinado gênero musical sem repetir os artistas e transforma em uma lista usando contains
        // para verificar se o gênero musical contém o gênero informado
        var artistasPorGeneroMusical = musicas.Where(musicas => musicas.Genero!.Contains(genero)).Select(musicas => musicas.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");
        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        // Filtra todas as músicas de um determinado artista sem repetir as músicas e transforma em uma lista
        // usa o equals para verificar se o artista é igual ao nome do artista informado
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();

        Console.WriteLine(nomeDoArtista);

        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }

    }

    public static void FiltrarMusicasPeloAno(List<Musica> musicas, int ano)
    {
        var anoFiltrado = musicas.Where(musica => musica.Ano == ano).ToList();

        Console.WriteLine(ano);

        foreach (var musica in anoFiltrado)
        {
            Console.WriteLine($"- {musica.Nome}");
        }

    }

    public static void FiltraMusicasEmCSharp(List<Musica> musicas)
    {
        // Filtra todas as músicas em C# sem repetir as músicas e transforma em uma lista
        var musicasEmCSharp = musicas.Where(musica => musica.Tonalidade.Equals("C#")).Select(musica => musica.Nome);
        Console.WriteLine("Musicas em C#");
        foreach (var musica in musicasEmCSharp)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}

    
// Http Client para fazer requisições HTTP em C# com .NET Core
using ScreenSound_04.Modelos;
using System.Text.Json;
using ScreenSound_04.Filtros;

using (HttpClient client = new HttpClient())
{
    // tenta fazer a requisição GET para a URL informada
    try
    {
        // aguarda a tarefa ser concluída para pegar as informações do link e armazenar na variável resposta
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        // deserializa a resposta em uma lista de músicas e armazena na variável musicas numa lista de músicas e precisa ter valores na musica por causa do !
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        LinqFilter.FiltraMusicasEmCSharp(musicas);



        //musicas[0].ExibirDetalhesDaMusica();

        // chama o método estático FiltrarTodosOsGerenosMusicais da classe LinqFilter passando a lista de músicas
        //LinqFilter.FiltrarTodosOsGerenosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");
        //LinqFilter.FiltrarMusicasPeloAno(musicas, 2010);

        //var musicasPreferidasDoJaan = new MusicasPreferidas("Jaan");
        //musicasPreferidasDoJaan.AdicionarMusicasFavoritas(musicas[0]);
        //musicasPreferidasDoJaan.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasDoJaan.AdicionarMusicasFavoritas(musicas[2]);
        //musicasPreferidasDoJaan.AdicionarMusicasFavoritas(musicas[3]);
        //musicasPreferidasDoJaan.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidasDoJaan.AdicionarMusicasFavoritas(musicas[5]);
        //musicasPreferidasDoJaan.ExibirMusicasFavoritas();

        //musicasPreferidasDoJaan.GerarArquivoJson();
    }
    // caso ocorra um erro, exibe a mensagem de erro
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
    
}

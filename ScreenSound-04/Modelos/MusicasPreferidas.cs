
using System.Text.Json;

namespace ScreenSound_04.Modelos;

internal class MusicasPreferidas
{
    // Propriedade para armazenar o nome do usuário
    public string Nome { get; set; }
    // Lista de músicas favoritas
    public List<Musica> listadeMusicasFavoritas { get; }

    // Construtor para inicializar a lista de músicas favoritas
    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        // Inicializa a lista de músicas favoritas
        listadeMusicasFavoritas = new List<Musica>();
    }

    // Método para adicionar músicas favoritas
    public void AdicionarMusicasFavoritas(Musica musica)
    {
        listadeMusicasFavoritas.Add(musica);
    }
    // Método para exibir músicas favoritas
    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Músicas favoritas de {Nome}");
        foreach (var musica in listadeMusicasFavoritas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
        Console.WriteLine();
    }

    public void GerarArquivoJson()
    {
        // Serializa o objeto em formato JSON e salva em um arquivo com o nome do usuário e música favorita em formato JSON
        var json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = listadeMusicasFavoritas
        });
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
        // Salva o arquivo JSON
        File.WriteAllText(nomeDoArquivo, json);
        // Exibe mensagem de sucesso
        Console.WriteLine($"O arquivo {nomeDoArquivo} gerado com sucesso!{Path.GetFullPath(nomeDoArquivo)}");
    }
}


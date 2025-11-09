using System.Net;
using System.Net.Http.Headers;
using http_client_use.Models;

// Aqui vamos criar o objeto para fazer as requisições
HttpClient client = new HttpClient();

// Configura o endereço base da API
client.BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon/");

// Configura o cabeçalho Accept, que diz ao servidor qual tipo de dado
// ele deve retornar.
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

// Pede o nome do pokemon e verifica se o nome não está vazio
Console.Write("Digite o nome do pokemon: ");
string? name = Console.ReadLine();

if (String.IsNullOrEmpty(name))
{
    Console.WriteLine("Nome não informado!");
    Environment.Exit(0);
}

// Faz a requisição
// A requisição pode lançar uma exceção do tipo HttpRequestException.
try {
    HttpResponseMessage response = await client.GetAsync(name.ToLower());
    Pokemon? pokemon = null;

    if (response.IsSuccessStatusCode)
    {
        pokemon = await response.Content.ReadAsAsync<Pokemon>();
        Console.WriteLine("");
        Console.WriteLine("Nome: {0}", pokemon.Name);
        Console.WriteLine("Peso: {0}", pokemon.Weight);
        Console.WriteLine("Altura: {0}", pokemon.Height);
        Console.WriteLine("Ordem: {0}", pokemon.Order);
        Console.WriteLine("");
    }
    else if (response.StatusCode == HttpStatusCode.NotFound)
    {
        Console.WriteLine("Pokemon não encontrado!");
    }
}
catch (HttpRequestException exception)
{
    Console.WriteLine("Erro na requisição: {0}", exception.Message);
}
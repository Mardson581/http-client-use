namespace http_client_use.Models;

public class Pokemon
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public int Weight { get; set; }
    public int Height { get; set; }
    public int Order { get; set; }
    public List<PokemonType> Types { get; private set; } = new List<PokemonType>();
}
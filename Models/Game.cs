namespace GamesStore.Models

public class Game
{
    public int Id {get;set;}
    public required string Name {get;set;}
    public require required string Genre {get;set;}
    public decimal Price {get;set;}
    public DateTime ReleaseDate {get;set;}
}
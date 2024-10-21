using GamesStore.Models;

namespace GamesStore;

public static class GameClient
{
    private static readonly List<Game> games = new()
    {
    new Game()
    {
        Id = 1,
       Name = "Street Fighter II",
       Genre = "Fighting",
       Price = 19.9M,
       ReleaseDate = new DateTime(1991, 2, 1)
    },
    new Game()
    {
        Id = 2,
       Name = "Final Fantasy XIV",
       Genre = "Roleplaying",
       Price = 59.9M,
       ReleaseDate = new DateTime(2010, 9, 30)
    }
    };

    public static Game[] GetGames()
    {
        return games.ToArray();
    }
    public static void AddGame(Game game)
    {
        game.Id = games.Max(x=>x.Id) + 1;
        games.Add(game);
    }
    public static void RemoveGame(int id)
    {
        Game existinggame = GetGame(id);
        games.Remove(existinggame);
    }
    public static Game GetGame(int id)
    {
       return games.Find(x=>x.Id == id)?? throw new Exception("Couldn't find game!!");
    }
    public static void UpdateGame(Game updategame)
    {
        Game existinggame = GetGame(updategame.Id);
        existinggame.Name = updategame.Name;
        existinggame.Genre = updategame.Genre;
        existinggame.Price = updategame.Price;
        existinggame.ReleaseDate = updategame.ReleaseDate;
     
    }
}

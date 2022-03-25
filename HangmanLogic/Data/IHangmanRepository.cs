namespace HangmanLogic;

public interface IHangmanRepository
{
    public Game GetGame(string gameId);

    public string SaveGame(Game game);
}
using HangmanLogic.model;

namespace HangmanLogic.Service;

public class Service: IService
{
    private IHangmanRepository repo;
    
    public Service(IHangmanRepository repo)
    {
        this.repo = repo;
    }
    
    public GameState Start(UserInput input)
    {
        return new();
    }

    public GameState Guess(UserInput input)
    {
        return new GameState();
    }

    public GameState Abord(UserInput input)
    {
        return new GameState() {Status = GameStatus.LOST};
    }
    
}
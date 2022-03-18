using HangmanLogic.model;

namespace HangmanLogic;

public class Service
{
    private IHangmanRepository repo;
    
    public Service(IHangmanRepository repo)
    {
        this.repo = repo;
    }
    
    public GameState Start()
    {
        return new();
    }

    public GameState Guess(char c)
    {
        return new GameState();
    }
    
}
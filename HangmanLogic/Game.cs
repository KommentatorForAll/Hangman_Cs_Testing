using HangmanLogic.model;

namespace HangmanLogic;

public class Game
{
    public GameState State { get; set; }
    public string TargetWord { get; set; }
}
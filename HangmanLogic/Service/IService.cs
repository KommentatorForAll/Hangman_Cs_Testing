using HangmanLogic.model;

namespace HangmanLogic.Service;
public interface IService
{
    GameState Start(UserInput input);
    GameState Guess(UserInput input);
    GameState Abord(UserInput input);
}
using System;
using System.Collections.Generic;

namespace HangmanLogic;

public class HangmanRepository: IHangmanRepository
{
    private readonly Dictionary<string, Game> RunningGames = new();

    public Game GetGame(string gameId)
    {
        return RunningGames[gameId];
    }

    public string SaveGame(Game game)
    {
        string guid = Guid.NewGuid().ToString();
        RunningGames.Add(guid, game);
        return guid;
    }
}
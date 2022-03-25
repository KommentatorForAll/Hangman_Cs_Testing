using System;
using System.Collections.Generic;

namespace HangmanLogic;

public class HangmanRepository: IHangmanRepository
{
    private readonly Dictionary<string, Game> _runningGames = new();

    public Game GetGame(string gameId)
    {
        return _runningGames[gameId];
    }

    public string SaveGame(Game game)
    {
        var guid = Guid.NewGuid().ToString();
        _runningGames.Add(guid, game);
        return guid;
    }
}
using System;
using HangmanLogic.model;
using HangmanLogic.Service;

namespace HangmanLogic.Controller
{

    public class Controller
    {

        private readonly IService _service;

        public Controller(IService service)
        {
            _service = service;
        }

        public GameState processInput(UserInput input)
        {
            switch (input.InputType)
            {
                case InputType.GUESS:
                    return _service.Guess(input);
                case InputType.START_GAME:
                    return _service.Start(input);
                case InputType.ABORD_GAME:
                    return _service.Abord(input);
                default:
                    throw new Exception("Invalid operation");
            }
        }
    }
}
using HangmanLogic.model;
using HangmanLogic.Controller;
using HangmanLogic.Service;
using NSubstitute;
using NUnit.Framework;

namespace HangmanLogic;

public class ControllerTest
{
    [Test]
    public void ProcessInput_Start_calls_Start()
    {
        IService mock = Substitute.For<IService>();
        Controller.Controller controller = new(mock);
        var startInput = new UserInput() {InputType = InputType.START_GAME};

        controller.processInput(startInput);

        mock.Received(1).Start(startInput);
    }

    [Test]
    public void ProcessInput_Abord_AbordsGame()
    {
        IService mock = Substitute.For<IService>();
        Controller.Controller controller = new(mock);

        var abordInput = new UserInput() {InputType = InputType.ABORD_GAME};

        controller.processInput(abordInput);

        mock.Received(1).Abord(abordInput);
    }

    [Test]
    public void ProcessInput_Guess()
    {
        
        IService mock = Substitute.For<IService>();
        Controller.Controller controller = new(mock);
        var guessInput = new UserInput() {Input = "g", InputType = InputType.GUESS};

        controller.processInput(guessInput);

        mock.Received(1).Guess(guessInput);
    }
}
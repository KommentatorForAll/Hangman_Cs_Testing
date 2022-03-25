using HangmanLogic.model;
using NSubstitute;
using NUnit.Framework;

namespace HangmanLogic;

[TestFixture]
public class ServiceTest
{
    [Test]
    public void Start_CreatesNewGame()
    {
        IHangmanRepository mock = Substitute.For<IHangmanRepository>();
        Service.Service service = new(mock);

        service.Start(new UserInput());

        mock.Received(1).SaveGame(Arg.Any<Game>());
    }
}
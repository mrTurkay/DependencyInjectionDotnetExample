using DependencyInjectionExample;

namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Setup() { }

    [Test]
    public void PaperBeatsRock()
    {
        var gameManager = new GameManager( new DalkavukPlayer(Choice.Paper),new DalkavukPlayer(Choice.Rock));

        var result = gameManager.Play();

        Assert.AreEqual(result, RoundResult.Player1Win);
    }
}
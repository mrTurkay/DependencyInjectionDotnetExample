using DependencyInjectionExample;
using static DependencyInjectionExample.RoundResult;

GameManager gameManager = new(new ChatGPTPlayer(), new ComputerPlayer());

while (true)
{
    RoundResult result = gameManager.Play();

    var resultString = result switch
    {
        Draw => "Draw!",
        Player1Win => "Player 1 Wins!",
        Player2Win => "Player 2 Wins!",
        _ => throw new NotImplementedException()
    };

    Console.WriteLine(resultString);

    Console.WriteLine();
    Console.Write("Play again? (Y/N): ");

    string input = Console.ReadLine().ToUpper();

    if (input != "Y")
    {
        break;
    }
}
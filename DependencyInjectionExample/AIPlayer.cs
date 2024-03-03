namespace DependencyInjectionExample;

public class AIPlayer : IPlayer
{
    public Choice GetChoice()
    {
        var random = new Random();
        var choice = random.Next(0, 3);

        var ch = choice switch
        {
            0 => Choice.Rock,
            1 => Choice.Paper,
            2 => Choice.Scissors,
            _ => throw new NotImplementedException()
        };
        
        Console.WriteLine($"AI chose {ch}");
        
        return ch;
    }
}
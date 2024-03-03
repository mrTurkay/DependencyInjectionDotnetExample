namespace DependencyInjectionExample;

public class ComputerPlayer : IPlayer
{
    Random _rng = new();

    public Choice GetChoice()
    {
        Choice p2 = (Choice) _rng.Next(0, 3);
        
        Console.WriteLine($"Player 2 chose {p2}");
        
        return p2;
    }
}
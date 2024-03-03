using DependencyInjectionExample;

namespace TestProject1;

public class DalkavukPlayer : IAIPlayer
{
    private readonly Choice _choice;

    public DalkavukPlayer(Choice choice)
    {
        _choice = choice;
    }

    public Choice GetChoice()
    {
        return _choice;
    }
}
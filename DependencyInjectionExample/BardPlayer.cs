namespace DependencyInjectionExample;

public class BardPlayer: IAIPlayer
{
    public Choice GetChoice()
    {
        return Choice.Rock;
    }
}
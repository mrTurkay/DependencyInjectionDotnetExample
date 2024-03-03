namespace DependencyInjectionExample;

public class ChatGPTPlayer : IAIPlayer
{
    public Choice GetChoice()
    {
        return Choice.Paper;
    }
}
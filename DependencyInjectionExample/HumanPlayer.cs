namespace DependencyInjectionExample;

public class HumanPlayer : IPlayer
{
    public Choice GetChoice()
    {
        Choice p1;
        do
        {
            Console.Write("Enter Choice: (R)ock, (P)aper, or (S)cissors: ");
            
            var input = Console.ReadLine().ToUpper();
            
            if (input == "R" || input == "r")
            {
                p1 = Choice.Rock;
                break;
            }
            else if (input == "P" || input == "p")
            {
                p1 = Choice.Paper;
                break;
            }
            else if (input == "S" || input == "s")
            {
                p1 = Choice.Scissors;
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, try again!");
            }
        } while (true);

        return p1;
    }
}
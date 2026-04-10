namespace Slots;

public class SlotMachine
{
    private Random rng = new Random();

    public void Spin()
    {
        int a = rng.Next(0, 5);
        int b = rng.Next(0, 5);
        int c = rng.Next(0, 5);

        Console.WriteLine($"[{a}] [{b}] [{c}]");

        if (a == b && b == c)
        {
            Console.WriteLine("JACKPOT!");
        }
        else
        {
            Console.WriteLine("Try again!");
        }
    }
}
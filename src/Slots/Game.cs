namespace Slots;

public class Game
{
    private bool isRunning = true;
    private SlotMachine slotMachine;

    public Game()
    {
        slotMachine = new SlotMachine();
    }

    public void Run()
    {
        Console.WriteLine("Welcome to Slots!");

        while (isRunning)
        {
            ShowMenu();
            HandleInput();
        }
    }

    private void ShowMenu()
    {
        Console.WriteLine("\n--- MENU ---");
        Console.WriteLine("1. Spin");
        Console.WriteLine("2. Exit");
        Console.Write("Choose: ");
    }

    private void HandleInput()
    {
        var input = Console.ReadLine();

        switch (input)
        {
            case "1":
                slotMachine.Spin();
                break;

            case "2":
                isRunning = false;
                Console.WriteLine("Goodbye!");
                break;

            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
}
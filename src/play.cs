public class play
{
    private slotMech engine;
    private symbVal paytable;
    private bonus bonus;
    private window window;
    private sound sound;

    public static void Main(string[] args)
    {
        // TODO: Instantiate this class and call StartGame()
    }

    public void StartGame()
    {
        // TODO: Initialize all component objects (Engine, UI, Sound, etc.)
        // TODO: Call InitializeUI and LoadAudioAssets
        // TODO: Enter the main ExecuteGameLoop
    }

    private void ExecuteGameLoop()
    {
        // TODO: Keep the application running and wait for user input (like the Spin button)
    }

    private void ProcessTurn()
    {
        // TODO: 1. Deduct bet from balance
        // TODO: 2. Call engine.Spin() to get results
        // TODO: 3. Tell window to play spin animation and sound to play spin audio
        // TODO: 4. Check paytable for wins and check bonus for scatter triggers
        // TODO: 5. Update UI balance and play win sounds if necessary
    }
}
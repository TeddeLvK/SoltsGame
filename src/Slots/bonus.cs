public class bonus
{
    public bool IsBonusActive;
    private int freeSpinsRemaining;
    private float multiplier;

    public void CheckScatterTrigger(int[,] matrix, int scatterID)
    {
        // TODO: Count how many times the scatterID appears in the 2D matrix
        // TODO: If the count is >= 3, set IsBonusActive to true and call StartFreeSpins
    }

    public void StartFreeSpins(int count)
    {
        // TODO: Set the freeSpinsRemaining variable
        // TODO: Optionally increase the win multiplier for the duration of the bonus
    }

    public void UpdateBonusState()
    {
        // TODO: Deduct one spin from freeSpinsRemaining after each bonus turn
        // TODO: If remaining spins reach 0, set IsBonusActive to false
    }

    public void RunMiniGame()
    {
        // TODO: (Optional) Logic for a "Pick-a-Prize" or "Fortune Wheel" interaction
    }
}
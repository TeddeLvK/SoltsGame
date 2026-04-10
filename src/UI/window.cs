public class window
{
    public void InitializeUI()
    {
        // TODO: Set up the window size, buttons, and text labels for the user
    }

    public void RenderReels(int[,] finalMatrix)
    {
        // TODO: Update the visual display (images/icons) to match the result matrix from the engine
    }

    public void UpdateLabels(long balance, int bet, int win)
    {
        // TODO: Update the text on the screen to show the current wallet, current bet, and last win
    }

    public void ShowWinEffect(int winAmount)
    {
        // TODO: Trigger visual feedback like flashing symbols or a "Big Win" popup
    }

    public void OnSpinClick()
    {
        // TODO: Link this to the UI button to notify the GameLauncher that a spin is requested
    }
}
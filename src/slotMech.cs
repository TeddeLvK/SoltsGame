public class slotMech
{
    private int rows;
    private int columns;
    private Random rng;

    public slotMech(int rows, int columns)
    {
        // TODO: Initialize the grid dimensions and the Random object
    }

    public int[,] Spin(int totalSymbols)
    {
        // TODO: Create a 2D array based on rows and columns
        // TODO: Fill each index of the array by calling GetRandomSymbol
        // TODO: Return the completed matrix to the GameManager heheheha
    }

    public void SetStopLogic()
    {
        // TODO: Implement timing logic (e.g., using Thread.Sleep or Tasks) 
        // TODO: Ensure Reel 1 stops first, then Reel 2, etc., to create suspense
    }

    private int GetRandomSymbol(int totalSymbols)
    {
        // TODO: Return a random integer between 0 and the total number of symbols
    }
}
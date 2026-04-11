public class slotMech
{
    private int rows;
    private int columns;
    private Random rng;

    public slotMech(int rows, int columns)
    {
        // TODO: Initialize the grid dimensions and the Random object
        this.rows = rows;
        this.columns = columns;
        rng = new Random();
    }

    public int[,] Spin(int totalSymbols)
    {
        // TODO: Create a 2D array based on rows and columns
        int[,] grid = new int[rows, columns];
        // TODO: Fill each index of the array by calling GetRandomSymbol
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                grid[i, j] = GetRandomSymbol(totalSymbols);
            }
        }
        // TODO: Return the completed matrix to the GameManager heheheha
        return grid;
    }

    public void SetStopLogic()
    {
        // TODO: Implement timing logic (e.g., using Thread.Sleep or Tasks) 
        // TODO: Ensure Reel 1 stops first, then Reel 2, etc., to create suspense
    }

    private int GetRandomSymbol(int totalSymbols)
    {
        // TODO: Return a random integer between 0 and the total number of symbols
        return rng.Next(0, totalSymbols);
    }
}
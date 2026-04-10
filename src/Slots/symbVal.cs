public struct SymbolData
{
    public int ID;
    public string Name;
    public int Weight;
    public int[] Payouts;
}

public class symbVal
{
    private List<SymbolData> symbols;

    public void InitializePaytable()
    {
        // TODO: Create a list of SymbolData objects
        // TODO: Define the ID, rarity (Weight), and payout array for each symbol
    }

    public int CalculatePayout(int symbolID, int matchCount)
    {
        // TODO: Find the symbol by ID in the list
        // TODO: Return the value from its Payouts array based on the match count (e.g., 3 matching symbols)
    }

    public int GetWeightedSymbol()
    {
        // TODO: Implement weighted randomness logic
        // TODO: Sum all symbol weights, pick a random number, and return the ID of the chosen symbol
    }
}
using App.Simulation;
using Domain.Treasures;

Treasure treasure = TreasureBuilder.GetDragonsHoard();
int tries = 100_000;
decimal budget = 14 * 2.35m;
decimal timesMetBudget = 0.0m;
decimal timesBreakEven = 0.0m;
decimal totalWon = 0.0m;
decimal totalSpent = 0.0m;
List<OpeningResult> results = [];

for (int i = 0; i < tries; i++)
{
    decimal spent = 0.0m;
    decimal won = 0.0m;
    while (spent + treasure.Price <= budget)
    {
        spent += treasure.Price;
        var (itemSet, bonusSet) = treasure.Open();
        OpeningResult result = new(itemSet, bonusSet);
        results.Add(result);
        won += result.MarketValue;

        if (won >= spent) break;
    }

    if (won >= spent)
    {
        timesBreakEven++;
        totalWon += won;
    }
    else
    {
        timesMetBudget++;
        totalSpent += spent;
    }
}

decimal totalOpenings = results.Count;
Console.WriteLine($"On a budget of {budget:C}, you would have broken even or turned a profit {timesBreakEven / tries:P} of the time and gone over budget {timesMetBudget / tries:P} of the time.");
Console.WriteLine("Sanity checks:");
Console.WriteLine($"  Average treasures opened: {totalOpenings / tries}");
Console.WriteLine($"  Average unusuals: {results.Count(r => r.IsUnusualBonusDrop || r.IsUnusualDrop) / totalOpenings:P}");
Console.WriteLine($"  Average won: {totalWon / tries:C}");
Console.WriteLine($"  Average spent: {totalSpent / tries:C}");
Console.WriteLine($"  Average profit: {(totalWon - totalSpent) / tries:C}");
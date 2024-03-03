using System.Diagnostics;
using App.Simulation;
using Domain.Extensions;
using Domain.Treasures;

Treasure treasure = TreasureBuilder.GetDragonsHoard();
List<int> treasuresBought = [1, 14, 140, 1_400, 14_000];
foreach (int treasures in treasuresBought)
{
    int tries = 100_000;
    decimal budget = treasures * 2.35m;
    List<OpeningResult> breakEvenResults = [];
    List<OpeningResult> metBudgetResults = [];

    for (int i = 0; i < tries; i++)
    {
        List<OpeningResult> results = [];
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
            spent -= result.MarketValue;
            won -= result.MarketValue;
        }

        if (won >= spent)
        {
            breakEvenResults.AddRange([.. results]);
        }
        else
        {
            metBudgetResults.AddRange([.. results]);
        }
    }

    // Results turned profit or broke even
    decimal timesBreakEven = breakEvenResults.CountDecimal();
    decimal unusualsBreakEven = breakEvenResults.CountDecimal(r => r.IsUnusualDrop || r.IsUnusualBonusDrop);
    decimal averageProfit = breakEvenResults.Sum(r => (r.MarketValue - treasure.Price) / timesBreakEven);

    // Results met budget
    decimal timesMetBudget = metBudgetResults.CountDecimal();
    decimal unusualsMetBudget = metBudgetResults.CountDecimal(r => r.IsUnusualDrop || r.IsUnusualBonusDrop);
    decimal averageLoss = metBudgetResults.Sum(r => (r.MarketValue - treasure.Price) / timesMetBudget);

    // All results
    decimal totalOpenings = timesBreakEven + timesMetBudget;
    decimal unusualOpenings = unusualsBreakEven + unusualsMetBudget;
    decimal breakEvenChance = timesBreakEven / totalOpenings;
    decimal metBudgetChance = timesMetBudget / totalOpenings;

    // Summary
    string summary =
    $"""
    On a budget of {budget:C}, you would have broken even or turned a profit {breakEvenChance:P} of the time and met the budget {metBudgetChance:P} of the time.
    Sanity checks:
      Average treasures opened: {totalOpenings / tries}
      Average unusuals: {unusualOpenings / totalOpenings:P}
      Average won: {averageProfit:C}
      Average spent: {averageLoss:C}
      Average profit: {averageProfit * breakEvenChance + averageLoss * metBudgetChance:C}
    """;
    Console.WriteLine(summary);
}

Debugger.Break();
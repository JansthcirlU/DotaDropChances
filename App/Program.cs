using App.Simulation;
using Domain.Items;
using Domain.Treasures;

Treasure treasure = TreasureBuilder.GetDragonsHoard();
var (ancientDragonKingSet, _) = DropBuilder.GetAncientDragonKingSet();
ItemSetId ancientDragonKingSetId = ancientDragonKingSet.Id;

int tries = 200_000;
Dictionary<int, List<OpeningResult>> results = [];

for (int i = 0; i < tries; i++)
{
    results[i] = [];
    while (true)
    {
        var (itemSet, bonusSet) = treasure.Open();
        OpeningResult result = new(itemSet, bonusSet);
        results[i].Add(result);
        
        if (bonusSet?.Id == ancientDragonKingSetId)
        {
            break;
        }
    }
}

decimal totalOpenings = results.SelectMany(r => r.Value).ToList().Count;
decimal averageTries = (decimal)results.Average(r => r.Value.Count);
decimal totalUnusuals = results.SelectMany(r => r.Value).Count(r => r.IsUnusualDrop || r.IsUnusualBonusDrop);
decimal averageMarketValue = results.SelectMany(r => r.Value).Sum(result => result.MarketValue) / totalOpenings;
Console.WriteLine($"Average tries to get the Ancient Dragon King set: {averageTries:F2}");
Console.WriteLine($"Average spent: {Math.Ceiling(averageTries) * treasure.Price:C2}.");
Console.WriteLine($"Average market value: {averageMarketValue:C2}");
Console.WriteLine($"Unusuals percentage: {100.0m * totalUnusuals / totalOpenings:F2}%");
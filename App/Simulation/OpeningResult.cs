using Domain.Items;

namespace App.Simulation;

public record OpeningResult(
    ItemSet ItemSet,
    ItemSet? BonusItemSet)
{
    public bool IsUnusualDrop = ItemSet.Name.Contains("UNUSUAL");
    public bool IsUnusualBonusDrop = BonusItemSet?.Name.Contains("UNUSUAL") ?? false;
    public decimal MarketValue => ItemSet.MaxMarketValue + (BonusItemSet?.MaxMarketValue ?? 0.0m);
}

using Domain.Items;
using Domain.Probabilities;

namespace Domain.Treasures;

public class Treasure
{
    private readonly ExhaustiveChoiceList<Drop> _drops;
    private readonly List<EscalatingDrop> _bonusDrops;

    public TreasureId Id { get; }
    public string Name { get; }
    public decimal Price { get; }

    public Treasure(string name, decimal price)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name, nameof(name));
        ArgumentOutOfRangeException.ThrowIfNegative(price, nameof(price));

        Id = TreasureId.NewTreasureId();
        Name = name;
        Price = price;
        _drops = [];
        _bonusDrops = [];
    }

    public (ItemSet Item, ItemSet? Bonus) Open()
    {
        // Select a regular item randomly
        Drop drop = _drops.Choose();
        double unusualRoll = Random.Shared.NextDouble();
        ItemSet itemSet = unusualRoll < 0.01 ? drop.UnusualSet ?? drop.ItemSet : drop.ItemSet;

        // Roll a random number to determine if a bonus item is won
        ItemSet? bonusSet = null;
        double bonusRoll = Random.Shared.NextDouble();
        double unusualBonusRoll = Random.Shared.NextDouble();

        // Create a cumulative probability distribution
        bool bonusItemWon = false;
        double cumulativeProbability = 0;
        foreach (var bonusDrop in _bonusDrops.OrderBy(bd => bd.Probability.GetCurrentProbability()))
        {
            cumulativeProbability += bonusDrop.Probability.GetCurrentProbability();
            if (!bonusItemWon && bonusRoll < cumulativeProbability)
            {
                bonusSet = unusualBonusRoll < 0.01 ? bonusDrop.Drop.UnusualSet ?? bonusDrop.Drop.ItemSet : bonusDrop.Drop.ItemSet;
                bonusDrop.Probability.Reset();
                bonusItemWon = true;
            }
            else
            {
                bonusDrop.Probability.Escalate();
            }
        }
        return (itemSet, bonusSet);
    }


    public Treasure AddItemDrop(Drop drop)
    {
        _drops.Add(drop);
        return this;
    }

    public Treasure AddBonusItemDrop(Drop bonusDrop, EscalatingProbability probability)
    {
        _bonusDrops.Add(new(bonusDrop, probability));
        return this;
    }
}

namespace Domain.Items;

public record class Item
{
    public ItemId Id { get; private set; }
    public string Name { get; private set; }
    public decimal? MarketPrice { get; private set; }

    public Item(string name, decimal? marketPrice = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name, nameof(name));
        ArgumentOutOfRangeException.ThrowIfNegative(marketPrice ?? default, nameof(marketPrice));

        Id = ItemId.NewItemId();
        Name = name;
        MarketPrice = marketPrice;
    }
}
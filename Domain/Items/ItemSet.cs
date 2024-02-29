namespace Domain.Items;

public class ItemSet
{
    private readonly List<Item> _items = [];

    public ItemSetId Id { get; private set; }
    public string Name { get; private set; }
    public decimal? MarketPrice { get; private set; }
    public decimal? ItemsValue => _items.Sum(i => i.MarketPrice);
    public decimal MaxMarketValue => (MarketPrice > ItemsValue ? MarketPrice : ItemsValue) ?? 0.0m;
    public IEnumerable<Item> Items => _items.ToList();

    public ItemSet(string name, decimal? marketPrice = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name, nameof(name));
        ArgumentOutOfRangeException.ThrowIfNegative(marketPrice ?? default, nameof(marketPrice));

        Id = ItemSetId.NewItemSetId();
        Name = name;
        MarketPrice = marketPrice;
    }

    public ItemSet AddItem(Item item)
    {
        _items.Add(item);
        return this;
    }
}

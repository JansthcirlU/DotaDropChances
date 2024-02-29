namespace Domain.Items;

public readonly record struct ItemId(Guid Value)
{
    public static ItemId NewItemId() => new(Guid.NewGuid());
}
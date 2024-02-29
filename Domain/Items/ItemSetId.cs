namespace Domain.Items;

public readonly record struct ItemSetId(Guid Id)
{
    public static ItemSetId NewItemSetId() => new(Guid.NewGuid());
}
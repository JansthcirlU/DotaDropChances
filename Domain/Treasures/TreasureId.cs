namespace Domain.Treasures;

public readonly record struct TreasureId(Guid Value)
{
    public static TreasureId NewTreasureId() => new(Guid.NewGuid());
}
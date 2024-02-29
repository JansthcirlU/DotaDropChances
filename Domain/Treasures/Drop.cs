using Domain.Items;

namespace Domain.Treasures;

public record struct Drop(ItemSet ItemSet, ItemSet? UnusualSet);

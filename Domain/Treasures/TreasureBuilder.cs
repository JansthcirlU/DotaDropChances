using Domain.Probabilities;

namespace Domain.Treasures;

public class TreasureBuilder
{
    private static readonly Dictionary<int, double> RareOdds = new()
    {
        { 1, 2000.0 },
        { 2, 583.0 },
        { 3, 187.0 },
        { 4, 88.0 },
        { 5, 51.0 },
        { 6, 33.0 },
        { 7, 23.0 },
        { 8, 17.0 },
        { 9, 13.1 },
        { 10, 10.4 },
        { 11, 8.5 },
        { 12, 7.1 },
        { 13, 6.0 },
        { 14, 5.2 },
        { 15, 4.5 },
        { 16, 4.0 },
        { 17, 3.6 },
        { 18, 3.2 },
        { 19, 2.9 },
        { 20, 2.6 },
        { 21, 2.4 },
        { 22, 2.2 },
        { 23, 2.1 },
        { 24, 1.9 },
        { 25, 1.8 },
        { 26, 1.7 },
        { 27, 1.6 },
        { 28, 1.5 },
        { 29, 1.5 },
        { 30, 1.4 },
        { 31, 1.3 },
        { 32, 1.3 },
        { 33, 1.2 },
        { 34, 1.2 },
        { 35, 1.2 },
        { 36, 1.1 },
        { 37, 1.1 },
        { 38, 1.1 },
        { 39, 1.1 },
        { 40, 1.0 },
        { 41, 1.0 },
        { 42, 1.0 },
        { 43, 1.0 },
        { 44, 1.0 },
        { 45, 1.0 },
        { 46, 1.0 },
        { 47, 1.0 },
        { 48, 1.0 },
        { 49, 1.0 },
        { 50, 1.0 },
    };
    private static readonly Dictionary<int, double> VeryRareOdds = new()
    {
        { 1, 20000.0 },
        { 2, 3653.0 },
        { 3, 1059.0 },
        { 4, 485.0 },
        { 5, 276.0 },
        { 6, 178.0 },
        { 7, 124.0 },
        { 8, 92.0 },
        { 9, 70.0 },
        { 10, 56.0 },
        { 11, 45.0 },
        { 12, 38.0 },
        { 13, 32.0 },
        { 14, 27.0 },
        { 15, 24.0 },
        { 16, 21.0 },
        { 17, 18.0 },
        { 18, 16.0 },
        { 19, 14.1 },
        { 20, 12.7 },
        { 21, 11.5 },
        { 22, 10.5 },
        { 23, 9.6 },
        { 24, 8.8 },
        { 25, 8.1 },
        { 26, 7.5 },
        { 27, 7.0 },
        { 28, 6.5 },
        { 29, 6.0 },
        { 30, 5.7 },
        { 31, 5.3 },
        { 32, 5.0 },
        { 33, 4.7 },
        { 34, 4.5 },
        { 35, 4.2 },
        { 36, 4.0 },
        { 37, 3.9 },
        { 38, 3.6 },
        { 39, 3.4 },
        { 40, 3.3 },
        { 41, 3.2 },
        { 42, 3.0 },
        { 43, 2.9 },
        { 44, 2.8 },
        { 45, 2.7 },
        { 46, 2.6 },
        { 47, 2.5 },
        { 48, 2.4 },
        { 49, 2.3 },
        { 50, 2.2 },
    };
    private static readonly Dictionary<int, double> UltraRareOdds = new()
    {
        { 1, 100000.0 },
        { 2, 27380.0 },
        { 3, 8614.0 },
        { 4, 4021.0 },
        { 5, 2303.0 },
        { 6, 1486.0 },
        { 7, 1037.0 },
        { 8, 764.0 },
        { 9, 586.0 },
        { 10, 464.0 },
        { 11, 376.0 },
        { 12, 311.0 },
        { 13, 262.0 },
        { 14, 223.0 },
        { 15, 193.0 },
        { 16, 168.0 },
        { 17, 148.0 },
        { 18, 131.0 },
        { 19, 117.0 },
        { 20, 105.0 },
        { 21, 95.0 },
        { 22, 86.0 },
        { 23, 79.0 },
        { 24, 72.0 },
        { 25, 66.0 },
        { 26, 61.0 },
        { 27, 57.0 },
        { 28, 53.0 },
        { 29, 49.0 },
        { 30, 46.0 },
        { 31, 43.0 },
        { 32, 40.0 },
        { 33, 38.0 },
        { 34, 35.0 },
        { 35, 33.0 },
        { 36, 32.0 },
        { 37, 30.0 },
        { 38, 28.0 },
        { 39, 27.0 },
        { 40, 26.0 },
        { 41, 24.0 },
        { 42, 23.0 },
        { 43, 22.0 },
        { 44, 21.0 },
        { 45, 20.0 },
        { 46, 19.0 },
        { 47, 19.0 },
        { 48, 18.0 },
        { 49, 17.0 },
        { 50, 17.0 },
    };

    public static Treasure GetDragonsHoard()
    {
        // Regular item drops
        var whisperAtTheTempleGatesDrop = DropBuilder.GetWhisperAtTheTempleGatesDrop();
        var heraldOfFrostAndFlameDrop = DropBuilder.GetHeraldOfFrostAndFlameDrop();
        var vileBehemothDrop = DropBuilder.GetVileBehemothDrop();
        var reflectionOfTheSurgingStreamDrop = DropBuilder.GetReflectionOfTheSurgingStreamDrop();
        var routOfTheEmeraldMarauderDrop = DropBuilder.GetRoutOfTheEmeraldMarauderDrop();
        var masterOfTheMysticPhoenixDrop = DropBuilder.GetMasterOfTheMysticPhoenixDrop();
        var havocOfTheHydrasScornDrop = DropBuilder.GetHavocOfTheHydrasScornDrop();
        var victoriousFightingScoundrelDrop = DropBuilder.GetVictoriousFightingScoundrelDrop();
        var attunementsOfTheOrnateDrop = DropBuilder.GetAttunementsOfTheOrnateDrop();
        var oniMagiDrop = DropBuilder.GetOniMagiDrop();
        var vanishingPearlDrop = DropBuilder.GetVanishingPearlDrop();
        var fortifiedBrewDrop = DropBuilder.GetFortifiedBrewDrop();
        var bloomjewelBrawlerDrop = DropBuilder.GetBloomjewelBrawlerDrop();
        var songOfTheShadowDragonDrop = DropBuilder.GetSongOfTheShadowDragonDrop();

        // Bonus item drops
        var spiritOfTheFrozenFlowDrop = DropBuilder.GetSpiritOfTheFrozenFlowDrop();
        var dreadMistDragoonDrop = DropBuilder.GetDreadMistDragoonDrop();
        var templeGuardianDrop = DropBuilder.GetTempleGuardianDrop();
        var ancientDragonKingDrop = DropBuilder.GetAncientDragonKingSet();

        // Escalating chances
        EscalatingProbability rareProbability = new(RareOdds.Select(kvp => new Probability(1 / (1 + kvp.Value))));
        EscalatingProbability veryRareProbability = new(VeryRareOdds.Select(kvp => new Probability(1 / (1 + kvp.Value))));
        EscalatingProbability ultraRareProbability = new(UltraRareOdds.Select(kvp => new Probability(1 / (1 + kvp.Value))));

        // Treasure building
        Treasure dragonsHoard = new Treasure("Dragon's Hoard", 2.35m)
            .AddItemDrop(whisperAtTheTempleGatesDrop)
            .AddItemDrop(heraldOfFrostAndFlameDrop)
            .AddItemDrop(vileBehemothDrop)
            .AddItemDrop(reflectionOfTheSurgingStreamDrop)
            .AddItemDrop(routOfTheEmeraldMarauderDrop)
            .AddItemDrop(masterOfTheMysticPhoenixDrop)
            .AddItemDrop(havocOfTheHydrasScornDrop)
            .AddItemDrop(victoriousFightingScoundrelDrop)
            .AddItemDrop(attunementsOfTheOrnateDrop)
            .AddItemDrop(oniMagiDrop)
            .AddItemDrop(vanishingPearlDrop)
            .AddItemDrop(fortifiedBrewDrop)
            .AddItemDrop(bloomjewelBrawlerDrop)
            .AddItemDrop(songOfTheShadowDragonDrop)
            .AddBonusItemDrop(spiritOfTheFrozenFlowDrop, rareProbability)
            .AddBonusItemDrop(dreadMistDragoonDrop, veryRareProbability)
            .AddBonusItemDrop(templeGuardianDrop, ultraRareProbability)
            .AddBonusItemDrop(ancientDragonKingDrop, ultraRareProbability);
        return dragonsHoard;
    }
}
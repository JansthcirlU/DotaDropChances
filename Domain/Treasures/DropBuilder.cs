using Domain.Items;

namespace Domain.Treasures;

public class DropBuilder
{
    private static readonly ItemSet WhisperAtTheTempleGatesSet = new ItemSet("Whisper at the Temple Gates")
        .AddItem(new("Whisper at the Temple Gates - Head"))
        .AddItem(new("Whisper at the Temple Gates - Armor"))
        .AddItem(new("Whisper at the Temple Gates - Shoulder"))
        .AddItem(new("Whisper at the Temple Gates - Weapon"));
    private static readonly ItemSet UnusualWhisperAtTheTempleGatesSet = new ItemSet("UNUSUAL Whisper at the Temple Gates")
        .AddItem(new("Whisper at the Temple Gates - Head"))
        .AddItem(new("Whisper at the Temple Gates - Armor"))
        .AddItem(new("Whisper at the Temple Gates - Shoulder"))
        .AddItem(new("Unusual Whisper at the Temple Gates - Weapon", 11.01m));

    private static readonly ItemSet HeraldOfFrostAndFlameSet = new ItemSet("Herald of Frost and Flame")
        .AddItem(new("Herald of Frost and Flame - Back"))
        .AddItem(new("Herald of Frost and Flame - Frost Head"))
        .AddItem(new("Herald of Frost and Flame - Flame Head"))
        .AddItem(new("Herald of Frost and Flame - Tail"));
    private static readonly ItemSet UnusualHeraldOfFrostAndFlameSet = new ItemSet("UNUSUAL Herald of Frost and Flame")
        .AddItem(new("Herald of Frost and Flame - Back"))
        .AddItem(new("Herald of Frost and Flame - Frost Head"))
        .AddItem(new("Herald of Frost and Flame - Flame Head"))
        .AddItem(new("Unusual Herald of Frost and Flame - Tail", 9.15m));

    private static readonly ItemSet VileBehemothSet = new ItemSet("Vile Behemoth")
        .AddItem(new("Vile Behemoth - Shield"))
        .AddItem(new("Vile Behemoth - Legs"))
        .AddItem(new("Vile Behemoth - Spear"));
    private static readonly ItemSet UnusualVileBehemothSet = new ItemSet("UNUSUAL Vile Behemoth")
        .AddItem(new("Vile Behemoth - Shield"))
        .AddItem(new("Vile Behemoth - Legs"))
        .AddItem(new("Unusual Vile Behemoth - Spear", 8.65m));

    private static readonly ItemSet ReflectionOfTheSurgingStreamSet = new ItemSet("Reflection of the Surging Stream")
        .AddItem(new("Reflection of the Surging Stream - Back"))
        .AddItem(new("Reflection of the Surging Stream - Head"))
        .AddItem(new("Reflection of the Surging Stream - Misc"))
        .AddItem(new("Reflection of the Surging Stream - Shoulder"))
        .AddItem(new("Reflection of the Surging Stream - Arms"));
    private static readonly ItemSet UnusualReflectionOfTheSurgingStreamSet = new ItemSet("UNUSUAL Reflection of the Surging Stream")
        .AddItem(new("Reflection of the Surging Stream - Back"))
        .AddItem(new("Reflection of the Surging Stream - Head"))
        .AddItem(new("Reflection of the Surging Stream - Misc"))
        .AddItem(new("Reflection of the Surging Stream - Shoulder"))
        .AddItem(new("Unusual Reflection of the Surging Stream - Arms", 18.93m));

    private static readonly ItemSet RoutOfTheEmeraldMarauderSet = new ItemSet("Rout of the Emerald Marauder")
        .AddItem(new("Rout of the Emerald Marauder - Tail"))
        .AddItem(new("Rout of the Emerald Marauder - Shoulder"))
        .AddItem(new("Rout of the Emerald Marauder - Head"))
        .AddItem(new("Rout of the Emerald Marauder - Belt"))
        .AddItem(new("Rout of the Emerald Marauder - Back"))
        .AddItem(new("Rout of the Emerald Marauder - Arms"))
        .AddItem(new("Rout of the Emerald Marauder - Weapon"));
    private static readonly ItemSet UnusualRoutOfTheEmeraldMarauderSet = new ItemSet("UNUSUAL Rout of the Emerald Marauder")
        .AddItem(new("Rout of the Emerald Marauder - Tail"))
        .AddItem(new("Rout of the Emerald Marauder - Shoulder"))
        .AddItem(new("Rout of the Emerald Marauder - Head"))
        .AddItem(new("Rout of the Emerald Marauder - Belt"))
        .AddItem(new("Rout of the Emerald Marauder - Back"))
        .AddItem(new("Rout of the Emerald Marauder - Arms"))
        .AddItem(new("Unusual Rout of the Emerald Marauder - Weapon", 11.84m));

    private static readonly ItemSet MasterOfTheMysticPhoenixSet = new ItemSet("Master of the Mystic Phoenix")
        .AddItem(new("Master of the Mystic Phoenix - Back"))
        .AddItem(new("Master of the Mystic Phoenix - Shoulder"))
        .AddItem(new("Master of the Mystic Phoenix - Belt"))
        .AddItem(new("Master of the Mystic Phoenix - Arms"))
        .AddItem(new("Master of the Mystic Phoenix - Head"));
    private static readonly ItemSet UnusualMasterOfTheMysticPhoenixSet = new ItemSet("UNUSUAL Master of the Mystic Phoenix")
        .AddItem(new("Master of the Mystic Phoenix - Back"))
        .AddItem(new("Master of the Mystic Phoenix - Shoulder"))
        .AddItem(new("Master of the Mystic Phoenix - Belt"))
        .AddItem(new("Master of the Mystic Phoenix - Arms"))
        .AddItem(new("Unusual Master of the Mystic Phoenix - Head", 7.36m));

    private static readonly ItemSet HavocOfTheHydrasScornSet = new ItemSet("Havoc of the Hydra's Scorn")
        .AddItem(new("Havoc of the Hydra's Scorn - Tail"))
        .AddItem(new("Havoc of the Hydra's Scorn - Arms"))
        .AddItem(new("Havoc of the Hydra's Scorn - Armor"))
        .AddItem(new("Havoc of the Hydra's Scorn - Head"))
        .AddItem(new("Havoc of the Hydra's Scorn - Weapon"));
    private static readonly ItemSet UnusualHavocOfTheHydrasScornSet = new ItemSet("UNUSUAL Havoc of the Hydra's Scorn")
        .AddItem(new("Havoc of the Hydra's Scorn - Tail"))
        .AddItem(new("Havoc of the Hydra's Scorn - Arms"))
        .AddItem(new("Havoc of the Hydra's Scorn - Armor"))
        .AddItem(new("Havoc of the Hydra's Scorn - Head"))
        .AddItem(new("Unusual Havoc of the Hydra's Scorn - Weapon", 23.25m));

    private static readonly ItemSet VictoriousFightingScoundrelSet = new ItemSet("Victorious Fighting Scoundrel")
        .AddItem(new("Victorious Fighting Scoundrel - Head"))
        .AddItem(new("Victorious Fighting Scoundrel - Shoulder"))
        .AddItem(new("Victorious Fighting Scoundrel - Armor"))
        .AddItem(new("Victorious Fighting Scoundrel - Staff"));
    private static readonly ItemSet UnusualVictoriousFightingScoundrelSet = new ItemSet("UNUSUAL Victorious Fighting Scoundrel")
        .AddItem(new("Victorious Fighting Scoundrel - Head"))
        .AddItem(new("Victorious Fighting Scoundrel - Shoulder"))
        .AddItem(new("Victorious Fighting Scoundrel - Armor"))
        .AddItem(new("Unusual Victorious Fighting Scoundrel - Staff", 27.04m));

    private static readonly ItemSet AttunementsOfTheOrnateSet = new ItemSet("Attunements of the Ornate")
        .AddItem(new("Attunements of the Ornate - Head"));
    private static readonly ItemSet UnusualAttunementsOfTheOrnateSet = new ItemSet("UNUSUAL Attunements of the Ornate")
        .AddItem(new("Unusual Attunements of the Ornate - Head", 5.19m));

    private static readonly ItemSet OniMagiSet = new ItemSet("Oni Magi")
        .AddItem(new("Oni Magi - Belt"))
        .AddItem(new("Oni Magi - Head"))
        .AddItem(new("Oni Magi - Arms"))
        .AddItem(new("Oni Magi - Back"))
        .AddItem(new("Oni Magi - Weapon"));
    private static readonly ItemSet UnusualOniMagiSet = new ItemSet("UNUSUAL Oni Magi")
        .AddItem(new("Oni Magi - Belt"))
        .AddItem(new("Oni Magi - Head"))
        .AddItem(new("Oni Magi - Arms"))
        .AddItem(new("Oni Magi - Back"))
        .AddItem(new("Unusual Oni Magi - Weapon", 12.93m));

    private static readonly ItemSet VanishingPearlSet = new ItemSet("Vanishing Pearl")
        .AddItem(new("Vanishing Pearl - Tail"))
        .AddItem(new("Vanishing Pearl - Back"))
        .AddItem(new("Vanishing Pearl - Head"));
    private static readonly ItemSet UnusualVanishingPearlSet = new ItemSet("UNUSUAL Vanishing Pearl")
        .AddItem(new("Vanishing Pearl - Tail"))
        .AddItem(new("Vanishing Pearl - Back"))
        .AddItem(new("Unusual Vanishing Pearl - Head", 11.64m));

    private static readonly ItemSet FortifiedBrewSet = new ItemSet("Fortified Brew")
        .AddItem(new("Fortified Brew - Shoulder"))
        .AddItem(new("Fortified Brew - Off-Hand"))
        .AddItem(new("Fortified Brew - Head"))
        .AddItem(new("Fortified Brew - Back"))
        .AddItem(new("Fortified Brew - Arms"))
        .AddItem(new("Fortified Brew - Weapon"));
    private static readonly ItemSet UnusualFortifiedBrewSet = new ItemSet("UNUSUAL Fortified Brew")
        .AddItem(new("Fortified Brew - Shoulder"))
        .AddItem(new("Fortified Brew - Off-Hand"))
        .AddItem(new("Fortified Brew - Head"))
        .AddItem(new("Fortified Brew - Back"))
        .AddItem(new("Fortified Brew - Arms"))
        .AddItem(new("Unusual Fortified Brew - Weapon", 12.43m));

    private static readonly ItemSet BloomjewelBrawlerSet = new ItemSet("Bloomjewel Brawler")
        .AddItem(new("Bloomjewel Brawler - Armor"))
        .AddItem(new("Bloomjewel Brawler - Shoulder"))
        .AddItem(new("Bloomjewel Brawler - Head"))
        .AddItem(new("Bloomjewel Brawler - Back"));
    private static readonly ItemSet UnusualBloomjewelBrawlerSet = new ItemSet("UNUSUAL Bloomjewel Brawler")
        .AddItem(new("Bloomjewel Brawler - Armor"))
        .AddItem(new("Bloomjewel Brawler - Shoulder"))
        .AddItem(new("Bloomjewel Brawler - Head"))
        .AddItem(new("Unusual Bloomjewel Brawler - Back", 21.64m));

    private static readonly ItemSet SongOfTheShadowDragonSet = new ItemSet("Song of the Shadow Dragon")
        .AddItem(new("Song of the Shadow Dragon - Belt"))
        .AddItem(new("Song of the Shadow Dragon - Head"))
        .AddItem(new("Song of the Shadow Dragon - Shoulders"))
        .AddItem(new("Song of the Shadow Dragon - Back"))
        .AddItem(new("Song of the Shadow Dragon - Blade"));
    private static readonly ItemSet UnusualSongOfTheShadowDragonSet = new ItemSet("UNUSUAL Song of the Shadow Dragon")
        .AddItem(new("Song of the Shadow Dragon - Belt"))
        .AddItem(new("Song of the Shadow Dragon - Head"))
        .AddItem(new("Song of the Shadow Dragon - Shoulders"))
        .AddItem(new("Song of the Shadow Dragon - Back"))
        .AddItem(new("Unusual Song of the Shadow Dragon - Blade", 22.08m));

    private static readonly ItemSet SpiritOfTheFrozenFlowSet = new ItemSet("Spirit of the Frozen Flow", 4.32m)
        .AddItem(new("Spirit of the Frozen Flow - Armor", 0.95m))
        .AddItem(new("Spirit of the Frozen Flow - Tail", 0.11m))
        .AddItem(new("Spirit of the Frozen Flow - Orbs", 0.42m))
        .AddItem(new("Spirit of the Frozen Flow - Head", 0.30m));
    private static readonly ItemSet UnusualSpiritOfTheFrozenFlowSet = new ItemSet("UNUSUAL Spirit of the Frozen Flow", 4.32m)
        .AddItem(new("Spirit of the Frozen Flow - Armor", 0.95m))
        .AddItem(new("Spirit of the Frozen Flow - Tail", 0.11m))
        .AddItem(new("Spirit of the Frozen Flow - Orbs", 0.42m))
        .AddItem(new("Unusual Spirit of the Frozen Flow - Head", 26.10m));

    private static readonly ItemSet DreadMistDragoonSet = new ItemSet("Dreadmist Dragoon", 3.87m)
        .AddItem(new("Dreadmist Dragoon - Shoulder", 0.31m))
        .AddItem(new("Dreadmist Dragoon - Mount", 2.59m))
        .AddItem(new("Dreadmist Dragoon - Head", 0.75m))
        .AddItem(new("Dreadmist Dragoon - Back", 0.18m))
        .AddItem(new("Dreadmist Dragoon - Weapon", 0.41m));
    private static readonly ItemSet UnusualDreadMistDragoonSet = new ItemSet("UNUSUAL Dreadmist Dragoon", 3.87m)
        .AddItem(new("Dreadmist Dragoon - Shoulder", 0.31m))
        .AddItem(new("Dreadmist Dragoon - Mount", 2.59m))
        .AddItem(new("Dreadmist Dragoon - Head", 0.75m))
        .AddItem(new("Dreadmist Dragoon - Back", 0.18m))
        .AddItem(new("Unusual Dreadmist Dragoon - Weapon", 69.39m));

    private static readonly ItemSet TempleGuardianSet = new ItemSet("Temple Guardian", 8.30m)
        .AddItem(new("Temple Guardian - Legs", 0.53m))
        .AddItem(new("Temple Guardian - Back", 3.14m))
        .AddItem(new("Temple Guardian - Head", 3.50m))
        .AddItem(new("Temple Guardian - Arms", 0.66m));
    private static readonly ItemSet UnusualTempleGuardianSet = new ItemSet("UNUSUAL Temple Guardian", 8.30m)
        .AddItem(new("Temple Guardian - Legs", 0.53m))
        .AddItem(new("Temple Guardian - Back", 3.14m))
        .AddItem(new("Temple Guardian - Head", 3.50m))
        .AddItem(new("Unusual Temple Guardian - Arms", 151.27m));

    private static readonly ItemSet AncientDragonKingSet = new ItemSet("Ancient Dragon King")
        .AddItem(new("Ancient Dragon King", 54.97m));

    public static Drop GetWhisperAtTheTempleGatesDrop()
        => new(WhisperAtTheTempleGatesSet, UnusualWhisperAtTheTempleGatesSet);

    public static Drop GetHeraldOfFrostAndFlameDrop()
        => new(HeraldOfFrostAndFlameSet, UnusualHeraldOfFrostAndFlameSet);

    public static Drop GetVileBehemothDrop()
        => new(VileBehemothSet, UnusualVileBehemothSet);

    public static Drop GetReflectionOfTheSurgingStreamDrop()
        => new(ReflectionOfTheSurgingStreamSet, UnusualReflectionOfTheSurgingStreamSet);

    public static Drop GetRoutOfTheEmeraldMarauderDrop()
        => new(RoutOfTheEmeraldMarauderSet, UnusualRoutOfTheEmeraldMarauderSet);

    public static Drop GetMasterOfTheMysticPhoenixDrop()
        => new(MasterOfTheMysticPhoenixSet, UnusualMasterOfTheMysticPhoenixSet);

    public static Drop GetHavocOfTheHydrasScornDrop()
        => new(HavocOfTheHydrasScornSet, UnusualHavocOfTheHydrasScornSet);

    public static Drop GetVictoriousFightingScoundrelDrop()
        => new(VictoriousFightingScoundrelSet, UnusualVictoriousFightingScoundrelSet);

    public static Drop GetAttunementsOfTheOrnateDrop()
        => new(AttunementsOfTheOrnateSet, UnusualAttunementsOfTheOrnateSet);

    public static Drop GetOniMagiDrop()
        => new(OniMagiSet, UnusualOniMagiSet);

    public static Drop GetVanishingPearlDrop()
        => new(VanishingPearlSet, UnusualVanishingPearlSet);

    public static Drop GetFortifiedBrewDrop()
        => new(FortifiedBrewSet, UnusualFortifiedBrewSet);

    public static Drop GetBloomjewelBrawlerDrop()
        => new(BloomjewelBrawlerSet, UnusualBloomjewelBrawlerSet);

    public static Drop GetSongOfTheShadowDragonDrop()
        => new(SongOfTheShadowDragonSet, UnusualSongOfTheShadowDragonSet);

    public static Drop GetSpiritOfTheFrozenFlowDrop()
        => new(SpiritOfTheFrozenFlowSet, UnusualSpiritOfTheFrozenFlowSet);

    public static Drop GetDreadMistDragoonDrop()
        => new(DreadMistDragoonSet, UnusualDreadMistDragoonSet);

    public static Drop GetTempleGuardianDrop()
        => new(TempleGuardianSet, UnusualTempleGuardianSet);

    public static Drop GetAncientDragonKingSet()
        => new(AncientDragonKingSet, null);
}
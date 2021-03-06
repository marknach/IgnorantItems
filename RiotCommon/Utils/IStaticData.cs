﻿using CoffeeCat.RiotCommon.Dto.StaticData.Champion;
using CoffeeCat.RiotCommon.Dto.StaticData.Item;
using CoffeeCat.RiotCommon.Dto.StaticData.Mastery;
using CoffeeCat.RiotCommon.Dto.StaticData.Rune;
using CoffeeCat.RiotCommon.Dto.StaticData.SummonerSpells;

namespace CoffeeCat.RiotCommon.Utils
{
    public interface IStaticData
    {
        RuneListDto RuneList { get; }

        MasteryListDto MasteryList { get; }

        ChampionListDto ChampionList { get; }

        ItemListDto ItemList { get; }

        SummonerSpellListDto SummonerSpellList { get; }
    }
}
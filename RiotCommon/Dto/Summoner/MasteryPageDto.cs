﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace CoffeeCat.RiotCommon.Dto.Summoner
{
    [JsonObject]
    public class MasteryPageDto
    {
        [JsonProperty]
        public long Id { get; set; }

        [JsonProperty]
        public bool Current { get; set; }

        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public List<MasteryDto> Masteries { get; set; }
    }
}

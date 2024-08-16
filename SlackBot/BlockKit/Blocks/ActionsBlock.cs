﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using SlackBot.Blocks.BaseBlocks;

namespace SlackBot.Blocks
{
    public class ActionsBlock : BlockBase
    {
        public override string Type => BlockTypes.Actions;
        [JsonProperty("elements")]
        public IList<ElementBase> Elements { get; set; } = new List<ElementBase>();
    }
}
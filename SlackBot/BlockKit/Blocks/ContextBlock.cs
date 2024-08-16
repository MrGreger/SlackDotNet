using System.Collections.Generic;
using Newtonsoft.Json;
using SlackBot.Blocks.BaseBlocks;

namespace SlackBot.Blocks
{
    public class ContextBlock : BlockBase
    {
        public override string Type => BlockTypes.Context;
        [JsonProperty("elements")]
        public IList<ElementBase> Elements { get; set; }
    }
}
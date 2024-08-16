using System.Collections.Generic;
using HttpSlackBot.Blocks.BaseBlocks;
using Newtonsoft.Json;

namespace HttpSlackBot.Blocks
{
    public class ContextBlock : BlockBase
    {
        public override string Type => BlockTypes.Context;
        [JsonProperty("elements")]
        public IList<ElementBase> Elements { get; set; }
    }
}
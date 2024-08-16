using System.Collections.Generic;
using System.Text.Json.Serialization;
using SlackBot.Blocks.BaseBlocks;

namespace SlackBot.Blocks
{
    public class ContextBlock : BlockBase
    {
        public override string Type => BlockTypes.Context;
        [JsonPropertyName("elements")]
        public IList<ElementBase> Elements { get; set; }
    }
}
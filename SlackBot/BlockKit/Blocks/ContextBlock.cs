using System.Collections.Generic;
using Newtonsoft.Json;
using SlackBotDotNet.BlockKit.BaseBlocks;

namespace SlackBotDotNet.BlockKit.Blocks
{
    public class ContextBlock : BlockBase
    {
        public override string Type => BlockTypes.Context;
        [JsonProperty("elements")]
        public IList<ElementBase> Elements { get; set; }
    }
}
using System.Collections.Generic;
using Newtonsoft.Json;
using SlackBotDotNet.BlockKit.BaseBlocks;

namespace SlackBotDotNet.BlockKit.Blocks
{
    public class ActionsBlock : BlockBase
    {
        public override string Type => BlockTypes.Actions;
        [JsonProperty("elements")]
        public IList<ElementBase> Elements { get; set; } = new List<ElementBase>();
    }
}
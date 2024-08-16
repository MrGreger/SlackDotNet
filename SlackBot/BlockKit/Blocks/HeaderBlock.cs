using System.Collections.Generic;
using Newtonsoft.Json;
using SlackBot.Blocks.BaseBlocks;

namespace SlackBot.Blocks
{
    public class HeaderBlock : BlockBase
    {
        public override string Type => BlockTypes.Header;
        [JsonProperty("text")]
        public PlainText Elements { get; set; }
    }
}
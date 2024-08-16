using System.Collections.Generic;
using System.Text.Json.Serialization;
using SlackBot.Blocks.BaseBlocks;

namespace SlackBot.Blocks
{
    public class HeaderBlock : BlockBase
    {
        public override string Type => BlockTypes.Header;
        [JsonPropertyName("text")]
        public PlainText Elements { get; set; }
    }
}
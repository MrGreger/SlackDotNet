using System.Collections.Generic;
using HttpSlackBot.Blocks.BaseBlocks;
using Newtonsoft.Json;

namespace HttpSlackBot.Blocks
{
    public class HeaderSection : BlockBase
    {
        public override string Type => BlockTypes.Header;
        [JsonProperty("text")]
        public PlainText Elements { get; set; }
    }
}
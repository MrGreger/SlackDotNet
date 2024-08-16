using System.Collections.Generic;
using HttpSlackBot.Blocks.BaseBlocks;
using Newtonsoft.Json;

namespace HttpSlackBot.Blocks
{
    public class RichTextBlock : BlockBase
    {
        public override string Type => BlockTypes.RichText;
        [JsonProperty("block_id")]
        public string BlockId { get; set; }
        [JsonProperty("elements")]
        public List<RichTextSectionBase> Elements { get; set; } = new List<RichTextSectionBase>();
    }
}
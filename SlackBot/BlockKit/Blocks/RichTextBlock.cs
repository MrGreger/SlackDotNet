using System.Collections.Generic;
using Newtonsoft.Json;
using SlackBot.Blocks.BaseBlocks;

namespace SlackBot.Blocks
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
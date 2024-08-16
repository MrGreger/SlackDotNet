using System.Collections.Generic;
using System.Text.Json.Serialization;
using SlackBot.Blocks.BaseBlocks;

namespace SlackBot.Blocks
{
    public class RichTextBlock : BlockBase
    {
        public override string Type => BlockTypes.RichText;
        [JsonPropertyName("block_id")]
        public string BlockId { get; set; }
        [JsonPropertyName("elements")]
        public List<RichTextSectionBase> Elements { get; set; } = new List<RichTextSectionBase>();
    }
}
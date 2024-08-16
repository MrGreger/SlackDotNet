using System.Collections.Generic;
using Newtonsoft.Json;
using SlackBotDotNet.BlockKit.BaseBlocks;
using SlackBotDotNet.BlockKit.Text.RichText;

namespace SlackBotDotNet.BlockKit.Blocks
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
using System.Collections.Generic;
using Newtonsoft.Json;
using SlackBotDotNet.BlockKit.BaseBlocks;
using SlackBotDotNet.BlockKit.Elements;
using SlackBotDotNet.BlockKit.Text;

namespace SlackBotDotNet.BlockKit.Blocks
{
    public class Section : BlockBase
    {
        public override string Type => BlockTypes.Section;

        [JsonProperty("text")]
        public TextAttribute Text { get; set; }
        [JsonProperty("fields")]
        public List<TextAttribute> Fields { get; set; }
        [JsonProperty("accessory")]
        public ISectionElement Accessory { get; set; }
    }
}
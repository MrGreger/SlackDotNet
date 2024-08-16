using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using SlackBot.Blocks.BaseBlocks;
using SlackBot.Blocks.Elements;

namespace SlackBot.Blocks
{
    public class Section : BlockBase
    {
        public override string Type => BlockTypes.Section;

        [JsonPropertyName("text")]
        public TextAttribute Text { get; set; }
        [JsonPropertyName("fields")]
        public List<TextAttribute> Fields { get; set; } = new List<TextAttribute>();
        [JsonPropertyName("accessory")]
        public ISectionElement Accessory { get; set; }
    }
}
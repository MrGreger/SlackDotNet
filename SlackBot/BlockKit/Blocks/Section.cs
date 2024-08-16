using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using SlackBot.Blocks.BaseBlocks;
using SlackBot.Blocks.Elements;

namespace SlackBot.Blocks
{
    public class Section : BlockBase
    {
        public override string Type => BlockTypes.Section;

        [JsonProperty("text")]
        public TextAttribute Text { get; set; }
        [JsonProperty("fields")]
        public List<TextAttribute> Fields { get; set; } = new List<TextAttribute>();
        [JsonProperty("accessory")]
        public ISectionElement Accessory { get; set; }
    }
}
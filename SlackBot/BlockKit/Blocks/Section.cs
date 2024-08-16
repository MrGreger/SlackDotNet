using System;
using System.Collections.Generic;
using System.Linq;
using HttpSlackBot.Blocks.BaseBlocks;
using HttpSlackBot.Blocks.Elements;
using Newtonsoft.Json;

namespace HttpSlackBot.Blocks
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
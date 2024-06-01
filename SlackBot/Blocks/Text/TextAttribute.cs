using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using HttpSlackBot.Blocks.BaseBlocks;

namespace HttpSlackBot.Blocks
{
    public class TextAttribute : ElementBase
    {
        public TextAttribute(string type, bool emoji)
        {
            Type = type;
            Emoji = emoji;
        }

        [JsonProperty("type")]
        public override string Type { get; }
        [JsonProperty("emoji")]
        public bool Emoji { get; set; }        
        [JsonProperty("verbatim")]
        public bool Verbatim { get; set; }
        [JsonProperty("text")]
        public string Value { get; set; }
    }
}

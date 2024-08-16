using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
using SlackBot.Blocks.BaseBlocks;

namespace SlackBot.Blocks
{
    public class TextAttribute : ElementBase
    {
        public TextAttribute(string type, bool emoji)
        {
            Type = type;
            Emoji = emoji;
        }

        [JsonPropertyName("type")]
        public override string Type { get; }
        [JsonPropertyName("emoji")]
        public bool Emoji { get; set; }        
        [JsonPropertyName("verbatim")]
        public bool Verbatim { get; set; }
        [JsonPropertyName("text")]
        public string Value { get; set; }
    }
}

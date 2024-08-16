using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlackBot.Blocks.Checkbox
{
    public class InputOption : IOptionPayload
    {
        [JsonPropertyName("text")]
        public TextAttribute Text { get; set; }
        [JsonPropertyName("description")]
        public TextAttribute Description { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}

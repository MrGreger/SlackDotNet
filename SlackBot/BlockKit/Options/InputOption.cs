using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlackBot.Blocks.Checkbox
{
    public class InputOption : IOptionPayload
    {
        [JsonProperty("text")]
        public TextAttribute Text { get; set; }
        [JsonProperty("description")]
        public TextAttribute Description { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}

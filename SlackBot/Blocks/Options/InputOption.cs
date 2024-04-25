using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HttpSlackBot.Blocks.Checkbox
{
    public class InputOption
    {
        [JsonProperty("text")]
        public TextAttribute Text { get; set; }
        [JsonProperty("description")]
        public TextAttribute Description { get; set; }
        [JsonProperty("url")]
        public TextAttribute Url { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}

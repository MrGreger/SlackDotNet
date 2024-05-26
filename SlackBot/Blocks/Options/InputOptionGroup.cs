using System.Collections.Generic;
using Newtonsoft.Json;

namespace HttpSlackBot.Blocks.Checkbox
{
    public class InputOptionGroup : IOptionPayload
    {
        [JsonProperty("label")]
        public PlainText Label { get; set; }
        [JsonProperty("options")]
        public IList<InputOption> Options { get; set; } 
    }
}
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SlackBot.Blocks.Checkbox
{
    public class InputOptionGroup : IOptionPayload
    {
        [JsonPropertyName("label")]
        public PlainText Label { get; set; }
        [JsonPropertyName("options")]
        public IList<InputOption> Options { get; set; } 
    }
}
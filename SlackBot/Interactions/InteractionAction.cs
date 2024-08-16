using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlackBot.Interactions
{
    public class InteractionAction
    {
        [JsonPropertyName("action_id")]
        public string ActionId { get; set; }
        [JsonPropertyName("block_id")]
        public string BlockId { get; set; }
        [JsonPropertyName("value")]
        public string Value { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}

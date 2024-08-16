using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Nodes;

namespace SlackBot.Models
{
    public class Message
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }
        [JsonPropertyName("blocks")]
        public JsonNode[] Blocks { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("ts")]
        public string Ts { get; set; }
        [JsonPropertyName("thread_ts")]
        public string ThreadTs { get; set; }
    }
}

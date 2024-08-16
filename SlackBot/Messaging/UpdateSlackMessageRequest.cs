using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlackBot.Messaging
{
    public class UpdateSlackMessageRequest
    {
        [JsonPropertyName("channel")]
        public string Channel { get; set; }
        [JsonPropertyName("blocks")]
        public string Blocks { get; set; }
        [JsonPropertyName("text")]
        public string Text { get; set; }
        [JsonPropertyName("ts")]
        public string Ts { get; set; }
    }
}

using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlackBot.Models
{
    public class SlackChannel
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("is_im")]
        public bool IsIM { get; set; }
        [JsonPropertyName("user")]
        public string UserId { get; set; }
    }
}

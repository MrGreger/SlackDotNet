using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace SlackBot.Messaging
{
    public class EphemeralMessage : SlackMessage
    {
        [JsonPropertyName("attachments")]
        public object[] Attachments { get; set; }
        [JsonPropertyName("user")]
        public string User { get; set; }
    }
}

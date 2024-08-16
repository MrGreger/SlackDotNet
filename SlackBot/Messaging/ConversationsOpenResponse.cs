using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
using SlackBot.Models;

namespace SlackBot.Messaging
{
    public class ConversationsOpenResponse : SlackResponseBase<SlackChannel>
    {
        [JsonPropertyName("channel")]
        public override SlackChannel Content { get; set; }
    }
}

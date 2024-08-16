using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
using SlackBot.Models;

namespace SlackBot.Messaging
{
    public class ChatPostMessageResponse : SlackResponseBase<Message>
    {
        [JsonPropertyName("message")]
        public override Message Content { get; set; }
    }
}

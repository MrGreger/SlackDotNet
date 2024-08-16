using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using SlackBot.Models;

namespace SlackBot.Messaging
{
    public class ChatPostMessageResponse : SlackResponseBase<Message>
    {
        [JsonProperty("message")]
        public override Message Content { get; set; }
    }
}

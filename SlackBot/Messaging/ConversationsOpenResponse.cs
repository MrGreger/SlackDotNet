using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using SlackBot.Models;

namespace SlackBot.Messaging
{
    public class ConversationsOpenResponse : SlackResponseBase<SlackChannel>
    {
        [JsonProperty("channel")]
        public override SlackChannel Content { get; set; }
    }
}

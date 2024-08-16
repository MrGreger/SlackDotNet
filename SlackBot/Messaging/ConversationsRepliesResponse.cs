using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using SlackBot.Models;

namespace SlackBot.Messaging
{
    public class ConversationsRepliesResponse : SlackResponseBase<IEnumerable<Message>>
    {
        [JsonProperty("messages")]
        public override IEnumerable<Message> Content { get; set; }
    }
}

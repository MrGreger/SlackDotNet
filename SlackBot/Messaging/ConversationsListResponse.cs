using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using SlackBot.Models;

namespace SlackBot.Messaging
{
    public class ConversationsListResponse : SlackResponseBase<IEnumerable<SlackChannel>>
    {
        [JsonProperty("channels")]
        public override IEnumerable<SlackChannel> Content { get; set; }
    }
}

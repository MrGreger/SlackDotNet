using System.Collections.Generic;
using Newtonsoft.Json;
using SlackBotDotNet.Models;

namespace SlackBotDotNet.Messaging
{
    public class ConversationsRepliesResponse : SlackResponseBase<IEnumerable<Message>>
    {
        [JsonProperty("messages")]
        public override IEnumerable<Message> Content { get; set; }
    }
}

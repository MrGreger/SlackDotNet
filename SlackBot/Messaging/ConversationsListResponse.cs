using System.Collections.Generic;
using Newtonsoft.Json;
using SlackBotDotNet.Models;

namespace SlackBotDotNet.Messaging
{
    public class ConversationsListResponse : SlackResponseBase<IEnumerable<SlackChannel>>
    {
        [JsonProperty("channels")]
        public override IEnumerable<SlackChannel> Content { get; set; }
    }
}

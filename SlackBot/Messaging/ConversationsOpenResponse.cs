using Newtonsoft.Json;
using SlackBotDotNet.Models;

namespace SlackBotDotNet.Messaging
{
    public class ConversationsOpenResponse : SlackResponseBase<SlackChannel>
    {
        [JsonProperty("channel")]
        public override SlackChannel Content { get; set; }
    }
}

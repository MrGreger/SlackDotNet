using Newtonsoft.Json;
using SlackBotDotNet.Models;

namespace SlackBotDotNet.Messaging
{
    public class ChatPostMessageResponse : SlackResponseBase<Message>
    {
        [JsonProperty("message")]
        public override Message Content { get; set; }
    }
}

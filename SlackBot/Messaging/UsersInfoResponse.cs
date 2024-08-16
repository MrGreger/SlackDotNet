using Newtonsoft.Json;
using SlackBotDotNet.Models;

namespace SlackBotDotNet.Messaging
{
    public class UsersInfoResponse : SlackResponseBase<User>
    {
        [JsonProperty("user")]
        public override User Content { get; set; }
    }
}

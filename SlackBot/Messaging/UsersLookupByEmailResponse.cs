using Newtonsoft.Json;
using SlackBotDotNet.Models;

namespace SlackBotDotNet.Messaging
{
    public class UsersLookupByEmailResponse : SlackResponseBase<User>
    {
        [JsonProperty("user")]
        public override User Content { get; set; }
    }
}

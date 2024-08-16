using System.Collections.Generic;
using Newtonsoft.Json;
using SlackBotDotNet.Models;

namespace SlackBotDotNet.Messaging
{
    public class UsersListResult : SlackResponseBase<IEnumerable<User>>
    {
        [JsonProperty("members")]
        public override IEnumerable<User> Content { get; set; }
    }
}

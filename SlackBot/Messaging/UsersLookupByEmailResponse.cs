using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using SlackBot.Models;

namespace SlackBot.Messaging
{
    public class UsersLookupByEmailResponse : SlackResponseBase<User>
    {
        [JsonProperty("user")]
        public override User Content { get; set; }
    }
}

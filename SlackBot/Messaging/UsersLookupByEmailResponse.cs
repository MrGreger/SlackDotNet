using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
using SlackBot.Models;

namespace SlackBot.Messaging
{
    public class UsersLookupByEmailResponse : SlackResponseBase<User>
    {
        [JsonPropertyName("user")]
        public override User Content { get; set; }
    }
}

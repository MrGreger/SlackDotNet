﻿using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
using SlackBot.Models;

namespace SlackBot.Messaging
{
    public class UsersListResult : SlackResponseBase<IEnumerable<User>>
    {
        [JsonPropertyName("members")]
        public override IEnumerable<User> Content { get; set; }
    }
}

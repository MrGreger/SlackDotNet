using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlackBot.Messaging
{
    public class SlackResponseBase
    {
        [JsonPropertyName("ok")]
        public bool Success { get; set; }
    }

    public abstract class SlackResponseBase<T> : SlackResponseBase
    {
        public abstract T Content { get; set; }
    }
}

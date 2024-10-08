﻿using Newtonsoft.Json;

namespace SlackBotDotNet.Messaging
{
    public class SlackResponseBase
    {
        [JsonProperty("ok")]
        public bool Success { get; set; }
        [JsonProperty("error")]
        public string ErrorMessage { get; set; }
        [JsonProperty("response_metadata")]
        public SlackResponseMetadata Metadata { get; set; }
    }

    public class SlackResponseMetadata
    {
        [JsonProperty("warnings")]
        public string[] Warnings { get; set; }
        [JsonProperty("messages")]
        public string[] Messages { get; set; }
    }

    public abstract class SlackResponseBase<T> : SlackResponseBase
    {
        public abstract T Content { get; set; }
    }
}
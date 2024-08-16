using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlackBot.Messaging
{
    public class SlackResponseBase
    {
        [JsonProperty("ok")]
        public bool Success { get; set; }
        [JsonPropertyName("error")]
        public string ErrorMessage { get; set; }
        [JsonPropertyName("response_metadata")]
        public SlackResponseMetadata Metadata { get; set; }
    }

    public class SlackResponseMetadata
    {
        [JsonPropertyName("warnings")]
        public string[] Warnings { get; set; }
        [JsonPropertyName("messages")]
        public string[] Messages { get; set; }
    }

    public abstract class SlackResponseBase<T> : SlackResponseBase
    {
        public abstract T Content { get; set; }
    }
}
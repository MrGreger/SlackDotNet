using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlackBot.Interactions
{
    public class InteractionState<T>
    {
        [JsonPropertyName("values")]
        public T Values { get; set; }
    }
}

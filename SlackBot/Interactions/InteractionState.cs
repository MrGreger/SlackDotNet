using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlackBot.Interactions
{
    public class InteractionState<T>
    {
        [JsonProperty("values")]
        public T Values { get; set; }
    }
}

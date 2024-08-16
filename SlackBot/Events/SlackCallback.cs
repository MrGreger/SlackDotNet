using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using SlackBot.Helpers;

namespace SlackBot.Events
{
    public class SlackCallback
    {
        public string Type { get; set; }
        public string Challenge { get; set; }
        
        public SlackBaseEvent Event => EventObject.Deserialize<SlackBaseEvent>(SlackSerialization.SerializerOptions);
        [JsonPropertyName("event")]
        public JsonNode
            EventObject { get; set; }
    }
}

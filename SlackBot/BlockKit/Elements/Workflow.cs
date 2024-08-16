using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SlackBot.Blocks.Elements
{
    public class Workflow
    {
        public class WorkflowTrigger
        {
            public class TriggerInputParameter
            {
                [JsonPropertyName("name")]
                public string Name { get; set; }
                [JsonPropertyName("value")]
                public string Value { get; set; }
            }
            
            [JsonPropertyName("url")]
            public string Url { get; set; }
            [JsonPropertyName("customizable_input_parameters")]
            public List<TriggerInputParameter> InputParameters { get; set; } = new List<TriggerInputParameter>();
        }
        
        [JsonPropertyName("trigger")]
        public WorkflowTrigger Trigger { get; set; }
    }
}
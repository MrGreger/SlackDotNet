using System.Collections.Generic;
using Newtonsoft.Json;

namespace SlackBot.Blocks.Elements
{
    public class Workflow
    {
        public class WorkflowTrigger
        {
            public class TriggerInputParameter
            {
                [JsonProperty("name")]
                public string Name { get; set; }
                [JsonProperty("value")]
                public string Value { get; set; }
            }
            
            [JsonProperty("url")]
            public string Url { get; set; }
            [JsonProperty("customizable_input_parameters")]
            public List<TriggerInputParameter> InputParameters { get; set; } = new List<TriggerInputParameter>();
        }
        
        [JsonProperty("trigger")]
        public WorkflowTrigger Trigger { get; set; }
    }
}
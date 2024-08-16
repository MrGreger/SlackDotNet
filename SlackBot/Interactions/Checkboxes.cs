using SlackBot.Blocks;
using SlackBot.Blocks.Checkbox;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlackBot.Interactions.Elements
{
    public class Checkboxes
    {
        public class CheckboxesAction
        {
            [JsonPropertyName("selected_options")]
            public CheckboxOption[] Options { get; set; }
            [JsonPropertyName("type")]
            public string Type { get; set; }
        }

        public class CheckboxOption
        {
            [JsonPropertyName("value")]
            public string Value
            {
                get;
                set;
            }
        }

        [JsonPropertyName("checkboxes-action")]
        public CheckboxesAction InputAction { get; set; }

        public IEnumerable<CheckboxOption> SelectedOptions => InputAction.Options;
        public string Type => InputAction.Type;
    }
}

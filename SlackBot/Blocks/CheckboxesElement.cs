using HttpSlackBot.Blocks;
using HttpSlackBot.Blocks.Checkbox;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HttpSlackBot.Interactions.Elements
{
    public class CheckboxesElement
    {
        public class CheckboxesElementAction
        {
            [JsonProperty("selected_options")]
            public CheckboxOption[] Options { get; set; }
            [JsonProperty("type")]
            public string Type { get; set; }
        }

        public class CheckboxOption
        {
            [JsonProperty("value")]
            public string Value
            {
                get;
                set;
            }
        }

        [JsonProperty("checkboxes-action")]
        public CheckboxesElementAction InputAction { get; set; }

        public IEnumerable<CheckboxOption> SelectedOptions => InputAction.Options;
        public string Type => InputAction.Type;
    }
}

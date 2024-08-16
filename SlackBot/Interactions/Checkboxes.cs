﻿using SlackBot.Blocks;
using SlackBot.Blocks.Checkbox;
using Newtonsoft.Json;
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
        public CheckboxesAction InputAction { get; set; }

        public IEnumerable<CheckboxOption> SelectedOptions => InputAction.Options;
        public string Type => InputAction.Type;
    }
}

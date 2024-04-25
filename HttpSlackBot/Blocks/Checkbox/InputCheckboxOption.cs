﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HttpSlackBot.Blocks.Checkbox
{
    public class InputCheckboxOption
    {
        private CheckboxValue _value;

        [JsonProperty("text")]
        public PlainTextSection TextSection { get; set; } = new PlainTextSection(true);
        [JsonProperty("value")]
        public string SerializedValue { get; private set; }
        [JsonIgnore]
        public CheckboxValue Option
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                SerializedValue = JsonConvert.SerializeObject(_value);
            }
        }
    }
}

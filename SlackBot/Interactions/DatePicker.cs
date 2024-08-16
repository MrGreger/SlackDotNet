using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlackBot.Interactions.Elements
{
    public class DatePicker
    {
        public class DatePickerAction
        {
            [JsonPropertyName("selected_date")]
            public DateTime? SelectedDate { get; set; }
            [JsonPropertyName("type")]
            public string Type { get; set; }
        }

        [JsonPropertyName("datepicker-action")]
        public DatePickerAction InputAction { get; set; }

        public DateTime? SelectedDate => InputAction.SelectedDate;
        public string Type => InputAction.Type;
    }
}

using System;
using Newtonsoft.Json;

namespace SlackBotDotNet.Interactions
{
    public class DatePicker
    {
        public class DatePickerAction
        {
            [JsonProperty("selected_date")]
            public DateTime? SelectedDate { get; set; }
            [JsonProperty("type")]
            public string Type { get; set; }
        }

        [JsonProperty("datepicker-action")]
        public DatePickerAction InputAction { get; set; }

        public DateTime? SelectedDate => InputAction.SelectedDate;
        public string Type => InputAction.Type;
    }
}

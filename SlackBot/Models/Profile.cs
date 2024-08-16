using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlackBot.Models
{
    public class Profile
    {
        [JsonPropertyName("real_name")]
        public string RealName { get; set; }
    }
}

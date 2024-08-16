using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlackBot.Models
{
    public class Profile
    {
        [JsonProperty("real_name")]
        public string RealName { get; set; }
    }
}

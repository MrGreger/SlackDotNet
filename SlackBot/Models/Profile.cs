using Newtonsoft.Json;

namespace SlackBotDotNet.Models
{
    public class Profile
    {
        [JsonProperty("real_name")]
        public string RealName { get; set; }
    }
}

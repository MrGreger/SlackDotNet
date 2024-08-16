using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlackBot.Models
{
    public class User
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("team_id")]
        public string TeamId { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("profile")]
        public Profile Profile { get; set; }
        [JsonPropertyName("is_admin")]
        public bool IsAdmin { get; set; }
        [JsonPropertyName("is_owner")]
        public bool IsOwner { get; set; }
        [JsonPropertyName("is_primary_owner")]
        public bool IsPrimaryOwner { get; set; }
    }
}

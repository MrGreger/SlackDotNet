using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SlackBot.Helpers
{
    public static class SlackSerialization
    {
        public static JsonSerializerOptions SerializerOptions = new JsonSerializerOptions()
                                                                {
                                                                    DefaultIgnoreCondition =
                                                                        JsonIgnoreCondition.WhenWritingNull,
                                                                    WriteIndented = true
                                                                };

        public static T Deserialize<T>(string text)
        {
            return JsonSerializer.Deserialize<T>(text, SerializerOptions);
        }

        public static string Serialize<T>(T @object)
        {
            return JsonSerializer.Serialize(@object, SerializerOptions);
        }
    }
}
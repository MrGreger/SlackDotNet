using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using SlackBot.Helpers;
using SlackBot.Models;

namespace SlackBot.Interactions
{
    public class InteractionEvent
    {
        [JsonPropertyName("channel")]
        public SlackChannel Channel { get; set; }
        [JsonPropertyName("user")]
        public User User { get; set; }
        [JsonPropertyName("state")]
        public JsonNode SerializedState { get; set; }
        [JsonPropertyName("message")]
        public Message Message { get; set; }
        [JsonPropertyName("actions")]
        public InteractionAction[] InteractionActions { get; set; }
        public InteractionAction Action => InteractionActions?.First();
    }

    public class InteractionEvent<TState> : InteractionEvent
    {
        public static InteractionEvent<TState> FromBaseEvent(InteractionEvent baseEvent)
        {
            var serialized = SlackSerialization.Serialize(baseEvent);
            return SlackSerialization.Deserialize<InteractionEvent<TState>>(serialized);
        }

        private InteractionState<TState> _state;
        public InteractionState<TState> State
        {
            get
            {
                if (SerializedState == null)
                {
                    return null;
                }

                if (_state == null)
                {
                    _state =
                        SerializedState.Deserialize<InteractionState<TState>>(SlackSerialization.SerializerOptions);
                }

                return _state;
            }
        }
    }
}
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
using SlackBot.Blocks.Actions;
using SlackBot.Blocks.BaseBlocks;
using SlackBot.Blocks.Elements;

namespace SlackBot.Blocks
{
    public class PlainTextInput : ElementBase, IInputElement
    {
        public override string Type => ElementTypes.PlainTextInput;
        [JsonPropertyName("action_id")]
        public string ActionId { get; set; }
        [JsonPropertyName("multiline")]
        public bool Multiline { get; set; }
        [JsonPropertyName("initial_value")]
        public string InitialValue { get; set; }
        [JsonPropertyName("min_length")]
        public int MinLength { get; set; }
        [JsonPropertyName("max_length")]
        public int MaxLength { get; set; }
        [JsonPropertyName("dispatch_action_config")]
        public DispatchActionsConfig DispatchActions { get; set; }
        [JsonPropertyName("focus_on_load")]
        public bool FocusOnLoad { get; set; }
        [JsonPropertyName("placeholder")]
        public PlainText Placeholder { get; set; }
    }
}
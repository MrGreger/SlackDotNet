﻿using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
using SlackBot.Blocks.BaseBlocks;
using SlackBot.Blocks.Elements;

namespace SlackBot.Blocks
{
    public class Button : ElementBase, ISectionElement, IActionsElement
    {
        public class Styles
        {
            public const string Primary = "primary";
            public const string Danger = "danger";
        }

        public override string Type => ElementTypes.Button;
        [JsonPropertyName("text")]
        public PlainText Content { get; set; }
        [JsonPropertyName("action_id")]
        public string ActionId { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
        [JsonPropertyName("value")]
        public string Value { get; set; }
        [JsonPropertyName("style")]
        public string Style { get; set; }
        [JsonPropertyName("accessibility_label")]
        public string AccessibilityLabel { get; set; }
    }
}

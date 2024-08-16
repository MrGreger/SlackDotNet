using SlackBot.Blocks.BaseBlocks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlackBot.Blocks
{
    public class PlainTextBlock : Section
    {
        public PlainTextBlock(bool withEmoji)
        {
            Text = new TextAttribute(TextType.Plain.ConvertToString(), withEmoji);
        }

        public PlainTextBlock(string text, bool withEmoji = false) : this(withEmoji)
        {
            Text.Value = text;
        }
    }
}

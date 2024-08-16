using HttpSlackBot.Blocks.BaseBlocks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HttpSlackBot.Blocks
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

using SlackBot.Blocks.BaseBlocks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlackBot.Blocks
{
    public class MarkdownTextBlock : Section
    {
        public MarkdownTextBlock(bool withEmoji)
        {
            Text = new TextAttribute(TextType.Markdown.ConvertToString(), withEmoji);
        }

        public override string Type => BlockTypes.Section;
    }
}

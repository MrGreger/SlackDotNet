using System;

namespace SlackBot.Blocks
{
    public enum TextType
    {
        Markdown,
        Plain
    }
    
    public static class TextTypeStrings
    {
        public const string Markdown = "mrkdwn";
        public const string Plain = "plain_text";

        public static string ConvertToString(this TextType textType)
        {
            return textType switch
            {
                TextType.Markdown => Markdown,
                TextType.Plain => Plain,
                _ => throw new ArgumentOutOfRangeException(nameof(textType), textType, null)
            };
        }
    }
}
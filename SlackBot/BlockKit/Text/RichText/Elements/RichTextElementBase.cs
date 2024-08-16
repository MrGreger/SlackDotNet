namespace SlackBotDotNet.BlockKit.Text.RichText.Elements
{
    public class RichTextElementTypes
    {
        public const string Channel = "channel";
        public const string Emoji = "emoji";
        public const string Link = "link";
        public const string Text = "text";
        public const string User = "user";
        public const string UserGroup = "usergroup";
    }
    
    public abstract class RichTextElementBase
    {
        public abstract string Type { get; }
    }
}
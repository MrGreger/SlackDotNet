namespace SlackBotDotNet.BlockKit.Text.RichText
{
    public class RichTextSectionTypes
    {
        public const string TextSection = "rich_text_section";
        public const string ListSection = "rich_text_list";
        public const string PreformatedSection = "rich_text_preformatted";
        public const string QuoteSection = "rich_text_quote";
    }
    
    public abstract class RichTextSectionBase
    {
        public abstract string Type { get; }
    }
}
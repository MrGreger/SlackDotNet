namespace HttpSlackBot.Blocks.Builders
{
    public interface IOverflowMenuOptionConfigurator
    {
        IOverflowMenuOptionConfigurator WithText(string text, bool emoji = true);
        IOverflowMenuOptionConfigurator WithDescription(string text, bool emoji = true);
        IOverflowMenuOptionConfigurator WithValue(string text);
        IOverflowMenuOptionConfigurator WithUrl(string url);
    }
    
    public class OverflowMenuOptionBuilder
    {
        
    }
}
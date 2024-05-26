using HttpSlackBot.Blocks.Checkbox;

namespace HttpSlackBot.Blocks.Builders
{
    public interface IOverflowMenuOptionConfigurator
    {
        IOverflowMenuOptionConfigurator WithText(string text, bool emoji = true);
        IOverflowMenuOptionConfigurator WithDescription(string text, bool emoji = true);
        IOverflowMenuOptionConfigurator WithValue(string text);
        IOverflowMenuOptionConfigurator WithUrl(string url);
    }

    public class OverflowMenuOptionBuilder : IOverflowMenuOptionConfigurator
    {
        private InputOption _inputOption = new InputOption();

        public IOverflowMenuOptionConfigurator WithText(string text, bool emoji = true)
        {
            _inputOption.Text = new PlainText(emoji)
            {
                Value = text
            };
            return this;
        }

        public IOverflowMenuOptionConfigurator WithDescription(string text, bool emoji = true)
        {
            _inputOption.Description = new PlainText(emoji)
            {
                Value = text
            };
            return this;
        }

        public IOverflowMenuOptionConfigurator WithValue(string text)
        {
            _inputOption.Value = text;
            return this;
        }

        public IOverflowMenuOptionConfigurator WithUrl(string url)
        {
            _inputOption.Url = url;
            return this;
        }

        public InputOption Build()
        {
            return _inputOption;
        }
    }
}
using HttpSlackBot.Blocks.Checkbox;

namespace HttpSlackBot.Blocks.Builders
{
    public interface ICheckboxOptionConfigurator
    {
        ICheckboxOptionConfigurator WithText(string text, TextType textType = TextType.Plain, bool emoji = true);
        ICheckboxOptionConfigurator WithDescription(string text, TextType textType = TextType.Plain, bool emoji = true);
        ICheckboxOptionConfigurator WithValue(string value);
        ICheckboxOptionConfigurator Selected(bool selected = true);
    }

    public class CheckboxOptionBuilder : ICheckboxOptionConfigurator
    {
        private bool _selected = false;

        private InputOption _inputOption = new InputOption();
        
        public ICheckboxOptionConfigurator WithText(string text, TextType textType = TextType.Plain, bool emoji = true)
        {
            _inputOption.Text = new TextAttribute(textType.ConvertToString(), emoji)
            {
                Value = text
            };

            return this;
        }

        public ICheckboxOptionConfigurator WithDescription(string text, TextType textType = TextType.Plain, bool emoji = true)
        {
            _inputOption.Description = new TextAttribute(textType.ConvertToString(), emoji)
            {
                Value = text
            };

            return this;
        }

        public ICheckboxOptionConfigurator WithValue(string value)
        {
            _inputOption.Value = value;
            
            return this;
        }

        public ICheckboxOptionConfigurator Selected(bool selected = true)
        {
            _selected = selected;
            return this;
        }

        public (InputOption Option, bool Selected) Build()
        {
            return (_inputOption, _selected);
        }
    }
}
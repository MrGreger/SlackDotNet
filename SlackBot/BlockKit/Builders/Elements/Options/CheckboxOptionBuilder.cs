using System;
using SlackBotDotNet.BlockKit.Builders.Text;
using SlackBotDotNet.BlockKit.Options;

namespace SlackBotDotNet.BlockKit.Builders.Elements.Options
{
    public interface ICheckboxOptionConfigurator
    {
        ICheckboxOptionConfigurator WithText(Action<ITextObjectConfigurator> configurator);
        ICheckboxOptionConfigurator WithDescription(Action<ITextObjectConfigurator> configurator);
        ICheckboxOptionConfigurator WithValue(string value);
        ICheckboxOptionConfigurator Selected(bool selected = true);
    }

    public class CheckboxOptionBuilder : ICheckboxOptionConfigurator
    {
        private bool _selected = false;

        private InputOption _inputOption = new InputOption();
        
        public ICheckboxOptionConfigurator WithText(Action<ITextObjectConfigurator> configurator)
        {
            var builder = new TextObjectObjectBuilder();
            
            configurator.Invoke(builder);

            _inputOption.Text = builder.Build();

            return this;
        }

        public ICheckboxOptionConfigurator WithDescription(Action<ITextObjectConfigurator> configurator)
        {
            var builder = new TextObjectObjectBuilder();
            
            configurator.Invoke(builder);

            _inputOption.Description = builder.Build();

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
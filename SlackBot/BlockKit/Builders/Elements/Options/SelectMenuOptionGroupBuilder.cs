using System;
using System.Collections.Generic;
using SlackBotDotNet.BlockKit.Options;
using SlackBotDotNet.BlockKit.Text;

namespace SlackBotDotNet.BlockKit.Builders.Elements.Options
{
    public interface ISelectMenuOptionGroupConfigurator
    {
        ISelectMenuOptionGroupConfigurator WithLabel(string text, bool emoji = true);
        ISelectMenuOptionGroupConfigurator AddOption(Action<ISelectMenuOptionConfigurator> builder);
        ISelectMenuOptionGroupConfigurator Initial(bool initial = true);
    }

    public class SelectMenuOptionGroupBuilder : ISelectMenuOptionGroupConfigurator
    {
        private InputOptionGroup _optionGroup = new InputOptionGroup();
        private bool _initial = false;
        
        public ISelectMenuOptionGroupConfigurator WithLabel(string text, bool emoji = true)
        {
            _optionGroup.Label = new PlainText(emoji)
            {
                Value = text
            };

            return this;
        }

        public ISelectMenuOptionGroupConfigurator AddOption(Action<ISelectMenuOptionConfigurator> builder)
        {
            if (_optionGroup.Options == null)
            {
                _optionGroup.Options = new List<InputOption>();
            }

            var optionBuilder = new SelectMenuOptionBuilder();
            
            builder.Invoke(optionBuilder);

            var option = optionBuilder.Build();
            
            _optionGroup.Options.Add(option.Option);
            
            return this;
        }

        public ISelectMenuOptionGroupConfigurator Initial(bool initial = true)
        {
            _initial = true;

            return this;
        }

        public (InputOptionGroup Group, bool Initial) Build()
        {
            return (_optionGroup, _initial);
        }
    }
}
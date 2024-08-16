using System;
using SlackBotDotNet.BlockKit.Builders.Elements.Options;

namespace SlackBotDotNet.BlockKit.Builders.Elements.Checkboxes
{
    public interface ICheckboxesConfigurator
    {
        ICheckboxesConfigurator AddOption(Action<ICheckboxOptionConfigurator> builder);
    }
    
    public class CheckboxesBuilder : ICheckboxesConfigurator
    {
        private BlockKit.Elements.Checkboxes _checkboxes = new BlockKit.Elements.Checkboxes();
        
        public ICheckboxesConfigurator AddOption(Action<ICheckboxOptionConfigurator> builder)
        {
            var optionBuilder = new CheckboxOptionBuilder();

            builder.Invoke(optionBuilder);

            var option = optionBuilder.Build();
            
            _checkboxes.Options.Add(option.Option);
            if (option.Selected)
            {
                _checkboxes.InitialOptions.Add(option.Option);
            }

            return this;
        }

        public BlockKit.Elements.Checkboxes Build()
        {
            return _checkboxes;
        }
    }
}
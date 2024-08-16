using System;

namespace SlackBot.Blocks.Builders.Checkboxes
{
    public interface ICheckboxesConfigurator
    {
        ICheckboxesConfigurator AddOption(Action<ICheckboxOptionConfigurator> builder);
    }
    
    public class CheckboxesBuilder : ICheckboxesConfigurator
    {
        private Checkbox.Checkboxes _checkboxes = new Checkbox.Checkboxes();
        
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

        public Checkbox.Checkboxes Build()
        {
            return _checkboxes;
        }
    }
}
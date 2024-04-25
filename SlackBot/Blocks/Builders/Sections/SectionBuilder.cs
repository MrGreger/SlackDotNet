using System;
using HttpSlackBot.Blocks.BaseBlocks;
using HttpSlackBot.Blocks.Builders.Checkboxes;

namespace HttpSlackBot.Blocks.Builders
{
    public interface ISectionConfigurator
    {
        
    }
    
    public class SectionBuilder : ISectionConfigurator
    {
        private Section _section = new Section();

        public ISectionConfigurator WithButton(Action<IButtonConfigurator> builder)
        {
            var buttonBuilder = new ButtonBuilder();

            builder.Invoke(buttonBuilder);

            _section.Acessory = buttonBuilder.Build();
            
            return this;
        }

        public ISectionConfigurator WithCheckBoxes(Action<ICheckboxesConfigurator> builder)
        {
            var checkboxesBuilder = new CheckboxesBuilder();
            
            builder.Invoke(checkboxesBuilder);
            
            _section.Acessory = checkboxesBuilder.Build();
            
            return this;
        }
        
        public Section Build()
        {
            return _section;
        }
    }
}
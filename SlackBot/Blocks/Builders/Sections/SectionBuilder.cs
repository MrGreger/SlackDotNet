using System;
using HttpSlackBot.Blocks.BaseBlocks;
using HttpSlackBot.Blocks.Builders.Checkboxes;
using HttpSlackBot.Blocks.Builders.Workflow;

namespace HttpSlackBot.Blocks.Builders
{
    public interface ISectionConfigurator : IButtonContainer<ISectionConfigurator>,
                                            ICheckboxesContainer<ISectionConfigurator>,
                                            IDatePickerContainer<ISectionConfigurator>,
                                            IImageContainer<ISectionConfigurator>,
                                            IMultiSelectMenuContainer<ISectionConfigurator>,
                                            IOverflowMenuContainer<ISectionConfigurator>,
                                            IRadioButtonsContainer<ISectionConfigurator>,
                                            ISelectMenuContainer<ISectionConfigurator>,
                                            ITimePickerContainer<ISectionConfigurator>,
                                            IWorkflowButtonContainer<ISectionConfigurator>
    {
        ISectionConfigurator WithText(string text, TextType type, bool emoji= true);
        ISectionConfigurator WithField(string text, TextType type, bool emoji= true);
        ISectionConfigurator WithBlockId(string id);
    }

    public class SectionBuilder : ISectionConfigurator
    {
        private Section _section = new Section();

        public ISectionConfigurator WithButton(Action<IButtonConfigurator> builder)
        {
            var buttonBuilder = new ButtonBuilder();

            builder.Invoke(buttonBuilder);

            _section.Accessory = buttonBuilder.Build();

            return this;
        }

        public ISectionConfigurator WithCheckboxes(Action<ICheckboxesConfigurator> builder)
        {
            var checkboxesBuilder = new CheckboxesBuilder();

            builder.Invoke(checkboxesBuilder);

            _section.Accessory = checkboxesBuilder.Build();

            return this;
        }

        public ISectionConfigurator WithDatePicker(Action<IDatePickerConfigurator> builder)
        {
            var datePickerBuilder = new DatePickerBuilder();

            builder.Invoke(datePickerBuilder);

            _section.Accessory = datePickerBuilder.Build();

            return this;
        }

        public ISectionConfigurator WithImage(Action<IImageConfigurator> builder)
        {
            var imageBuilder = new ImageBuilder();

            builder.Invoke(imageBuilder);

            _section.Accessory = imageBuilder.Build();

            return this;
        }

        public ISectionConfigurator WithMultiSelectMenu(Action<IMultiSelectMenuConfigurator> builder)
        {
            var multiSelectMenuBuilder = new MultiSelectMenuBuilder();

            builder.Invoke(multiSelectMenuBuilder);

            _section.Accessory = multiSelectMenuBuilder.Build();

            return this;
        }

        public ISectionConfigurator WithOverflowMenu(Action<IOverflowMenuConfigurator> configurator)
        {
            var builder = new OverflowMenuBuilder();

            configurator.Invoke(builder);

            _section.Accessory = builder.Build();

            return this;
        }

        public ISectionConfigurator WithRadioButtons(Action<IRadioButtonsConfigurator> configurator)
        {
            var builder = new RadioButtonsBuilder();

            configurator.Invoke(builder);

            _section.Accessory = builder.Build();

            return this;
        }

        public ISectionConfigurator WithSelectMenu(Action<ISelectMenuConfigurator> configurator)
        {
            var builder = new SelectMenuBuilder();

            configurator.Invoke(builder);

            _section.Accessory = builder.Build();

            return this;
        }

        public ISectionConfigurator WithTimePicker(Action<ITimePickerConfigurator> configurator)
        {
            var builder = new TimePickerBuilder();

            configurator.Invoke(builder);

            _section.Accessory = builder.Build();

            return this;
        }

        public ISectionConfigurator WithWorkflowButton(Action<IWorkflowButtonConfigurator> configurator)
        {
            var builder = new WorkflowButtonBuilder();

            configurator.Invoke(builder);

            _section.Accessory = builder.Build();

            return this;
        }
        
        public ISectionConfigurator WithText(string text, TextType type, bool emoji = true)
        {
            _section.Text = new TextAttribute(type.ConvertToString(), emoji)
            {
                Value = text
            };

            return this;
        }

        public ISectionConfigurator WithField(string text, TextType type, bool emoji = true)
        {
            if (_section.Fields.Count >= 10)
            {
                throw new Exception("Max 10 elements");
            }
            
            _section.Fields.Add(new TextAttribute(type.ConvertToString(), emoji)
            {
                Value = text
            });

            return this;
        }

        public ISectionConfigurator WithBlockId(string id)
        {
            _section.BlockId = id;
            
            return this;
        }
        
        public Section Build()
        {
            return _section;
        }

    }
}
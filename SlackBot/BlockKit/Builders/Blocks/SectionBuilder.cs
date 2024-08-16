using System;
using System.Collections.Generic;
using SlackBot.Blocks.BaseBlocks;
using SlackBot.Blocks.Builders.Checkboxes;
using SlackBot.Blocks.Builders.Text;
using SlackBot.Blocks.Builders.Workflow;
using ITextConfigurator = SlackBot.Blocks.Builders.RichText.Elements.ITextConfigurator;

namespace SlackBot.Blocks.Builders
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
        ISectionConfigurator WithText(Action<ITextObjectConfigurator> configurator);
        ISectionConfigurator WithField(Action<ITextObjectConfigurator> configurator);
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

        public ISectionConfigurator WithText(Action<ITextObjectConfigurator> configurator)
        {
            var builder = new TextObjectObjectBuilder();

            configurator.Invoke(builder);

            _section.Text = builder.Build();

            return this;
        }

        public ISectionConfigurator WithField(Action<ITextObjectConfigurator> configurator)
        {
            if (_section != null && _section.Fields.Count >= 10)
            {
                throw new Exception("Max 10 elements");
            }

            if (_section.Fields == null)
            {
                _section.Fields = new List<TextAttribute>();
            }
            
            var builder = new TextObjectObjectBuilder();

            configurator.Invoke(builder);

            _section.Fields.Add(builder.Build());

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
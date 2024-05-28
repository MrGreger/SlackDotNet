using System;
using HttpSlackBot.Blocks.Builders.Checkboxes;

namespace HttpSlackBot.Blocks.Builders
{
    public interface IInputSectionConfigurator : ICheckboxesContainer<IInputSectionConfigurator>,
                                                 IDatePickerContainer<IInputSectionConfigurator>,
                                                 IDateTimePickerContainer<IInputSectionConfigurator>,
                                                 IEmailInputContainer<IInputSectionConfigurator>,
                                                 IFileInputContainer<IInputSectionConfigurator>,
                                                 IMultiSelectMenuContainer<IInputSectionConfigurator>,
                                                 INumberInputContainer<IInputSectionConfigurator>,
                                                 IPlainTextInputContainer<IInputSectionConfigurator>,
                                                 IRadioButtonsContainer<IInputSectionConfigurator>,
                                                 IRichTextInputContainer<IInputSectionConfigurator>,
                                                 ISelectMenuContainer<IInputSectionConfigurator>,
                                                 ITimePickerContainer<IInputSectionConfigurator>,
                                                 IUrlInputContainer<IInputSectionConfigurator>
    {
        IInputSectionConfigurator WithLabel(string text, bool emoji = true);
        IInputSectionConfigurator DispatchActions(bool dispatch = true);
        IInputSectionConfigurator WithHint(string text, bool emoji = true);
        IInputSectionConfigurator Optional(bool optional = true);
        IInputSectionConfigurator WithId(string id);
    }

    public class InputSectionBuilder : IInputSectionConfigurator
    {
        private InputSection _section = new InputSection();

        public IInputSectionConfigurator WithCheckboxes(Action<ICheckboxesConfigurator> configurator)
        {
            var builder = new CheckboxesBuilder();

            configurator.Invoke(builder);

            _section.Element = builder.Build();

            return this;
        }

        public IInputSectionConfigurator WithDatePicker(Action<IDatePickerConfigurator> configurator)
        {
            var builder = new DatePickerBuilder();

            configurator.Invoke(builder);

            _section.Element = builder.Build();

            return this;
        }

        public IInputSectionConfigurator WithDateTimePicker(Action<IDateTimePickerConfigurator> configurator)
        {
            var builder = new DateTimePickerBuilder();

            configurator.Invoke(builder);

            _section.Element = builder.Build();

            return this;
        }

        public IInputSectionConfigurator WithEmailInputPicker(Action<IEmailInputConfigurator> configurator)
        {
            var builder = new EmailInputBuilder();

            configurator.Invoke(builder);

            _section.Element = builder.Build();

            return this;
        }

        public IInputSectionConfigurator WithFileInputPicker(Action<IFileInputConfigurator> configurator)
        {
            var builder = new FileInputBuilder();

            configurator.Invoke(builder);

            _section.Element = builder.Build();

            return this;
        }

        public IInputSectionConfigurator WithMultiSelectMenu(Action<IMultiSelectMenuConfigurator> configurator)
        {
            var builder = new MultiSelectMenuBuilder();

            configurator.Invoke(builder);

            _section.Element = builder.Build();

            return this;
        }

        public IInputSectionConfigurator WithNumberInput(Action<INumberInputConfigurator> configurator)
        {
            var builder = new NumberInputBuilder();

            configurator.Invoke(builder);

            _section.Element = builder.Build();

            return this;
        }

        public IInputSectionConfigurator WithPlainTextInput(Action<ITextInputConfigurator> configurator)
        {
            var builder = new TextInputBuilder();

            configurator.Invoke(builder);

            _section.Element = builder.Build();

            return this;
        }

        public IInputSectionConfigurator WithRadioButtons(Action<IRadioButtonsConfigurator> configurator)
        {
            var builder = new RadioButtonsBuilder();

            configurator.Invoke(builder);

            _section.Element = builder.Build();

            return this;
        }

        public IInputSectionConfigurator WithRichTextInput(Action<IRichTextInputConfigurator> configurator)
        {
            var builder = new RichTextInputBuilder();

            configurator.Invoke(builder);

            _section.Element = builder.Build();

            return this;
        }

        public IInputSectionConfigurator WithSelectMenu(Action<ISelectMenuConfigurator> configurator)
        {
            var builder = new SelectMenuBuilder();

            configurator.Invoke(builder);

            _section.Element = builder.Build();

            return this;
        }

        public IInputSectionConfigurator WithTimePicker(Action<ITimePickerConfigurator> configurator)
        {
            var builder = new TimePickerBuilder();

            configurator.Invoke(builder);

            _section.Element = builder.Build();

            return this;
        }

        public IInputSectionConfigurator WithUrlInput(Action<IUrlInputElementConfigurator> configurator)
        {
            var builder = new UrlInputElementBuilder();

            configurator.Invoke(builder);

            _section.Element = builder.Build();

            return this;
        }

        public IInputSectionConfigurator WithLabel(string text, bool emoji = true)
        {
            _section.Label = new PlainText(emoji)
            {
                Value = text
            };

            return this;
        }

        public IInputSectionConfigurator DispatchActions(bool dispatch = true)
        {
            _section.DispatchAction = dispatch;

            return this;
        }

        public IInputSectionConfigurator WithHint(string text, bool emoji = true)
        {
            _section.Hint = new PlainText(emoji)
            {
                Value = text
            };

            return this;
        }

        public IInputSectionConfigurator Optional(bool optional = true)
        {
            _section.Optional = optional;

            return this;
        }

        public IInputSectionConfigurator WithId(string id)
        {
            _section.BlockId = id;

            return this;
        }

        public InputSection Build()
        {
            return _section;
        }
    }
}
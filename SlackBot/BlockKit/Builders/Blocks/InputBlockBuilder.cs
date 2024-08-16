using System;
using SlackBot.Blocks.Builders.Checkboxes;

namespace SlackBot.Blocks.Builders
{
    public interface IInputBlockConfigurator : ICheckboxesContainer<IInputBlockConfigurator>,
                                                 IDatePickerContainer<IInputBlockConfigurator>,
                                                 IDateTimePickerContainer<IInputBlockConfigurator>,
                                                 IEmailInputContainer<IInputBlockConfigurator>,
                                                 IFileInputContainer<IInputBlockConfigurator>,
                                                 IMultiSelectMenuContainer<IInputBlockConfigurator>,
                                                 INumberInputContainer<IInputBlockConfigurator>,
                                                 IPlainTextInputContainer<IInputBlockConfigurator>,
                                                 IRadioButtonsContainer<IInputBlockConfigurator>,
                                                 IRichTextInputContainer<IInputBlockConfigurator>,
                                                 ISelectMenuContainer<IInputBlockConfigurator>,
                                                 ITimePickerContainer<IInputBlockConfigurator>,
                                                 IUrlInputContainer<IInputBlockConfigurator>
    {
        IInputBlockConfigurator WithLabel(string text, bool emoji = true);
        IInputBlockConfigurator DispatchActions(bool dispatch = true);
        IInputBlockConfigurator WithHint(string text, bool emoji = true);
        IInputBlockConfigurator Optional(bool optional = true);
        IInputBlockConfigurator WithId(string id);
    }

    public class InputBlockBuilder : IInputBlockConfigurator
    {
        private InputBlock _block = new InputBlock();

        public IInputBlockConfigurator WithCheckboxes(Action<ICheckboxesConfigurator> configurator)
        {
            var builder = new CheckboxesBuilder();

            configurator.Invoke(builder);

            _block.Element = builder.Build();

            return this;
        }

        public IInputBlockConfigurator WithDatePicker(Action<IDatePickerConfigurator> configurator)
        {
            var builder = new DatePickerBuilder();

            configurator.Invoke(builder);

            _block.Element = builder.Build();

            return this;
        }

        public IInputBlockConfigurator WithDateTimePicker(Action<IDateTimePickerConfigurator> configurator)
        {
            var builder = new DateTimePickerBuilder();

            configurator.Invoke(builder);

            _block.Element = builder.Build();

            return this;
        }

        public IInputBlockConfigurator WithEmailInputPicker(Action<IEmailInputConfigurator> configurator)
        {
            var builder = new EmailInputBuilder();

            configurator.Invoke(builder);

            _block.Element = builder.Build();

            return this;
        }

        public IInputBlockConfigurator WithFileInputPicker(Action<IFileInputConfigurator> configurator)
        {
            var builder = new FileInputBuilder();

            configurator.Invoke(builder);

            _block.Element = builder.Build();

            return this;
        }

        public IInputBlockConfigurator WithMultiSelectMenu(Action<IMultiSelectMenuConfigurator> configurator)
        {
            var builder = new MultiSelectMenuBuilder();

            configurator.Invoke(builder);

            _block.Element = builder.Build();

            return this;
        }

        public IInputBlockConfigurator WithNumberInput(Action<INumberInputConfigurator> configurator)
        {
            var builder = new NumberInputBuilder();

            configurator.Invoke(builder);

            _block.Element = builder.Build();

            return this;
        }

        public IInputBlockConfigurator WithPlainTextInput(Action<IPlainTextInputConfigurator> configurator)
        {
            var builder = new PlainTextInputBuilder();

            configurator.Invoke(builder);

            _block.Element = builder.Build();

            return this;
        }

        public IInputBlockConfigurator WithRadioButtons(Action<IRadioButtonsConfigurator> configurator)
        {
            var builder = new RadioButtonsBuilder();

            configurator.Invoke(builder);

            _block.Element = builder.Build();

            return this;
        }

        public IInputBlockConfigurator WithRichTextInput(Action<IRichTextInputConfigurator> configurator)
        {
            var builder = new RichTextInputBuilder();

            configurator.Invoke(builder);

            _block.Element = builder.Build();

            return this;
        }

        public IInputBlockConfigurator WithSelectMenu(Action<ISelectMenuConfigurator> configurator)
        {
            var builder = new SelectMenuBuilder();

            configurator.Invoke(builder);

            _block.Element = builder.Build();

            return this;
        }

        public IInputBlockConfigurator WithTimePicker(Action<ITimePickerConfigurator> configurator)
        {
            var builder = new TimePickerBuilder();

            configurator.Invoke(builder);

            _block.Element = builder.Build();

            return this;
        }

        public IInputBlockConfigurator WithUrlInput(Action<IUrlInputElementConfigurator> configurator)
        {
            var builder = new UrlInputElementBuilder();

            configurator.Invoke(builder);

            _block.Element = builder.Build();

            return this;
        }

        public IInputBlockConfigurator WithLabel(string text, bool emoji = true)
        {
            _block.Label = new PlainText(emoji)
            {
                Value = text
            };

            return this;
        }

        public IInputBlockConfigurator DispatchActions(bool dispatch = true)
        {
            _block.DispatchAction = dispatch;

            return this;
        }

        public IInputBlockConfigurator WithHint(string text, bool emoji = true)
        {
            _block.Hint = new PlainText(emoji)
            {
                Value = text
            };

            return this;
        }

        public IInputBlockConfigurator Optional(bool optional = true)
        {
            _block.Optional = optional;

            return this;
        }

        public IInputBlockConfigurator WithId(string id)
        {
            _block.BlockId = id;

            return this;
        }

        public InputBlock Build()
        {
            return _block;
        }
    }
}
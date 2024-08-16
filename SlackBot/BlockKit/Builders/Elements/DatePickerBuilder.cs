using System;

namespace SlackBot.Blocks.Builders
{
    public interface IDatePickerConfigurator
    {
        IDatePickerConfigurator WithActionId(string actionId);
        IDatePickerConfigurator WithPlaceholder(string text, bool emoji = true);
        IDatePickerConfigurator WithConfirmationDialog(Action<IConfirmationDialogConfigurator> builder);
        IDatePickerConfigurator FocusOnLoad(bool focus);
        IDatePickerConfigurator WithInitialDate(string date);
        IDatePickerConfigurator WithInitialDate(DateTime date);
    }

    public class DatePickerBuilder : IDatePickerConfigurator
    {
        private DatePicker _datePicker = new DatePicker();

        public IDatePickerConfigurator WithActionId(string actionId)
        {
            _datePicker.ActionId = actionId;
            return this;
        }

        public IDatePickerConfigurator WithPlaceholder(string text, bool emoji = true)
        {
            _datePicker.Placeholder = new PlainText(emoji)
            {
                Value = text
            };

            return this;
        }

        public IDatePickerConfigurator WithConfirmationDialog(Action<IConfirmationDialogConfigurator> builder)
        {
            var dialogBuilder = new ConfirmationDialogConfiguratorBuilder();

            builder.Invoke(dialogBuilder);

            _datePicker.ConfirmationDialog = dialogBuilder.Build();
            
            return this;
        }

        public IDatePickerConfigurator FocusOnLoad(bool focus)
        {
            _datePicker.FocusOnLoad = focus;

            return this;
        }

        public IDatePickerConfigurator WithInitialDate(string date)
        {
            _datePicker.InitialDate = date;

            return this;
        }

        public IDatePickerConfigurator WithInitialDate(DateTime date)
        {
            _datePicker.InitialDate = date.ToString("YYYY-MM-DD");

            return this;
        }

        public DatePicker Build()
        {
            return _datePicker;
        }
    }
}
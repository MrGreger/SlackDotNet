using System;
using SlackBot.Blocks.Elements;

namespace SlackBot.Blocks.Builders
{
    public interface IDateTimePickerConfigurator
    {
        IDateTimePickerConfigurator WithActionId(string actionId);
        IDateTimePickerConfigurator WithConfirmationDialog(Action<IConfirmationDialogConfigurator> builder);
        IDateTimePickerConfigurator FocusOnLoad(bool focus);
        IDateTimePickerConfigurator WithInitialDate(long date);
        IDateTimePickerConfigurator WithInitialDate(DateTime date);
    }

    public class DateTimePickerBuilder : IDateTimePickerConfigurator
    {
        private DateTimePicker _datePicker = new DateTimePicker();

        public IDateTimePickerConfigurator WithActionId(string actionId)
        {
            _datePicker.ActionId = actionId;
            return this;
        }

        public IDateTimePickerConfigurator WithConfirmationDialog(Action<IConfirmationDialogConfigurator> builder)
        {
            var dialogBuilder = new ConfirmationDialogConfiguratorBuilder();

            builder.Invoke(dialogBuilder);

            _datePicker.ConfirmationDialog = dialogBuilder.Build();

            return this;
        }

        public IDateTimePickerConfigurator FocusOnLoad(bool focus)
        {
            _datePicker.FocusOnLoad = focus;

            return this;
        }

        public IDateTimePickerConfigurator WithInitialDate(long date)
        {
            _datePicker.InitialDate = date;

            return this;
        }

        public IDateTimePickerConfigurator WithInitialDate(DateTime date)
        {
            _datePicker.InitialDate = ToUnixTime(date);

            return this;
        }

        public DateTimePicker Build()
        {
            return _datePicker;
        }

        private long ToUnixTime(DateTime date)
        {
            var timeSpan = (date - new DateTime(1970, 1, 1, 0, 0, 0));
            return (long)timeSpan.TotalSeconds;
        }
    }
}
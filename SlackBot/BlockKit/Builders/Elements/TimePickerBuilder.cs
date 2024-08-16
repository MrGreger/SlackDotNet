using System;
using SlackBot.Blocks.Elements;

namespace SlackBot.Blocks.Builders
{
    public interface ITimePickerConfigurator
    {
        ITimePickerConfigurator WithActionId(string action);
        ITimePickerConfigurator WithInitialValue(int hour, int minute);
        ITimePickerConfigurator WithConfirmationDialog(Action<IConfirmationDialogConfigurator> configurator);
        ITimePickerConfigurator FocusOnLoad(bool focus);
        ITimePickerConfigurator WithPlaceholder(string text, bool emoji = true);
        ITimePickerConfigurator WithTimezone(string timezone);
    }
    
    public class TimePickerBuilder : ITimePickerConfigurator
    {
        private TimePicker _timePicker = new TimePicker();
        
        public ITimePickerConfigurator WithActionId(string action)
        {
            _timePicker.ActionId = action;

            return this;
        }

        public ITimePickerConfigurator WithInitialValue(int hour, int minute)
        {
            _timePicker.InitialValue = $"{hour}:{minute}";

            return this;
        }

        public ITimePickerConfigurator WithConfirmationDialog(Action<IConfirmationDialogConfigurator> configurator)
        {
            var builder = new ConfirmationDialogConfiguratorBuilder();
            
            configurator.Invoke(builder);

            _timePicker.ConfirmationDialog = builder.Build();

            return this;
        }

        public ITimePickerConfigurator FocusOnLoad(bool focus)
        {
            _timePicker.FocusOnLoad = focus;

            return this;
        }

        public ITimePickerConfigurator WithPlaceholder(string text, bool emoji = true)
        {
            _timePicker.Placeholder = new PlainText(emoji)
            {
                Value = text
            };

            return this;
        }

        public ITimePickerConfigurator WithTimezone(string timezone)
        {
            _timePicker.Timezone = timezone;

            return this;
        }

        public TimePicker Build()
        {
            return _timePicker;
        }
    }
}
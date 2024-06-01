using System;
using HttpSlackBot.Blocks.Builders.Checkboxes;
using HttpSlackBot.Blocks.Builders.Workflow;

namespace HttpSlackBot.Blocks.Builders
{
    public interface IActionsSectionConfigurator : IButtonContainer<IActionsSectionConfigurator>,
                                              ICheckboxesContainer<IActionsSectionConfigurator>,
                                              IDatePickerContainer<IActionsSectionConfigurator>,
                                              IDateTimePickerContainer<IActionsSectionConfigurator>,
                                              IMultiSelectMenuContainer<IActionsSectionConfigurator>,
                                              IOverflowMenuContainer<IActionsSectionConfigurator>,
                                              IRadioButtonsContainer<IActionsSectionConfigurator>,
                                              ISelectMenuContainer<IActionsSectionConfigurator>,
                                              ITimePickerContainer<IActionsSectionConfigurator>,
                                              IWorkflowButtonContainer<IActionsSectionConfigurator>
    {
        IActionsSectionConfigurator WithId(string id);
    }

    public class ActionsSectionConfigurator : IActionsSectionConfigurator
    {
        private ActionsSection _actionsSection = new ActionsSection();

        public IActionsSectionConfigurator WithButton(Action<IButtonConfigurator> configurator)
        {
            var builder = new ButtonBuilder();

            configurator.Invoke(builder);

            _actionsSection.Elements.Add(builder.Build());

            return this;
        }

        public IActionsSectionConfigurator WithCheckboxes(Action<ICheckboxesConfigurator> configurator)
        {
            var builder = new CheckboxesBuilder();

            configurator.Invoke(builder);

            _actionsSection.Elements.Add(builder.Build());

            return this;
        }

        public IActionsSectionConfigurator WithDatePicker(Action<IDatePickerConfigurator> configurator)
        {
            var builder = new DatePickerBuilder();

            configurator.Invoke(builder);

            _actionsSection.Elements.Add(builder.Build());

            return this;
        }

        public IActionsSectionConfigurator WithDateTimePicker(Action<IDateTimePickerConfigurator> configurator)
        {
            var builder = new DateTimePickerBuilder();

            configurator.Invoke(builder);

            _actionsSection.Elements.Add(builder.Build());

            return this;
        }

        public IActionsSectionConfigurator WithMultiSelectMenu(Action<IMultiSelectMenuConfigurator> configurator)
        {
            var builder = new MultiSelectMenuBuilder();

            configurator.Invoke(builder);

            _actionsSection.Elements.Add(builder.Build());

            return this;
        }

        public IActionsSectionConfigurator WithOverflowMenu(Action<IOverflowMenuConfigurator> configurator)
        {
            var builder = new OverflowMenuBuilder();

            configurator.Invoke(builder);

            _actionsSection.Elements.Add(builder.Build());

            return this;
        }

        public IActionsSectionConfigurator WithRadioButtons(Action<IRadioButtonsConfigurator> configurator)
        {
            var builder = new RadioButtonsBuilder();

            configurator.Invoke(builder);

            _actionsSection.Elements.Add(builder.Build());
            
            return this;
        }

        public IActionsSectionConfigurator WithSelectMenu(Action<ISelectMenuConfigurator> configurator)
        {
            var builder = new SelectMenuBuilder();

            configurator.Invoke(builder);

            _actionsSection.Elements.Add(builder.Build());
            
            return this;
        }

        public IActionsSectionConfigurator WithTimePicker(Action<ITimePickerConfigurator> configurator)
        {
            var builder = new TimePickerBuilder();

            configurator.Invoke(builder);

            _actionsSection.Elements.Add(builder.Build());
            
            return this;
        }

        public IActionsSectionConfigurator WithWorkflowButton(Action<IWorkflowButtonConfigurator> configurator)
        {
            var builder = new WorkflowButtonBuilder();

            configurator.Invoke(builder);

            _actionsSection.Elements.Add(builder.Build());
            
            return this;
        }

        public IActionsSectionConfigurator WithId(string id)
        {
            _actionsSection.BlockId = id;

            return this;
        }

        public ActionsSection Build()
        {
            return _actionsSection;
        }
    }
}
using System;
using HttpSlackBot.Blocks.Builders.Checkboxes;
using HttpSlackBot.Blocks.Builders.Workflow;

namespace HttpSlackBot.Blocks.Builders
{
    public interface IActionsSectionBuilder : IButtonContainer<IActionsSectionBuilder>,
                                              ICheckboxesContainer<IActionsSectionBuilder>,
                                              IDatePickerContainer<IActionsSectionBuilder>,
                                              IDateTimePickerContainer<IActionsSectionBuilder>,
                                              IMultiSelectMenuContainer<IActionsSectionBuilder>,
                                              IOverflowMenuContainer<IActionsSectionBuilder>,
                                              IRadioButtonsContainer<IActionsSectionBuilder>,
                                              ISelectMenuContainer<IActionsSectionBuilder>,
                                              ITimePickerContainer<IActionsSectionBuilder>,
                                              IWorkflowButtonContainer<IActionsSectionBuilder>
    {
        IActionsSectionBuilder WithId(string id);
    }

    public class ActionsSectionBuilder : IActionsSectionBuilder
    {
        private ActionsSection _actionsSection = new ActionsSection();

        public IActionsSectionBuilder WithButton(Action<IButtonConfigurator> configurator)
        {
            var builder = new ButtonBuilder();

            configurator.Invoke(builder);

            _actionsSection.Elements.Add(builder.Build());

            return this;
        }

        public IActionsSectionBuilder WithCheckboxes(Action<ICheckboxesConfigurator> configurator)
        {
            var builder = new CheckboxesBuilder();

            configurator.Invoke(builder);

            _actionsSection.Elements.Add(builder.Build());

            return this;
        }

        public IActionsSectionBuilder WithDatePicker(Action<IDatePickerConfigurator> configurator)
        {
            var builder = new DatePickerBuilder();

            configurator.Invoke(builder);

            _actionsSection.Elements.Add(builder.Build());

            return this;
        }

        public IActionsSectionBuilder WithDateTimePicker(Action<IDateTimePickerConfigurator> configurator)
        {
            var builder = new DateTimePickerBuilder();

            configurator.Invoke(builder);

            _actionsSection.Elements.Add(builder.Build());

            return this;
        }

        public IActionsSectionBuilder WithMultiSelectMenu(Action<IMultiSelectMenuConfigurator> configurator)
        {
            var builder = new MultiSelectMenuBuilder();

            configurator.Invoke(builder);

            _actionsSection.Elements.Add(builder.Build());

            return this;
        }

        public IActionsSectionBuilder WithOverflowMenu(Action<IOverflowMenuConfigurator> configurator)
        {
            var builder = new OverflowMenuBuilder();

            configurator.Invoke(builder);

            _actionsSection.Elements.Add(builder.Build());

            return this;
        }

        public IActionsSectionBuilder WithRadioButtons(Action<IRadioButtonsConfigurator> configurator)
        {
            var builder = new RadioButtonsBuilder();

            configurator.Invoke(builder);

            _actionsSection.Elements.Add(builder.Build());
            
            return this;
        }

        public IActionsSectionBuilder WithSelectMenu(Action<ISelectMenuConfigurator> configurator)
        {
            var builder = new SelectMenuBuilder();

            configurator.Invoke(builder);

            _actionsSection.Elements.Add(builder.Build());
            
            return this;
        }

        public IActionsSectionBuilder WithTimePicker(Action<ITimePickerConfigurator> configurator)
        {
            var builder = new TimePickerBuilder();

            configurator.Invoke(builder);

            _actionsSection.Elements.Add(builder.Build());
            
            return this;
        }

        public IActionsSectionBuilder WithWorkflowButton(Action<IWorkflowButtonConfigurator> configurator)
        {
            var builder = new WorkflowButtonBuilder();

            configurator.Invoke(builder);

            _actionsSection.Elements.Add(builder.Build());
            
            return this;
        }

        public IActionsSectionBuilder WithId(string id)
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
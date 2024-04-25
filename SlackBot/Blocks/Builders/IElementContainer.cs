using System;
using HttpSlackBot.Blocks.Builders.Checkboxes;

namespace HttpSlackBot.Blocks.Builders
{
    public interface IElementContainer<T>
    {
    }

    public interface IButtonContainer<T> : IElementContainer<T>
    {
        T WithButton(Action<IButtonConfigurator> builder);
    }

    public interface ICheckboxesContainer<T> : IElementContainer<T>
    {
        T WithCheckboxes(Action<ICheckboxesConfigurator> builder);
    }

    public interface IDatePickerContainer<T> : IElementContainer<T>
    {
        T WithDatePicker(Action<IDatePickerConfigurator> builder);
    }

    public interface IImageContainer<T> : IElementContainer<T>
    {
        T WithImage(Action<IImageConfigurator> builder);
    }

    public interface IMultiSelectMenuContainer<T> : IElementContainer<T>
    {
        T WithMultiSelectMenu(Action<IMultiSelectMenuConfigurator> builder);
    }
}
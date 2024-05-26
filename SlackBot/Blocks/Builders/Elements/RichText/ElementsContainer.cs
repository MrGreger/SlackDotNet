using System;
using HttpSlackBot.Blocks.Builders.RichText.Elements;
using HttpSlackBot.Interactions.Elements;

namespace HttpSlackBot.Blocks.Builders.RichText
{
    public interface IElementsContainerConfigurator
    {
        IElementsContainerConfigurator WithChannel(Action<IChannelConfigurator> configurator);
        IElementsContainerConfigurator WithEmoji(string name);
        IElementsContainerConfigurator WithLink(Action<ILinkConfigurator> configurator);
        IElementsContainerConfigurator WithText(Action<ITextConfigurator> configurator);
        IElementsContainerConfigurator WithUser(Action<IUserConfigurator> configurator);
        IElementsContainerConfigurator WithUserGroup(Action<IUserGroupConfigurator> configurator);
    }
    
    public abstract class ElementsContainer : IElementsContainerConfigurator
    { 
        protected abstract void AddElement(RichTextElementBase element);

        public IElementsContainerConfigurator WithChannel(Action<IChannelConfigurator> configurator)
        {
            var builder = new ChannelBuilder();
            
            configurator.Invoke(builder);

            AddElement(builder.Build());
            
            return this;
        }
        
        public IElementsContainerConfigurator WithEmoji(string name)
        {
            AddElement(new EmojiElement()
            {
                Name = name
            });
            
            return this;
        }
        
        public IElementsContainerConfigurator WithLink(Action<ILinkConfigurator> configurator)
        {
            var builder = new LinkBuilder();
            
            configurator.Invoke(builder);

            AddElement(builder.Build());
            
            return this;
        }
        
        public IElementsContainerConfigurator WithText(Action<ITextConfigurator> configurator)
        {
            var builder = new TextBuilder();
            
            configurator.Invoke(builder);

            AddElement(builder.Build());
            
            return this;
        }
        
        public IElementsContainerConfigurator WithUser(Action<IUserConfigurator> configurator)
        {
            var builder = new UserBuilder();
            
            configurator.Invoke(builder);

            AddElement(builder.Build());
            
            return this;
        }
        
        public IElementsContainerConfigurator WithUserGroup(Action<IUserGroupConfigurator> configurator)
        {
            var builder = new UserGroupBuilder();
            
            configurator.Invoke(builder);

            AddElement(builder.Build());
            
            return this;
        }
    }
}
using System;
using HttpSlackBot.Blocks.Builders.Text;

namespace HttpSlackBot.Blocks.Builders
{
    public interface IHeaderBlockConfigurator
    {
        IHeaderBlockConfigurator WithId(string id);
        IHeaderBlockConfigurator WithText(Action<IPlainTextConfigurator> withText);
    }

    public class HeaderBlockBuilder : IHeaderBlockConfigurator
    {
        private PlainText _text;
        private string _id;

        public IHeaderBlockConfigurator WithId(string id)
        {
            _id = id;

            return this;
        }

        public IHeaderBlockConfigurator WithText(Action<IPlainTextConfigurator> withText)
        {
            var builder = new PlainTextBuilder("Header");

            withText.Invoke(builder);

            _text = builder.Build();

            return this;
        }

        public HeaderBlock Build()
        {
            if (_text == null)
            {
                throw new InvalidOperationException("Text is required");
            }

            return new HeaderBlock()
                   {
                       Elements = _text,
                       BlockId = _id
                   };
        }
    }
}
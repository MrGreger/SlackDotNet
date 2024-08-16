namespace SlackBot.Blocks.Builders
{
    public interface IDividerConfigurator
    {
        IDividerConfigurator WithId(string id);
    }
    
    public class DividerBuilder : IDividerConfigurator
    {
        private Divider _divider = new Divider();
        
        public IDividerConfigurator WithId(string id)
        {
            _divider.BlockId = id;

            return this;
        }

        public Divider Build()
        {
            return _divider;
        }
    }
}
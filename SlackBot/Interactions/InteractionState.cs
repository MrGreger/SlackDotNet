using Newtonsoft.Json;

namespace SlackBotDotNet.Interactions
{
    public class InteractionState<T>
    {
        [JsonProperty("values")]
        public T Values { get; set; }
    }
}

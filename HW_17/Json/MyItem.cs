using Newtonsoft.Json;

namespace Json
{
    internal class MyItem
    {
        [JsonProperty("MyAge")]
        public int Age { get; set; }

        [JsonIgnore]
        public string Name { get; set; }
    }
}

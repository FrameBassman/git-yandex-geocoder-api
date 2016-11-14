using RestSharp.Deserializers;

namespace Yandex.Api.Entities
{
    [DeserializeAs(Name = "text")]
    public class Text
    {
        public string Value { get; set; }
    }
}

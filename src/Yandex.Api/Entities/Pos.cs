namespace Yandex.Api.Entities
{
    using RestSharp.Deserializers;

    [DeserializeAs(Name = "pos")]
    public class Pos
    {
        public string Value { get; set; }
    }
}

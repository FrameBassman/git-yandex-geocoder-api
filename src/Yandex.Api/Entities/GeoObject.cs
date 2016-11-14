using RestSharp.Deserializers;

namespace Yandex.Api.Entities
{
    public class GeoObject
    {
        [DeserializeAs(Name = "name")]
        public Name Name { get; set; }
    }
}

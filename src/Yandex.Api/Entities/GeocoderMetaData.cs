using RestSharp.Deserializers;

namespace Yandex.Api.Entities
{
    [DeserializeAs(Name = "GeocoderMetaData")]
    public class GeocoderMetaData
    {
        [DeserializeAs(Name = "text")]
        public Text Text { get; set; }

        public AddressDetails AddressDetails { get; set; }
    }
}

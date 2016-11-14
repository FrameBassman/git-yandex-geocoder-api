using System.Collections.Generic;
using RestSharp.Deserializers;

namespace Yandex.Api.Entities
{
    public class GeoObjectCollection
    {
        [DeserializeAs(Name = "featureMember")]
        public List<FeatureMember> FeatureMember { get; set; }

        [DeserializeAs(Name = "metaDataProperty")]
        public MetaDataProperty MetaDataProperty { get; set; }
    }
}
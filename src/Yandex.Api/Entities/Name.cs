using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace Yandex.Api.Entities
{
    [DeserializeAs(Name = "name")]
    public class Name
    {
        public string Value { get; set; }
    }
}

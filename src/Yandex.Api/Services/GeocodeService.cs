namespace Yandex.Api.Services
{
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Globalization;

    using Entities;
    using RestSharp;
    
    public class GeocodeService : MapService
    {
        private static string baseUrl = "http://geocode-maps.yandex.ru";

        public GeocodeService() : base(baseUrl)
        {
        }

        public Point GetPoint(string address)
        {
            var request = new RestRequest("1.x");
            request.AddQueryParameter("geocode", address);
            var response = Get<Response>(request);

            if (response.StatusCode == HttpStatusCode.InternalServerError)
            {
                throw new HttpRequestException(response.ErrorMessage);
            }

            return response.Data.GeoObjectCollection.FeatureMember.First().Point;
        }

        public AddressDetails GetAddress(Point point)
        {
            var request = new RestRequest("1.x");
            request.AddQueryParameter("geocode", point.Latitude.ToString(CultureInfo.InvariantCulture) + ',' + point.Longitude.ToString(CultureInfo.InvariantCulture));
            var response = Get<Response>(request);

            if (response.StatusCode == HttpStatusCode.InternalServerError)
            {
                throw new HttpRequestException(response.ErrorMessage);
            }

            return response.Data.GeoObjectCollection.FeatureMember.First().MetaDataProperty.GeocoderMetaData.AddressDetails;
        }
    }
}

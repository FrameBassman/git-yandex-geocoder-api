namespace Yandex.Api.Services
{
    using System.Net;
    using RestSharp;
    using RestSharp.Deserializers;

    public abstract class MapService
    {
        private readonly RestClient _restClient;

        protected MapService(string baseUrl)
        {
            _restClient = new RestClient(baseUrl);
            _restClient.CookieContainer = new CookieContainer();
            _restClient.AddHandler("application/xml", new XmlDeserializer());
        }

        protected IRestResponse<T> Get<T>(RestRequest request) where T : new()
        {
            request.Method = Method.GET;
            var response = _restClient.Execute<T>(request);
            return response;
        }
    }
}

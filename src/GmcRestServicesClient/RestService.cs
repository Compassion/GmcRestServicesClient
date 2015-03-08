using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using RestSharp;

namespace GmcRestServicesClient
{
    internal class RestService : IRestService
    {
        private readonly string baseUrl;
        
        private readonly string apiKey;

        public RestService(string baseUrl, string apiKey)
        {
            this.baseUrl = baseUrl;
            this.apiKey = apiKey;
        }

        public TResponse Get<TResponse>(string resource, IDictionary<string, string> requestParameters = null) where TResponse : new()
        {
            var parameters = requestParameters != null ? new Dictionary<string, string>(requestParameters) : new Dictionary<string, string>();
            parameters.Add("api_key", apiKey);
            var paramString = string.Join("&", parameters.Select(kvp => string.Format("{0}={1}", kvp.Key, kvp.Value)));

            var client = new RestClient(baseUrl);
            var request = new RestRequest(string.Format("{0}?{1}", resource, paramString), Method.GET);
            request.AddHeader("Accept", "application/json");
            var response = client.Execute<TResponse>(request);
            if (response.StatusCode != HttpStatusCode.OK || response.ErrorException != null)
            {
                throw new RestServiceException(response.StatusCode, response.ErrorMessage, response.Content, response.ErrorException);
            }
            return response.Data;
        }
    }
}
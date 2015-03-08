using System.Collections.Generic;

namespace GmcRestServicesClient
{
    public interface IRestService
    {
        TResponse Get<TResponse>(string resource, IDictionary<string, string> requestParameters = null) where TResponse : new();
    }
}
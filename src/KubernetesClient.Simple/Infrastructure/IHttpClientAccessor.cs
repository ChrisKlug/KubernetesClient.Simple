using System.Net.Http;

namespace KubernetesClient.Simple.Infrastructure
{
    public interface IHttpClientAccessor
    {
        HttpClient GetHttpClient();
    }
}

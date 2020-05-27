using System.Net.Http;
using System.Threading.Tasks;

namespace KubernetesClient.Simple.Infrastructure
{
    public interface IRequestCredentialsProvider
    {
        Task ProcessHttpRequestMessage(HttpRequestMessage msg);
    }
}

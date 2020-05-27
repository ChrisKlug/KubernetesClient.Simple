using k8s;
using System.Net.Http;

namespace KubernetesClient.Simple.Infrastructure
{
    public class KubernetesHttpClientAccessor : IHttpClientAccessor
    {
        private readonly Kubernetes _kubernetes;

        public KubernetesHttpClientAccessor(Kubernetes kubernetes)
        {
            _kubernetes = kubernetes;
        }

        public HttpClient GetHttpClient() => _kubernetes.HttpClient;
    }
}

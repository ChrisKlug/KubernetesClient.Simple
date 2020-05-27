using k8s;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace KubernetesClient.Simple.Infrastructure
{
    public class KubernetesRequestCredentialsProvider : IRequestCredentialsProvider
    {
        private readonly Kubernetes _kubernetes;

        public KubernetesRequestCredentialsProvider(Kubernetes kubernetes)
        {
            _kubernetes = kubernetes;
        }


        public Task ProcessHttpRequestMessage(HttpRequestMessage msg)
        {
            if (_kubernetes.Credentials == null)
            {
                return Task.CompletedTask;
            }

            return _kubernetes.Credentials.ProcessHttpRequestAsync(msg, CancellationToken.None);
        }
    }
}

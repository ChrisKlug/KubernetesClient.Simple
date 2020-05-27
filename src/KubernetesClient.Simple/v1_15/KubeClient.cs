using KubernetesClient.Simple.Infrastructure;

namespace KubernetesClient.Simple.v1_15
{
    public class KubeClient : KubeClientBase, IKubeClient
    {
        public KubeClient(IUrlGenerator urlGenerator, IHttpClientAccessor httpClientAccessor, 
            IRequestCredentialsProvider requestCredentialsProvider, IResourceDefinitionRepository resourceDefinitionRepository) : 
            base(urlGenerator, httpClientAccessor, requestCredentialsProvider, resourceDefinitionRepository)
        {

        }
    }
}
